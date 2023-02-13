using Комплектация_автомибиля.Properties;

namespace Комплектация_автомибиля
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Model.SelectedIndex = 0;
        }

        private Point lastPoint;

        private const uint KiaPrice = 1650000,
                           BMWPrice = 6200000,
                           MercedesPrice = 8500000;

        private const float OptionABCPrice = 0.13f,
                            OptionFogLightsPrice = 0.05f,
                            OptionPartronikPrice = 0.11f,
                            OptionLeatherInteriorPrice = 0.18f;

        private string CarPrice(uint Price)
        {
            double result = Price;
            if (OptionABC.Checked)
            {
                result += Price * OptionABCPrice;
            }
            if (OptionFogLights.Checked)
            {
                result += Price * OptionFogLightsPrice;
            }
            if (OptionPartronik.Checked)
            {
                result += Price * OptionPartronikPrice;
            }
            if (OptionLeatherInterior.Checked)
            {
                result += Price * OptionLeatherInteriorPrice;
            }
            return Convert.ToString(Math.Round(result, 0)) + "₽";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (Model.SelectedIndex == 0)
            {
                Price.Text = CarPrice(KiaPrice);
            }
            else if (Model.SelectedIndex == 1)
            {
                Price.Text = CarPrice(BMWPrice);
            }
            else if (Model.SelectedIndex == 2)
            {
                Price.Text = CarPrice(MercedesPrice);
            }
        }

        private void Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Model.SelectedIndex)
            {
                case 0:
                    {
                        ModelPicture.Image = Resources.Kia_Rio;
                        BasePrice.Text = Convert.ToString(KiaPrice) + "₽";
                        break;
                    }
                case 1:
                    {
                        ModelPicture.Image = Resources.BMW_M5;
                        BasePrice.Text = Convert.ToString(BMWPrice) + "₽";
                        break;
                    }
                case 2:
                    {
                        ModelPicture.Image = Resources.Mercedes_AMG_GT;
                        BasePrice.Text = Convert.ToString(MercedesPrice) + "₽";
                        break;
                    }
            }
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Price.Text = string.Empty;
        }
    }
}