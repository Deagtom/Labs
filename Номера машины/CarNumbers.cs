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

        List<string[]> info = new List<string[]>();
        string[] values = new string[4];

        private bool IsCarNumber()
        {
            if (CarNumbersTextBox.Text.Length == 6 && 
                char.IsLetter(CarNumbersTextBox.Text[0]) &&
                char.IsDigit(CarNumbersTextBox.Text[1]) &&
                char.IsDigit(CarNumbersTextBox.Text[2]) &&
                char.IsDigit(CarNumbersTextBox.Text[3]) &&
                char.IsLetter(CarNumbersTextBox.Text[4]) &&
                char.IsLetter(CarNumbersTextBox.Text[5]))
            {
                return true;
            }
            return false;
        }

        private void NumbersListBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                number = NumbersListBox.SelectedItem.ToString();
                for (int i = 0; i < info.Count; i++)
                {
                    if (number == info[i][0])
                    {
                        CarNumbersTextBox.Text = info[i][0];
                        ModelComboBox.Text = info[i][1];
                        ColorComboBox.Text = info[i][2];
                        NameTextBox.Text = info[i][3];
                        SaveButton.Enabled = false;
                    }
                }
            }
            catch
            {

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            number = CarNumbersTextBox.Text.ToUpperInvariant();
            if (!NumbersListBox.Items.Contains(number))
            {
                if (IsCarNumber())
                {
                    NumbersListBox.Items.Add(number);
                    values[0] = number;
                    values[1] = ModelComboBox.Text;
                    values[2] = ColorComboBox.Text;
                    values[3] = NameTextBox.Text;
                    info.Add(values);
                }
                else
                {
                    MessageBox.Show("Введите номер правильно\n\nПример: х000хх");
                    CarNumbersTextBox.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Дубликаты не допускаются");
                CarNumbersTextBox.Text = string.Empty;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            CarNumbersTextBox.Text = string.Empty;
            ModelComboBox.SelectedItem = null;
            ColorComboBox.SelectedItem = null;
            NameTextBox.Text = string.Empty;
            SaveButton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            number = NumbersListBox.SelectedItem.ToString();
            for (int i = 0; i < info.Count; i++)
            {
                if (number == info[i][0])
                {
                    info.Remove(info[i]);
                    NumbersListBox.Items.Remove(NumbersListBox.SelectedIndex);
                }
            }
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