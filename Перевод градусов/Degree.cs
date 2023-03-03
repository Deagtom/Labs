namespace Перевод_градусов
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private Point lastPoint;

        private void Degrees(TextBox Degrees)
        {
            if (double.TryParse(Degrees.Text, out double value))
            {
                if (Degrees == CelsiusDegrees)
                {
                    TotalDegrees.Text = Convert.ToString(Math.Round(value * 1.8 + 32, 2)) + " °F";
                }
                else if (Degrees == FahrenheitDegrees)
                {
                    TotalDegrees.Text = Convert.ToString(Math.Round((value - 32) / 1.8, 2)) + " °C";
                }
            }
            else if (Degrees.Text == string.Empty)
            {
                TotalDegrees.Text = "0";
            }
            else if (Degrees.Text == "-")
            {
                TotalDegrees.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Введите значения правильно");
                Degrees.Text = string.Empty;
                TotalDegrees.Text = string.Empty;
            }
        }

        private void DegreesEnter(TextBox Degrees)
        {
            TotalDegrees.Text = string.Empty;
            if (Degrees == CelsiusDegrees)
            {
                FahrenheitDegrees.Text = string.Empty;
                TotalDegreesLabel.Text = "Цельсий в Фаренгейт";
            }
            else if (Degrees == FahrenheitDegrees)
            {
                CelsiusDegrees.Text = string.Empty;
                TotalDegreesLabel.Text = "Фаренгейт в Цельсий";
            }
        }

        private void CelsiusDegrees_TextChanged(object sender, EventArgs e)
        {
            Degrees(CelsiusDegrees);
        }

        private void FahrenheitDegrees_TextChanged(object sender, EventArgs e)
        {
            Degrees(FahrenheitDegrees);
        }

        private void CelsiusDegrees_Enter(object sender, EventArgs e)
        {
            DegreesEnter(CelsiusDegrees);
        }

        private void FahrenheitDegrees_Enter(object sender, EventArgs e)
        {
            DegreesEnter(FahrenheitDegrees);
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