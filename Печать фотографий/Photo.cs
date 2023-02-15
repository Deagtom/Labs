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

        private const uint TypeBlackWhitePrice = 5,
                           TypeColoredPrice = 15,
                           TypeNegativePrice = 10;

        private const uint Size3x4Price = 7,
                           Size9x12Price = 21,
                           Size12x15Price = 27,
                           Size18x24Price = 42;

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
                result = Convert.ToString(uint.Parse(Count.Text) * Size * TypeBlackWhitePrice) + "₽";
            }
            else if (TypeColored.Checked)
            {
                result = Convert.ToString(uint.Parse(Count.Text) * Size * TypeColoredPrice) + "₽";
            }
            else if (TypeNegative.Checked)
            {
                result = Convert.ToString(uint.Parse(Count.Text) * Size * TypeNegativePrice) + "₽";
            }
            return result;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Size3x4.Checked)
                {
                    Price.Text = PricePhoto(Size3x4Price);
                }
                else if (Size9x12.Checked)
                {
                    Price.Text = PricePhoto(Size9x12Price);
                }
                else if (Size12x15.Checked)
                {
                    Price.Text = PricePhoto(Size12x15Price);
                }
                else if (Size18x24.Checked)
                {
                    Price.Text = PricePhoto(Size18x24Price);
                }
            }
            catch
            {
                MessageBox.Show("Введите количество правильно");
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
            BaseStart();
            Price.Text = string.Empty;
        }
    }
}