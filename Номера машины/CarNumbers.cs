namespace Номера_машины
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            IsVisibleData(false);
            EnterOrChangeGomboBox.SelectedIndex = 1;
        }

        private Point lastPoint;

        private string number;

        List<Car> info = new List<Car>();

        private void IsVisibleData(bool enabled)
        {
            InfoGroupBox.Visible = enabled;
        }

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
            if (NumbersListBox.Items.Count > 0)
            {
                number = NumbersListBox.SelectedItem.ToString() ?? "X000XX";
                for (int i = 0; i < info.Count; i++)
                {
                    if (number == info[i].Gosnomer)
                    {
                        CarNumbersTextBox.Text = info[i].Gosnomer;
                        ModelComboBox.Text = info[i].Model;
                        ColorComboBox.Text = info[i].Color;
                        NameTextBox.Text = info[i].FIO;
                        IsVisibleData(true);
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!NumbersListBox.Items.Contains(CarNumbersTextBox.Text.ToUpperInvariant()))
            {
                if (IsCarNumber())
                {
                    NumbersListBox.Items.Add(CarNumbersTextBox.Text.ToUpperInvariant());
                    info.Add(new Car(CarNumbersTextBox.Text.ToUpperInvariant(),
                                     ModelComboBox.Text,
                                     ColorComboBox.Text,
                                     NameTextBox.Text));

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

        private void Clear()
        {
            CarNumbersTextBox.Text = string.Empty;
            ModelComboBox.SelectedItem = null;
            ColorComboBox.SelectedItem = null;
            NameTextBox.Text = string.Empty;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            number = NumbersListBox.SelectedItem.ToString() ?? "X000XX";
            for (int i = 0; i < info.Count; i++)
            {
                if (number == info[i].Gosnomer)
                {
                    info.Remove(info[i]);
                    NumbersListBox.Items.Clear();
                    foreach (var item in info)
                    {
                        NumbersListBox.Items.Add(item.Gosnomer);
                    }
                    Clear();
                }
            }
        }

        private void EnterOrChangeGomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EnterOrChangeGomboBox.SelectedIndex)
            {
                case 0:
                    {
                        IsVisibleData(true);
                        break;
                    }
                case 1:
                    {
                        IsVisibleData(false);
                        break;
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