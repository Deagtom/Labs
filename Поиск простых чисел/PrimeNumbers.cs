namespace Поиск_простых_чисел
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private Point lastPoint;

        private int primeValue,
                    count = 0;

        private static bool IsPrimeNumber(int number)
        {
            int sqrtNumber = (int)Math.Sqrt(number);
            for (int i = 2; i <= sqrtNumber; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void EnabledObject(bool enabled)
        {
            PrimeValue.Enabled = enabled;
            CountValues.Enabled = enabled;
            FindButton.Enabled = enabled;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                primeValue = int.Parse(PrimeValue.Text);
                for (int number = primeValue; count != int.Parse(CountValues.Text); number++)
                {
                    if (IsPrimeNumber(number))
                    {
                        PrimeValuesListBox.Items.Add(number);
                        count++;
                    }
                }
                EnabledObject(false);
            }
            catch
            {
                MessageBox.Show("Введите значения правильно");
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