namespace Текстовое_представление
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            AppendDictionary();
        }

        private Point lastPoint;

        private readonly Dictionary<char, string> zeroToTen = new(),
                                                  tenToTwenty = new(),
                                                  twentyToHundred = new(),
                                                  hundredToThousand = new();

        private void AppendDictionary()
        {
            zeroToTen.Add('1', "Один");
            zeroToTen.Add('2', "Два");
            zeroToTen.Add('3', "Три");
            zeroToTen.Add('4', "Четыре");
            zeroToTen.Add('5', "Пять");
            zeroToTen.Add('6', "Шесть");
            zeroToTen.Add('7', "Семь");
            zeroToTen.Add('8', "Восемь");
            zeroToTen.Add('9', "Девять");

            tenToTwenty.Add('0', "Десять");
            tenToTwenty.Add('1', "Одиннадцать");
            tenToTwenty.Add('2', "Двенадцать");
            tenToTwenty.Add('3', "Тринадцать");
            tenToTwenty.Add('4', "Четыренадцать");
            tenToTwenty.Add('5', "Пятнадцать");
            tenToTwenty.Add('6', "Шестьнадцать");
            tenToTwenty.Add('7', "Семьнадцать");
            tenToTwenty.Add('8', "Восемьнадцать");
            tenToTwenty.Add('9', "Девятнадцать");

            twentyToHundred.Add('2', "Двадцать");
            twentyToHundred.Add('3', "Тридцать");
            twentyToHundred.Add('4', "Сорок");
            twentyToHundred.Add('5', "Пятьдесят");
            twentyToHundred.Add('6', "Шестьдесят");
            twentyToHundred.Add('7', "Семьдесят");
            twentyToHundred.Add('8', "Восемьдесят");
            twentyToHundred.Add('9', "Девяносто");

            hundredToThousand.Add('1', "Сто");
            hundredToThousand.Add('2', "Двести");
            hundredToThousand.Add('3', "Триста");
            hundredToThousand.Add('4', "Четыреста");
            hundredToThousand.Add('5', "Пятьсот");
            hundredToThousand.Add('6', "Шестьсот");
            hundredToThousand.Add('7', "Семьсот");
            hundredToThousand.Add('8', "Восемьсот");
            hundredToThousand.Add('9', "Девятьсот");
        }

        private void Translate(Dictionary<char, string> dictionary, int index)
        {
            foreach (var item in dictionary)
            {
                if (item.Key == Value.Text[index])
                {
                    TextValue.Text += item.Value + " ";
                }
            }
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            if (Value.Text.Length <= 3 && int.TryParse(Value.Text, out int value))
            {
                TextValue.Text = string.Empty;
                if (Value.Text == "0")
                {
                    TextValue.Text = "Нуль";
                }
                else if (Value.Text.Length == 3)
                {
                    Translate(hundredToThousand, 0);
                    if (Value.Text[1] == '1')
                    {
                        Translate(tenToTwenty, 2);
                    }
                    else
                    {
                        Translate(twentyToHundred, 1);
                        Translate(zeroToTen, 2);
                    }
                }
                else if (Value.Text.Length == 2 && Value.Text[0] == '1')
                {
                    Translate(tenToTwenty, 1);
                }
                else if (Value.Text.Length == 2)
                {
                    Translate(twentyToHundred, 0);
                    Translate(zeroToTen, 1);
                }
                else if (Value.Text.Length == 1)
                {
                    Translate(zeroToTen, 0);
                }
            }
            else
            {
                MessageBox.Show("Введите значение правильно и меньше тысячи");
                Value.Text = string.Empty;
                TextValue.Text = string.Empty;
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