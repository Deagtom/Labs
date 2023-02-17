using Комплектация_автомибиля.Properties;

namespace Комплектация_автомибиля
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            BaseStart();
            Model.SelectedIndex = 0;
        }

        private Point lastPoint;

        private const uint KIA_PRICE = 1650000,
                           BMW_PRICE = 6200000,
                           MERCEDES_PRICE = 8500000;

        private const float OPTION_ABC_PRICE = 0.13f,
                            OPTION_FOG_LIGHTS_PRICE = 0.05f,
                            OPTION_PARKTRONIK_PRICE = 0.11f,
                            OPTION_LEATHER_INTERIOR_PRICE = 0.18f;

        private void BaseStart()
        {
            OptionABC.Checked = false;
            OptionFogLights.Checked = false;
            OptionParktronik.Checked = false;
            OptionLeatherInterior.Checked = false;
            Price.Text = string.Empty;
        }

        private string CarPrice(uint Price)
        {
            double result = Price;
            if (OptionABC.Checked)
            {
                result += Price * OPTION_ABC_PRICE;
            }
            if (OptionFogLights.Checked)
            {
                result += Price * OPTION_FOG_LIGHTS_PRICE;
            }
            if (OptionParktronik.Checked)
            {
                result += Price * OPTION_PARKTRONIK_PRICE;
            }
            if (OptionLeatherInterior.Checked)
            {
                result += Price * OPTION_LEATHER_INTERIOR_PRICE;
            }
            return Convert.ToString(Math.Round(result, 0)) + "₽";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (Model.SelectedIndex == 0)
            {
                Price.Text = CarPrice(KIA_PRICE);
            }
            else if (Model.SelectedIndex == 1)
            {
                Price.Text = CarPrice(BMW_PRICE);
            }
            else if (Model.SelectedIndex == 2)
            {
                Price.Text = CarPrice(MERCEDES_PRICE);
            }
        }

        private void Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Model.SelectedIndex)
            {
                case 0:
                    {
                        ModelPicture.Image = Resources.Kia_Rio;
                        BasePrice.Text = Convert.ToString(KIA_PRICE) + "₽";
                        break;
                    }
                case 1:
                    {
                        ModelPicture.Image = Resources.BMW_M5;
                        BasePrice.Text = Convert.ToString(BMW_PRICE) + "₽";
                        break;
                    }
                case 2:
                    {
                        ModelPicture.Image = Resources.Mercedes_AMG_GT;
                        BasePrice.Text = Convert.ToString(MERCEDES_PRICE) + "₽";
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BaseStart();
            Price.Text = string.Empty;
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