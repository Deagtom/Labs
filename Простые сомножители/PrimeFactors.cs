namespace Простые_сомножители
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private Point lastPoint;

        private int number,
                    divieder;                    

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Factors.Text = string.Empty;
                number = int.Parse(Value.Text);
                while (number % 2 == 0 && number != 0)
                {
                    number /= 2;
                    Factors.Text += "2 * ";
                }
                divieder = 3;
                while (number > 1)
                {
                    if (number % divieder == 0)
                    {
                        number /= divieder;
                        Factors.Text += $"{divieder} * ";
                    }
                    else
                    {
                        divieder += 2;
                    }
                }
                Factors.Text = Factors.Text.Remove(Factors.Text.Length - 3);
            }
            catch
            {
                MessageBox.Show("Введите число правильно");
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