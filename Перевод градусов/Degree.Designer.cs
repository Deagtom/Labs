namespace Перевод_градусов
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
            this.TotalDegrees = new System.Windows.Forms.TextBox();
            this.FahrenheitDegrees = new System.Windows.Forms.TextBox();
            this.CelsiusDegrees = new System.Windows.Forms.TextBox();
            this.TotalDegreesLabel = new System.Windows.Forms.Label();
            this.FahrenheitDegreesLabel = new System.Windows.Forms.Label();
            this.CelsiusDegreesLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.TotalDegrees);
            this.Background.Controls.Add(this.FahrenheitDegrees);
            this.Background.Controls.Add(this.CelsiusDegrees);
            this.Background.Controls.Add(this.TotalDegreesLabel);
            this.Background.Controls.Add(this.FahrenheitDegreesLabel);
            this.Background.Controls.Add(this.CelsiusDegreesLabel);
            this.Background.Controls.Add(this.ExitButton);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1000, 600);
            this.Background.TabIndex = 0;
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Background_MouseDown);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
            // 
            // TotalDegrees
            // 
            this.TotalDegrees.Enabled = false;
            this.TotalDegrees.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalDegrees.Location = new System.Drawing.Point(440, 409);
            this.TotalDegrees.Name = "TotalDegrees";
            this.TotalDegrees.Size = new System.Drawing.Size(216, 35);
            this.TotalDegrees.TabIndex = 13;
            // 
            // FahrenheitDegrees
            // 
            this.FahrenheitDegrees.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FahrenheitDegrees.Location = new System.Drawing.Point(440, 191);
            this.FahrenheitDegrees.Name = "FahrenheitDegrees";
            this.FahrenheitDegrees.Size = new System.Drawing.Size(216, 35);
            this.FahrenheitDegrees.TabIndex = 12;
            this.FahrenheitDegrees.TextChanged += new System.EventHandler(this.FahrenheitDegrees_TextChanged);
            this.FahrenheitDegrees.Enter += new System.EventHandler(this.FahrenheitDegrees_Enter);
            // 
            // CelsiusDegrees
            // 
            this.CelsiusDegrees.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CelsiusDegrees.Location = new System.Drawing.Point(440, 132);
            this.CelsiusDegrees.Name = "CelsiusDegrees";
            this.CelsiusDegrees.Size = new System.Drawing.Size(216, 35);
            this.CelsiusDegrees.TabIndex = 11;
            this.CelsiusDegrees.TextChanged += new System.EventHandler(this.CelsiusDegrees_TextChanged);
            this.CelsiusDegrees.Enter += new System.EventHandler(this.CelsiusDegrees_Enter);
            // 
            // TotalDegreesLabel
            // 
            this.TotalDegreesLabel.AutoSize = true;
            this.TotalDegreesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalDegreesLabel.Location = new System.Drawing.Point(133, 406);
            this.TotalDegreesLabel.Name = "TotalDegreesLabel";
            this.TotalDegreesLabel.Size = new System.Drawing.Size(304, 37);
            this.TotalDegreesLabel.TabIndex = 10;
            this.TotalDegreesLabel.Text = "Цельсий в Фаренгейт";
            // 
            // FahrenheitDegreesLabel
            // 
            this.FahrenheitDegreesLabel.AutoSize = true;
            this.FahrenheitDegreesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FahrenheitDegreesLabel.Location = new System.Drawing.Point(133, 188);
            this.FahrenheitDegreesLabel.Name = "FahrenheitDegreesLabel";
            this.FahrenheitDegreesLabel.Size = new System.Drawing.Size(301, 37);
            this.FahrenheitDegreesLabel.TabIndex = 9;
            this.FahrenheitDegreesLabel.Text = "Градус Фаренгейта °F";
            // 
            // CelsiusDegreesLabel
            // 
            this.CelsiusDegreesLabel.AutoSize = true;
            this.CelsiusDegreesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CelsiusDegreesLabel.Location = new System.Drawing.Point(133, 129);
            this.CelsiusDegreesLabel.Name = "CelsiusDegreesLabel";
            this.CelsiusDegreesLabel.Size = new System.Drawing.Size(260, 37);
            this.CelsiusDegreesLabel.TabIndex = 8;
            this.CelsiusDegreesLabel.Text = "Градус Цельсия °C";
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(959, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 45);
            this.ExitButton.TabIndex = 7;
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
        private TextBox TotalDegrees;
        private TextBox FahrenheitDegrees;
        private TextBox CelsiusDegrees;
        private Label TotalDegreesLabel;
        private Label FahrenheitDegreesLabel;
        private Label CelsiusDegreesLabel;
    }
}