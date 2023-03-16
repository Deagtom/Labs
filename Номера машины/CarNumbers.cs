using System.Diagnostics;

namespace Номера_машины
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private Point lastPoint;

        private string number;

        List<List<string>> info = new List<List<string>>();
        List<string> values = new List<string>();


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CarNumbersTextBox.Text.Length == 6)
            {
                NumbersListBox.Items.Add(CarNumbersTextBox.Text);
                values.Clear();
                values.Add(CarNumbersTextBox.Text);
                values.Add(ModelTextBox.Text);
                values.Add(ColorComboBox.Text);
                values.Add(NameTextBox.Text);
                info.Add(values);


            }
            else
            {
                MessageBox.Show("Введите номер правильно\n\nПример: х000хх");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            CarNumbersTextBox.Text = string.Empty;
            ModelTextBox.Text = string.Empty;
            ColorComboBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            number = NumbersListBox.SelectedItem.ToString() ?? "х";
            foreach (List<string> item in info)
            {
                foreach (string number in item)
                {
                    if (this.number == number)
                    {
                        info.Remove(item);
                    }
                }
            }
            NumbersListBox.SelectedItem = null;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.White;
            ExitButton.BackColor = Color.Red;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Black;
            ExitButton.BackColor = Color.Transparent;
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