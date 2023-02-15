namespace Комплектация_автомибиля
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
            this.ModelPicture = new System.Windows.Forms.PictureBox();
            this.OptionLeatherInterior = new System.Windows.Forms.CheckBox();
            this.OptionPartronik = new System.Windows.Forms.CheckBox();
            this.OptionFogLights = new System.Windows.Forms.CheckBox();
            this.OptionABC = new System.Windows.Forms.CheckBox();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.BasePrice = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.ComboBox();
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.ClearButton);
            this.Background.Controls.Add(this.CalculateButton);
            this.Background.Controls.Add(this.Price);
            this.Background.Controls.Add(this.PriceLabel);
            this.Background.Controls.Add(this.ModelPicture);
            this.Background.Controls.Add(this.OptionLeatherInterior);
            this.Background.Controls.Add(this.OptionPartronik);
            this.Background.Controls.Add(this.OptionFogLights);
            this.Background.Controls.Add(this.OptionABC);
            this.Background.Controls.Add(this.OptionsLabel);
            this.Background.Controls.Add(this.BasePrice);
            this.Background.Controls.Add(this.Model);
            this.Background.Controls.Add(this.BasePriceLabel);
            this.Background.Controls.Add(this.ModelLabel);
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
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(637, 504);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(177, 46);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(118, 504);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(177, 46);
            this.CalculateButton.TabIndex = 15;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(637, 417);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(242, 43);
            this.Price.TabIndex = 14;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(466, 426);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(165, 30);
            this.PriceLabel.TabIndex = 13;
            this.PriceLabel.Text = "Итоговая цена";
            // 
            // ModelPicture
            // 
            this.ModelPicture.Location = new System.Drawing.Point(466, 75);
            this.ModelPicture.Name = "ModelPicture";
            this.ModelPicture.Size = new System.Drawing.Size(460, 280);
            this.ModelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModelPicture.TabIndex = 12;
            this.ModelPicture.TabStop = false;
            // 
            // OptionLeatherInterior
            // 
            this.OptionLeatherInterior.AutoSize = true;
            this.OptionLeatherInterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionLeatherInterior.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptionLeatherInterior.Location = new System.Drawing.Point(71, 426);
            this.OptionLeatherInterior.Name = "OptionLeatherInterior";
            this.OptionLeatherInterior.Size = new System.Drawing.Size(149, 25);
            this.OptionLeatherInterior.TabIndex = 11;
            this.OptionLeatherInterior.Text = "Кожаный салон";
            this.OptionLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // OptionPartronik
            // 
            this.OptionPartronik.AutoSize = true;
            this.OptionPartronik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionPartronik.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptionPartronik.Location = new System.Drawing.Point(71, 395);
            this.OptionPartronik.Name = "OptionPartronik";
            this.OptionPartronik.Size = new System.Drawing.Size(113, 25);
            this.OptionPartronik.TabIndex = 10;
            this.OptionPartronik.Text = "Партроник";
            this.OptionPartronik.UseVisualStyleBackColor = true;
            // 
            // OptionFogLights
            // 
            this.OptionFogLights.AutoSize = true;
            this.OptionFogLights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionFogLights.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptionFogLights.Location = new System.Drawing.Point(71, 364);
            this.OptionFogLights.Name = "OptionFogLights";
            this.OptionFogLights.Size = new System.Drawing.Size(159, 25);
            this.OptionFogLights.TabIndex = 9;
            this.OptionFogLights.Text = "Противотуманки";
            this.OptionFogLights.UseVisualStyleBackColor = true;
            // 
            // OptionABC
            // 
            this.OptionABC.AutoSize = true;
            this.OptionABC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionABC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptionABC.Location = new System.Drawing.Point(71, 333);
            this.OptionABC.Name = "OptionABC";
            this.OptionABC.Size = new System.Drawing.Size(60, 25);
            this.OptionABC.TabIndex = 8;
            this.OptionABC.Text = "АБС";
            this.OptionABC.UseVisualStyleBackColor = true;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptionsLabel.Location = new System.Drawing.Point(71, 285);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(241, 25);
            this.OptionsLabel.TabIndex = 7;
            this.OptionsLabel.Text = "Дополнительные опции";
            // 
            // BasePrice
            // 
            this.BasePrice.AutoSize = true;
            this.BasePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BasePrice.Location = new System.Drawing.Point(118, 191);
            this.BasePrice.Name = "BasePrice";
            this.BasePrice.Size = new System.Drawing.Size(95, 37);
            this.BasePrice.TabIndex = 6;
            this.BasePrice.Text = "10 000";
            // 
            // Model
            // 
            this.Model.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Model.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Model.FormattingEnabled = true;
            this.Model.Items.AddRange(new object[] {
            "Kia Rio",
            "BMW M5",
            "Mercedes-AMG GT"});
            this.Model.Location = new System.Drawing.Point(62, 103);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(250, 45);
            this.Model.TabIndex = 5;
            this.Model.SelectedIndexChanged += new System.EventHandler(this.Model_SelectedIndexChanged);
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BasePriceLabel.Location = new System.Drawing.Point(118, 166);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(136, 25);
            this.BasePriceLabel.TabIndex = 4;
            this.BasePriceLabel.Text = "Базовая цена";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ModelLabel.Location = new System.Drawing.Point(137, 75);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(86, 25);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Модель";
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(959, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 45);
            this.ExitButton.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.ModelPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Background;
        private Label ExitButton;
        private PictureBox ModelPicture;
        private CheckBox OptionLeatherInterior;
        private CheckBox OptionPartronik;
        private CheckBox OptionFogLights;
        private CheckBox OptionABC;
        private Label OptionsLabel;
        private Label BasePrice;
        private ComboBox Model;
        private Label BasePriceLabel;
        private Label ModelLabel;
        private TextBox Price;
        private Label PriceLabel;
        private Button CalculateButton;
        private Button ClearButton;
    }
}