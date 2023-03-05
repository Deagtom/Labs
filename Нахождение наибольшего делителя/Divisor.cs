namespace Нахождение_наибольшего_делителя
{
    public partial class Divisor : Form
    {
        public Divisor()
        {
            InitializeComponent();
            BaseStart();
        }

        private Point lastPoint;

        private int firstValue,
                    secondValue,
                    divisorValue;

        private void BaseStart()
        {
            FirstValue.Text = "0";
            SecondValue.Text = "0";
        }

        private int NOD()
        {
            for (int i = firstValue; i > 0; i--)
            {
                if (firstValue % i == 0)
                {
                    if (secondValue % i == 0)
                    {
                        divisorValue = i;
                        break;
                    }
                }
            }
            return divisorValue;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstValue = int.Parse(FirstValue.Text);
                secondValue = int.Parse(SecondValue.Text);
                NOD();
                DivisorValue.Text = Convert.ToString(divisorValue);
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