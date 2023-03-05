namespace Поиск_простых_чисел
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
            this.PrimeValuesListBox = new System.Windows.Forms.ListBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.CountValuesLabel = new System.Windows.Forms.Label();
            this.PrimeValueLabel = new System.Windows.Forms.Label();
            this.CountValues = new System.Windows.Forms.TextBox();
            this.PrimeValue = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.ClearButton);
            this.Background.Controls.Add(this.PrimeValuesListBox);
            this.Background.Controls.Add(this.FindButton);
            this.Background.Controls.Add(this.CountValuesLabel);
            this.Background.Controls.Add(this.PrimeValueLabel);
            this.Background.Controls.Add(this.CountValues);
            this.Background.Controls.Add(this.PrimeValue);
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
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(383, 453);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(161, 57);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PrimeValuesListBox
            // 
            this.PrimeValuesListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrimeValuesListBox.FormattingEnabled = true;
            this.PrimeValuesListBox.HorizontalScrollbar = true;
            this.PrimeValuesListBox.ItemHeight = 25;
            this.PrimeValuesListBox.Location = new System.Drawing.Point(615, 95);
            this.PrimeValuesListBox.Name = "PrimeValuesListBox";
            this.PrimeValuesListBox.Size = new System.Drawing.Size(253, 454);
            this.PrimeValuesListBox.TabIndex = 19;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindButton.Location = new System.Drawing.Point(119, 453);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(161, 57);
            this.FindButton.TabIndex = 18;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // CountValuesLabel
            // 
            this.CountValuesLabel.AutoSize = true;
            this.CountValuesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountValuesLabel.Location = new System.Drawing.Point(119, 255);
            this.CountValuesLabel.Name = "CountValuesLabel";
            this.CountValuesLabel.Size = new System.Drawing.Size(258, 37);
            this.CountValuesLabel.TabIndex = 17;
            this.CountValuesLabel.Text = "Количество чисел";
            // 
            // PrimeValueLabel
            // 
            this.PrimeValueLabel.AutoSize = true;
            this.PrimeValueLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrimeValueLabel.Location = new System.Drawing.Point(125, 129);
            this.PrimeValueLabel.Name = "PrimeValueLabel";
            this.PrimeValueLabel.Size = new System.Drawing.Size(100, 37);
            this.PrimeValueLabel.TabIndex = 16;
            this.PrimeValueLabel.Text = "Число";
            // 
            // CountValues
            // 
            this.CountValues.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountValues.Location = new System.Drawing.Point(125, 295);
            this.CountValues.Name = "CountValues";
            this.CountValues.Size = new System.Drawing.Size(252, 39);
            this.CountValues.TabIndex = 15;
            // 
            // PrimeValue
            // 
            this.PrimeValue.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrimeValue.Location = new System.Drawing.Point(125, 169);
            this.PrimeValue.Name = "PrimeValue";
            this.PrimeValue.Size = new System.Drawing.Size(252, 39);
            this.PrimeValue.TabIndex = 14;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(959, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 45);
            this.ExitButton.TabIndex = 9;
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
        private Label CountValuesLabel;
        private Label PrimeValueLabel;
        private TextBox CountValues;
        private TextBox PrimeValue;
        private Button FindButton;
        private ListBox PrimeValuesListBox;
        private Button ClearButton;
    }
}