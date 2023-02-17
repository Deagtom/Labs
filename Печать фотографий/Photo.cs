namespace Печать_фотографий
{
    public partial class Photo : Form
    {
        public Photo()
        {
            InitializeComponent();
            BaseStart();
        }

        private Point lastPoint;

        private const uint TYPE_BLACK_WHITE_PRICE = 5,
                           TYPE_COLORED_PRICE = 15,
                           TYPE_NEGATIV_PRICE = 10;

        private const uint SIZE_3X4_PRICE = 7,
                           SIZE_9X12_PRICE = 21,
                           SIZE_12X15_PRICE = 27,
                           SIZE_18X24_PRICE = 42;

        private void BaseStart()
        {
            TypeBlackWhite.Checked = true;
            Size3x4.Checked = true;
            Count.Text = "0";
        }

        private string PricePhoto(uint Size)
        {
            string result = string.Empty;
            if (TypeBlackWhite.Checked)
            {
                result = Convert.ToString(uint.Parse(Count.Text) * Size * TYPE_BLACK_WHITE_PRICE) + "₽";
            }
            else if (TypeColored.Checked)
            {
                result = Convert.ToString(uint.Parse(Count.Text) * Size * TYPE_COLORED_PRICE) + "₽";
            }
            else if (TypeNegative.Checked)
            {
                result = Convert.ToString(uint.Parse(Count.Text) * Size * TYPE_NEGATIV_PRICE) + "₽";
            }
            return result;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Size3x4.Checked)
                {
                    Price.Text = PricePhoto(SIZE_3X4_PRICE);
                }
                else if (Size9x12.Checked)
                {
                    Price.Text = PricePhoto(SIZE_9X12_PRICE);
                }
                else if (Size12x15.Checked)
                {
                    Price.Text = PricePhoto(SIZE_12X15_PRICE);
                }
                else if (Size18x24.Checked)
                {
                    Price.Text = PricePhoto(SIZE_18X24_PRICE);
                }
            }
            catch
            {
                MessageBox.Show("Введите количество правильно");
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