using Любимые_напитки.Properties;

namespace Любимые_напитки
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            AppendListBoxes();
            DrinkablesList();
        }

        private Point lastPoint;

        private readonly string drinkables = Resources.DrinkablesText,
                                lovedDrinkables = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "loved drinkables.txt"),
                                unlovedDrinkables = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "unloved drinkables.txt");

        private readonly List<string> lovedDrinkablesList = new(),
                                      unlovedDrinkablesList = new();

        private static void FileReader(string drinkables, List<string> drinkablesList, ListBox Drinkables)
        {
            try
            {
                StreamReader reader = new(drinkables);
                while (!reader.EndOfStream)
                {
                    drinkablesList.Add(reader.ReadLine() ?? string.Empty);
                }
                foreach (string item in drinkablesList)
                {
                    if (item != string.Empty)
                    {
                        Drinkables.Items.Add(item);
                    }
                }
                reader.Close();
            }
            catch
            {
                File.Create(drinkables);
            }
        }

        private void AppendListBoxes()
        {
            FileReader(lovedDrinkables, lovedDrinkablesList, LovedDrinkables);
            FileReader(unlovedDrinkables, unlovedDrinkablesList, UnlovedDrinkables);
        }

        private void DrinkablesList()
        {
            string[] drinkablesArray = drinkables.Split('\n', '\r');
            List<string> drinkablesList = new();
            foreach (string drinkable in drinkablesArray)
            {
                drinkablesList.Add(drinkable);
            }
            drinkablesList.RemoveAll(x => x == "");
            foreach (string item in drinkablesList)
            {
               if (!LovedDrinkables.Items.Contains(item) && !UnlovedDrinkables.Items.Contains(item))
                {
                    Drinkables.Items.Add(item);
                }
            }
        }

        private static void MoveItem(ListBox from, ListBox to)
        {
            if (from.Items.Count == 0)
            {
                return;
            }
            object[] selectedItems = new object[from.SelectedItems.Count];
            from.SelectedItems.CopyTo(selectedItems, 0);
            foreach (object item in selectedItems)
            {
                from.Items.Remove(item);
                to.Items.Add(item);
            }
        }

        private void InLovedButton_Click(object sender, EventArgs e)
        {
            MoveItem(Drinkables, LovedDrinkables);
        }

        private void OutLovedButton_Click(object sender, EventArgs e)
        {
            MoveItem(LovedDrinkables, Drinkables);
        }

        private void InUnlovedButton_Click(object sender, EventArgs e)
        {
            MoveItem(Drinkables, UnlovedDrinkables);
        }

        private void OutUnlovedButton_Click(object sender, EventArgs e)
        {
            MoveItem(UnlovedDrinkables, Drinkables);
        }

        private void Save(string drinkables, ListBox Drinkables)
        {
            StreamWriter writer = new(drinkables);
            foreach (string item in Drinkables.Items)
            {
                if (item != string.Empty)
                {
                    writer.WriteLine(item);
                }
            }
            writer.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save(lovedDrinkables, LovedDrinkables);
            Save(unlovedDrinkables, UnlovedDrinkables);
        }

        private void Drinkables_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Drinkables_DragDrop(object sender, DragEventArgs e)
        {
            ListBox listFor = (ListBox)sender;
            if (listFor.SelectedItems.Count == 0)
            {
                Drinkables.Items.Remove(e.Data.GetData(DataFormats.Text));
                LovedDrinkables.Items.Remove(e.Data.GetData(DataFormats.Text));
                UnlovedDrinkables.Items.Remove(e.Data.GetData(DataFormats.Text));
                listFor.Items.Add(e.Data.GetData(DataFormats.Text));
            }
        }

        private void Drinkables_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listFrom = (ListBox)sender;
            ListBox listFor = new();
            try
            {
                listFor.DoDragDrop(listFrom.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            catch (NullReferenceException)
            {
                if (listFrom.Items.Count > 0)
                {
                    listFrom.SetSelected(listFrom.Items.Count - 1, true);
                    listFor.DoDragDrop(listFrom.Items[^1].ToString(), DragDropEffects.Copy);
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Background_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Background_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}