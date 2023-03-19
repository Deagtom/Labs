using Номера_машины.Controllers;
using System.Data.OleDb;

namespace Номера_машины
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            controller = new OleDbConnection(ConnectionString.Connection);
            controller.Open();
            Start();
            ClearNullInListBox();
        }

        private OleDbCommand command;
        private OleDbConnection controller;
        private Point lastPoint;

        private string query = "SELECT count(*) FROM CarInfo";
        private string number = string.Empty;
        private List<Car> info = new List<Car>();

        private void IsVisibleData(bool enabled)
        {
            InfoGroupBox.Visible = enabled;
        }

        private void Start()
        {
            int count;
            command = new OleDbCommand(query, controller);
            count = int.Parse(command.ExecuteScalar().ToString());

            for (int i = 1; NumbersListBox.Items.Count <= count; i++)
            {
                ClearNullInListBox();
                query = $"SELECT Number FROM CarInfo WHERE ID = {i}";
                command = new OleDbCommand(query, controller);
                NumbersListBox.Items.Add(command.ExecuteScalar() ?? "");
            }

            for (int i = 1; i <= NumbersListBox.Items.Count + 1; i++)
            {
                query = $"SELECT Number, Model, Color, FIO FROM CarInfo WHERE ID = {i}";
                command = new OleDbCommand(query, controller);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    info.Add(new Car(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
                }
                reader.Close();
            }
        }

        private void ClearNullInListBox()
        {
            for (int i = 0; i < NumbersListBox.Items.Count; i++)
            {
                if (NumbersListBox.Items[i].ToString() == string.Empty)
                {
                    NumbersListBox.Items.Remove(NumbersListBox.Items[i]);
                }
            }
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
            try
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
            catch
            {
                MessageBox.Show("Выберите номер");
            }
        }

        private void Save()
        {
            number = CarNumbersTextBox.Text.ToUpperInvariant();
            if (!NumbersListBox.Items.Contains(number))
            {
                if (IsCarNumber())
                {
                    //query = $"INSERT INTO CarInfo (Number, Model, Color, FIO) VALUES ('{number}', '{ModelComboBox.Text}', '{ColorComboBox.Text}', '{NameTextBox.Text}')";
                    //command = new OleDbCommand(query, controller);
                    //command.ExecuteNonQuery();

                    NumbersListBox.Items.Add(number);
                    info.Add(new Car(number,
                                     ModelComboBox.Text,
                                     ColorComboBox.Text,
                                     NameTextBox.Text));
                    Clear();
                }
                else
                {
                    MessageBox.Show("Введите номер правильно\n\nПример: X000XX");
                    CarNumbersTextBox.Text = string.Empty;
                }
            }
            else
            {
                for (int i = 0; i < info.Count; i++)
                {
                    if (number == info[i].Gosnomer)
                    {
                        query = $"UPDATE CarInfo SET Model = '{ModelComboBox.Text}', Color = '{ColorComboBox.Text}', FIO = '{NameTextBox.Text}' WHERE Number = '{number}'";
                        command = new OleDbCommand(query, controller);
                        command.ExecuteNonQuery();

                        info[i].Model = ModelComboBox.Text;
                        info[i].Color = ColorComboBox.Text;
                        info[i].FIO = NameTextBox.Text;
                        Clear();
                    }
                }
            }
        }

        private void Clear()
        {
            CarNumbersTextBox.Text = string.Empty;
            ModelComboBox.SelectedItem = null;
            ColorComboBox.SelectedItem = null;
            NameTextBox.Text = string.Empty;
        }

        private void Remove()
        {
            try
            {
                number = NumbersListBox.SelectedItem.ToString() ?? "X000XX";
                for (int i = 0; i < info.Count; i++)
                {
                    if (number == info[i].Gosnomer)
                    {
                        query = $"DELETE FROM CarInfo WHERE Number = '{number}'";
                        command = new OleDbCommand(query, controller);
                        command.ExecuteNonQuery();

                        info.Remove(info[i]);
                        NumbersListBox.Items.Clear();
                        foreach (var item in info)
                        {
                            NumbersListBox.Items.Add(item.Gosnomer);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Выберите номер");
            }
        }

        private void CarNumbersTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Remove();
            Clear();
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

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.Close();
        }
    }
}
