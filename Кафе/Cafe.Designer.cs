namespace Кафе
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
            this.FoodPotato = new System.Windows.Forms.CheckBox();
            this.FoodBacon = new System.Windows.Forms.CheckBox();
            this.FoodSause = new System.Windows.Forms.CheckBox();
            this.FoodBigMac = new System.Windows.Forms.CheckBox();
            this.ExitButton = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.ClearButton);
            this.Background.Controls.Add(this.CalculateButton);
            this.Background.Controls.Add(this.Price);
            this.Background.Controls.Add(this.PriceLabel);
            this.Background.Controls.Add(this.FoodPotato);
            this.Background.Controls.Add(this.FoodBacon);
            this.Background.Controls.Add(this.FoodSause);
            this.Background.Controls.Add(this.FoodBigMac);
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
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(682, 475);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(196, 55);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(146, 475);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(196, 55);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(403, 90);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(206, 39);
            this.Price.TabIndex = 6;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(146, 89);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(251, 37);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Стоимость заказа";
            // 
            // FoodPotato
            // 
            this.FoodPotato.AutoSize = true;
            this.FoodPotato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodPotato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodPotato.Location = new System.Drawing.Point(146, 330);
            this.FoodPotato.Name = "FoodPotato";
            this.FoodPotato.Size = new System.Drawing.Size(146, 33);
            this.FoodPotato.TabIndex = 4;
            this.FoodPotato.Text = "Картошка";
            this.FoodPotato.UseVisualStyleBackColor = true;
            // 
            // FoodBacon
            // 
            this.FoodBacon.AutoSize = true;
            this.FoodBacon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodBacon.Location = new System.Drawing.Point(146, 283);
            this.FoodBacon.Name = "FoodBacon";
            this.FoodBacon.Size = new System.Drawing.Size(102, 33);
            this.FoodBacon.TabIndex = 3;
            this.FoodBacon.Text = "Бекон";
            this.FoodBacon.UseVisualStyleBackColor = true;
            // 
            // FoodSause
            // 
            this.FoodSause.AutoSize = true;
            this.FoodSause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodSause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodSause.Location = new System.Drawing.Point(146, 236);
            this.FoodSause.Name = "FoodSause";
            this.FoodSause.Size = new System.Drawing.Size(86, 33);
            this.FoodSause.TabIndex = 2;
            this.FoodSause.Text = "Соус";
            this.FoodSause.UseVisualStyleBackColor = true;
            // 
            // FoodBigMac
            // 
            this.FoodBigMac.AutoSize = true;
            this.FoodBigMac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodBigMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodBigMac.Location = new System.Drawing.Point(146, 189);
            this.FoodBigMac.Name = "FoodBigMac";
            this.FoodBigMac.Size = new System.Drawing.Size(236, 33);
            this.FoodBigMac.TabIndex = 1;
            this.FoodBigMac.Text = "Биг-Пошёл-Нахуй";
            this.FoodBigMac.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Background;
        private Label ExitButton;
        private Button ClearButton;
        private Button CalculateButton;
        private TextBox Price;
        private Label PriceLabel;
        private CheckBox FoodPotato;
        private CheckBox FoodBacon;
        private CheckBox FoodSause;
        private CheckBox FoodBigMac;
    }
}