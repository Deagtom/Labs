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

        private readonly string drinkables = Resources.DrinkablesText;
        private readonly string lovedDrinkables = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "loved drinkables.txt");
        private readonly string unlovedDrinkables = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "unloved drinkables.txt");

        private readonly List<string> lovedDrinkablesList = new(),
                                      unlovedDrinkablesList = new();

        private void AppendListBoxes()
        {
            try
            {
                StreamReader reader = new(lovedDrinkables);
                while (!reader.EndOfStream)
                {
                    lovedDrinkablesList.Add(reader.ReadLine() ?? string.Empty);
                }
                foreach (string item in lovedDrinkablesList)
                {
                    if (item != string.Empty && item != null)
                    {
                        LovedDrinkables.Items.Add(item);
                    }
                }
                reader.Close();
            }
            catch
            {
                File.Create(lovedDrinkables);
            }

            try
            {
                StreamReader reader = new(unlovedDrinkables);
                while (!reader.EndOfStream)
                {
                    unlovedDrinkablesList.Add(reader.ReadLine() ?? string.Empty);
                }
                foreach (string item in unlovedDrinkablesList)
                {
                    if (item != string.Empty && item != null)
                    {
                        UnlovedDrinkables.Items.Add(item);
                    }
                }
                reader.Close();
            }
            catch
            {
                File.Create(unlovedDrinkables);
            }
        }

        private void DrinkablesList()
        {
            string[] drinkablesArray = drinkables.Split('\r');
            foreach (string item in drinkablesArray)
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter writerLoved = new(lovedDrinkables);
            foreach (string item in LovedDrinkables.Items)
            {
                if (item != string.Empty && item != null)
                {
                    writerLoved.WriteLine(item);
                }
            }
            writerLoved.Close();
            
            StreamWriter writerUnloved = new(unlovedDrinkables);
            foreach (string item in UnlovedDrinkables.Items)
            {
                if (item != string.Empty && item != null)
                {
                    writerUnloved.WriteLine(item);
                }
            }
            writerUnloved.Close();
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