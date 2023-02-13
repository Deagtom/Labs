namespace Жалюзи
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Background = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.ComboBox();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.GroupBox();
            this.TypeMosaic = new System.Windows.Forms.RadioButton();
            this.TypeRolled = new System.Windows.Forms.RadioButton();
            this.TypeVertical = new System.Windows.Forms.RadioButton();
            this.TypeHorizontal = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.TypeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.ClearButton);
            this.Background.Controls.Add(this.CalculateButton);
            this.Background.Controls.Add(this.Price);
            this.Background.Controls.Add(this.PriceLabel);
            this.Background.Controls.Add(this.Material);
            this.Background.Controls.Add(this.MaterialLabel);
            this.Background.Controls.Add(this.Height);
            this.Background.Controls.Add(this.HeightLabel);
            this.Background.Controls.Add(this.Width);
            this.Background.Controls.Add(this.WidthLabel);
            this.Background.Controls.Add(this.TypeBox);
            this.Background.Controls.Add(this.ExitButton);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1000, 600);
            this.Background.TabIndex = 0;
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Background_MouseDown);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(625, 500);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(177, 46);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(201, 500);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(177, 46);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(665, 361);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(242, 43);
            this.Price.TabIndex = 12;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(594, 370);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(65, 30);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "Цена";
            // 
            // Material
            // 
            this.Material.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Material.FormattingEnabled = true;
            this.Material.Items.AddRange(new object[] {
            "Алюминий",
            "Железо",
            "Пластик"});
            this.Material.Location = new System.Drawing.Point(201, 361);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(172, 45);
            this.Material.TabIndex = 10;
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaterialLabel.Location = new System.Drawing.Point(60, 361);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(115, 30);
            this.MaterialLabel.TabIndex = 9;
            this.MaterialLabel.Text = "Материал";
            // 
            // Height
            // 
            this.Height.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Height.Location = new System.Drawing.Point(201, 209);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(172, 43);
            this.Height.TabIndex = 8;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeightLabel.Location = new System.Drawing.Point(60, 216);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(135, 30);
            this.HeightLabel.TabIndex = 7;
            this.HeightLabel.Text = "Высота (см)";
            // 
            // Width
            // 
            this.Width.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Width.Location = new System.Drawing.Point(201, 142);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(172, 43);
            this.Width.TabIndex = 6;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WidthLabel.Location = new System.Drawing.Point(60, 149);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(145, 30);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Ширина (см)";
            // 
            // TypeBox
            // 
            this.TypeBox.Controls.Add(this.TypeMosaic);
            this.TypeBox.Controls.Add(this.TypeRolled);
            this.TypeBox.Controls.Add(this.TypeVertical);
            this.TypeBox.Controls.Add(this.TypeHorizontal);
            this.TypeBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeBox.Location = new System.Drawing.Point(594, 109);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(313, 169);
            this.TypeBox.TabIndex = 2;
            this.TypeBox.TabStop = false;
            this.TypeBox.Text = "Тип жалюзи";
            // 
            // TypeMosaic
            // 
            this.TypeMosaic.AutoSize = true;
            this.TypeMosaic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeMosaic.Location = new System.Drawing.Point(6, 138);
            this.TypeMosaic.Name = "TypeMosaic";
            this.TypeMosaic.Size = new System.Drawing.Size(112, 25);
            this.TypeMosaic.TabIndex = 3;
            this.TypeMosaic.TabStop = true;
            this.TypeMosaic.Text = "Мозаичные";
            this.TypeMosaic.UseVisualStyleBackColor = true;
            // 
            // TypeRolled
            // 
            this.TypeRolled.AutoSize = true;
            this.TypeRolled.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeRolled.Location = new System.Drawing.Point(6, 107);
            this.TypeRolled.Name = "TypeRolled";
            this.TypeRolled.Size = new System.Drawing.Size(99, 25);
            this.TypeRolled.TabIndex = 2;
            this.TypeRolled.TabStop = true;
            this.TypeRolled.Text = "Рулонные";
            this.TypeRolled.UseVisualStyleBackColor = true;
            // 
            // TypeVertical
            // 
            this.TypeVertical.AutoSize = true;
            this.TypeVertical.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeVertical.Location = new System.Drawing.Point(6, 76);
            this.TypeVertical.Name = "TypeVertical";
            this.TypeVertical.Size = new System.Drawing.Size(130, 25);
            this.TypeVertical.TabIndex = 1;
            this.TypeVertical.TabStop = true;
            this.TypeVertical.Text = "Вертикальные";
            this.TypeVertical.UseVisualStyleBackColor = true;
            // 
            // TypeHorizontal
            // 
            this.TypeHorizontal.AutoSize = true;
            this.TypeHorizontal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeHorizontal.Location = new System.Drawing.Point(6, 45);
            this.TypeHorizontal.Name = "TypeHorizontal";
            this.TypeHorizontal.Size = new System.Drawing.Size(147, 25);
            this.TypeHorizontal.TabIndex = 0;
            this.TypeHorizontal.TabStop = true;
            this.TypeHorizontal.Text = "Горизонтальные";
            this.TypeHorizontal.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(959, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 45);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.TypeBox.ResumeLayout(false);
            this.TypeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Background;
        private Label ExitButton;
        private GroupBox TypeBox;
        private RadioButton TypeMosaic;
        private RadioButton TypeRolled;
        private RadioButton TypeVertical;
        private RadioButton TypeHorizontal;
        private Label MaterialLabel;
        private TextBox Height;
        private Label HeightLabel;
        private TextBox Width;
        private Label WidthLabel;
        private ComboBox Material;
        private TextBox Price;
        private Label PriceLabel;
        private Button ClearButton;
        private Button CalculateButton;
    }
}