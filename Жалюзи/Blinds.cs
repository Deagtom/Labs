namespace Жалюзи
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            BaseStart();
        }

        private Point lastPoint;

        private const uint MATERIAL_ALUMINUM_PRICE = 3,
                           MATERIAL_IRON_PRICE = 4,
                           MATERIAL_PLASTIC_PRICE = 2;

        private const uint TYPE_HORIZONTAL_PRICE = 2,
                           TYPE_VERTICAL_PRICE = 3,
                           TYPE_ROLLED_PRICE = 4,
                           TYPE_MOSAIC_PRICE = 5;

        private void BaseStart()
        {
            TypeHorizontal.Checked = true;
            Material.SelectedIndex = 0;
            WidthValue.Text = "0";
            HeightValue.Text = "0";
        }

        private string BlindsPrice(uint Type)
        {
            string result = string.Empty;
            if (Material.SelectedIndex == 0)
            {
                result = Convert.ToString(uint.Parse(WidthValue.Text) * uint.Parse(HeightValue.Text) * Type * MATERIAL_ALUMINUM_PRICE) + "₽";
            }
            else if (Material.SelectedIndex == 1)
            {
                result = Convert.ToString(uint.Parse(WidthValue.Text) * uint.Parse(HeightValue.Text) * Type * MATERIAL_IRON_PRICE) + "₽";
            }
            else if (Material.SelectedIndex == 2)
            {
                result = Convert.ToString(uint.Parse(WidthValue.Text) * uint.Parse(HeightValue.Text) * Type * MATERIAL_PLASTIC_PRICE) + "₽";
            }
            return result;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TypeHorizontal.Checked)
                {
                    Price.Text = BlindsPrice(TYPE_HORIZONTAL_PRICE);
                }
                else if (TypeVertical.Checked)
                {
                    Price.Text = BlindsPrice(TYPE_VERTICAL_PRICE);
                }
                else if (TypeRolled.Checked)
                {
                    Price.Text = BlindsPrice(TYPE_ROLLED_PRICE);
                }
                else if (TypeMosaic.Checked)
                {
                    Price.Text = BlindsPrice(TYPE_MOSAIC_PRICE);
                }
            }
            catch
            {
                MessageBox.Show("Введите ширину и высоту правильно");
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