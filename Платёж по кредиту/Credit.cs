namespace Платёж_по_кредиту
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            BaseStart();
        }

        private Point lastPoint;
        private int term;
        private double sum,
                       interest,
                       result;

        private void BaseStart()
        {
            TermCredit.Text = "1";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                sum = double.Parse(AmountCredit.Text);
                interest = double.Parse(InterestCredit.Text) / 100 / 12;
                term = int.Parse(TermCredit.Text);
                result = Math.Round(sum * (interest + interest / (Math.Pow(1 + interest, term) - 1)), 2);
                MontlyPaymentCredit.Text = Convert.ToString(result);
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