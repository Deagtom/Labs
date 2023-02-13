namespace Печать_фотографий
{
    partial class Photo
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
            this.Count = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.GroupBox();
            this.TypeNegative = new System.Windows.Forms.RadioButton();
            this.TypeColored = new System.Windows.Forms.RadioButton();
            this.TypeBlackWhite = new System.Windows.Forms.RadioButton();
            this.SizeBox = new System.Windows.Forms.GroupBox();
            this.Size18x24 = new System.Windows.Forms.RadioButton();
            this.Size12x15 = new System.Windows.Forms.RadioButton();
            this.Size9x12 = new System.Windows.Forms.RadioButton();
            this.Size3x4 = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.TypeBox.SuspendLayout();
            this.SizeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.ClearButton);
            this.Background.Controls.Add(this.CalculateButton);
            this.Background.Controls.Add(this.Price);
            this.Background.Controls.Add(this.PriceLabel);
            this.Background.Controls.Add(this.Count);
            this.Background.Controls.Add(this.CountLabel);
            this.Background.Controls.Add(this.TypeBox);
            this.Background.Controls.Add(this.SizeBox);
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
            this.ClearButton.Location = new System.Drawing.Point(594, 476);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(177, 46);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(170, 476);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(177, 46);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(659, 338);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(242, 43);
            this.Price.TabIndex = 6;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(588, 347);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(65, 30);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Цена";
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Count.Location = new System.Drawing.Point(311, 338);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(172, 43);
            this.Count.TabIndex = 4;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountLabel.Location = new System.Drawing.Point(170, 345);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(135, 30);
            this.CountLabel.TabIndex = 3;
            this.CountLabel.Text = "Количество";
            // 
            // TypeBox
            // 
            this.TypeBox.Controls.Add(this.TypeNegative);
            this.TypeBox.Controls.Add(this.TypeColored);
            this.TypeBox.Controls.Add(this.TypeBlackWhite);
            this.TypeBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeBox.Location = new System.Drawing.Point(588, 105);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(313, 169);
            this.TypeBox.TabIndex = 2;
            this.TypeBox.TabStop = false;
            this.TypeBox.Text = "Тип фото";
            // 
            // TypeNegative
            // 
            this.TypeNegative.AutoSize = true;
            this.TypeNegative.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeNegative.Location = new System.Drawing.Point(6, 138);
            this.TypeNegative.Name = "TypeNegative";
            this.TypeNegative.Size = new System.Drawing.Size(85, 25);
            this.TypeNegative.TabIndex = 3;
            this.TypeNegative.TabStop = true;
            this.TypeNegative.Text = "Негатив";
            this.TypeNegative.UseVisualStyleBackColor = true;
            // 
            // TypeColored
            // 
            this.TypeColored.AutoSize = true;
            this.TypeColored.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeColored.Location = new System.Drawing.Point(6, 96);
            this.TypeColored.Name = "TypeColored";
            this.TypeColored.Size = new System.Drawing.Size(89, 25);
            this.TypeColored.TabIndex = 2;
            this.TypeColored.TabStop = true;
            this.TypeColored.Text = "Цветное";
            this.TypeColored.UseVisualStyleBackColor = true;
            // 
            // TypeBlackWhite
            // 
            this.TypeBlackWhite.AutoSize = true;
            this.TypeBlackWhite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeBlackWhite.Location = new System.Drawing.Point(6, 55);
            this.TypeBlackWhite.Name = "TypeBlackWhite";
            this.TypeBlackWhite.Size = new System.Drawing.Size(116, 25);
            this.TypeBlackWhite.TabIndex = 1;
            this.TypeBlackWhite.TabStop = true;
            this.TypeBlackWhite.Text = "Чёрнобелое";
            this.TypeBlackWhite.UseVisualStyleBackColor = true;
            // 
            // SizeBox
            // 
            this.SizeBox.Controls.Add(this.Size18x24);
            this.SizeBox.Controls.Add(this.Size12x15);
            this.SizeBox.Controls.Add(this.Size9x12);
            this.SizeBox.Controls.Add(this.Size3x4);
            this.SizeBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SizeBox.Location = new System.Drawing.Point(170, 105);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(313, 169);
            this.SizeBox.TabIndex = 1;
            this.SizeBox.TabStop = false;
            this.SizeBox.Text = "Размер";
            // 
            // Size18x24
            // 
            this.Size18x24.AutoSize = true;
            this.Size18x24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size18x24.Location = new System.Drawing.Point(6, 138);
            this.Size18x24.Name = "Size18x24";
            this.Size18x24.Size = new System.Drawing.Size(79, 25);
            this.Size18x24.TabIndex = 3;
            this.Size18x24.TabStop = true;
            this.Size18x24.Text = "18 x 24";
            this.Size18x24.UseVisualStyleBackColor = true;
            // 
            // Size12x15
            // 
            this.Size12x15.AutoSize = true;
            this.Size12x15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size12x15.Location = new System.Drawing.Point(6, 107);
            this.Size12x15.Name = "Size12x15";
            this.Size12x15.Size = new System.Drawing.Size(79, 25);
            this.Size12x15.TabIndex = 2;
            this.Size12x15.TabStop = true;
            this.Size12x15.Text = "12 x 15";
            this.Size12x15.UseVisualStyleBackColor = true;
            // 
            // Size9x12
            // 
            this.Size9x12.AutoSize = true;
            this.Size9x12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size9x12.Location = new System.Drawing.Point(6, 76);
            this.Size9x12.Name = "Size9x12";
            this.Size9x12.Size = new System.Drawing.Size(70, 25);
            this.Size9x12.TabIndex = 1;
            this.Size9x12.TabStop = true;
            this.Size9x12.Text = "9 x 12";
            this.Size9x12.UseVisualStyleBackColor = true;
            // 
            // Size3x4
            // 
            this.Size3x4.AutoSize = true;
            this.Size3x4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size3x4.Location = new System.Drawing.Point(6, 45);
            this.Size3x4.Name = "Size3x4";
            this.Size3x4.Size = new System.Drawing.Size(61, 25);
            this.Size3x4.TabIndex = 0;
            this.Size3x4.TabStop = true;
            this.Size3x4.Text = "3 x 4";
            this.Size3x4.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(959, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 45);
            this.ExitButton.TabIndex = 0;
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
            this.SizeBox.ResumeLayout(false);
            this.SizeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Background;
        private Label ExitButton;
        private Button ClearButton;
        private Button CalculateButton;
        private TextBox Price;
        private Label PriceLabel;
        private TextBox Count;
        private Label CountLabel;
        private GroupBox TypeBox;
        private RadioButton TypeNegative;
        private RadioButton TypeColored;
        private RadioButton TypeBlackWhite;
        private GroupBox SizeBox;
        private RadioButton Size18x24;
        private RadioButton Size12x15;
        private RadioButton Size9x12;
        private RadioButton Size3x4;
    }
}