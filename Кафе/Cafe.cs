namespace Кафе
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            BaseStart();
        }

        private Point lastPoint;

        private uint price = 0;

        private const uint FOOD_BIG_MAC_PRICE = 165,
                           FOOD_SAUSE_PRICE = 32,
                           FOOD_BACON_PRICE = 65,
                           FOOD_POTATO_PRICE = 85;

        private string FoodPrice(uint Price)
        {
            if (FoodBigMac.Checked)
            {
                Price += FOOD_BIG_MAC_PRICE;
            }
            if (FoodSause.Checked)
            {
                Price += FOOD_SAUSE_PRICE;
            }
            if (FoodBacon.Checked)
            {
                Price += FOOD_BACON_PRICE;
            }
            if (FoodPotato.Checked)
            {
                Price += FOOD_POTATO_PRICE;
            }
            return Convert.ToString(Price) + "₽";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Price.Text = FoodPrice(price);
        }

        private void BaseStart()
        {
            FoodBigMac.Checked = false;
            FoodSause.Checked = false;
            FoodBacon.Checked = false;
            FoodPotato.Checked = false;
            Price.Text = string.Empty;
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BaseStart();
            Price.Text = string.Empty;
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