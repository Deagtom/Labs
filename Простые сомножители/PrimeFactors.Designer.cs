namespace Простые_сомножители
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
            this.Factors = new System.Windows.Forms.TextBox();
            this.FactorsLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.Factors);
            this.Background.Controls.Add(this.FactorsLabel);
            this.Background.Controls.Add(this.CalculateButton);
            this.Background.Controls.Add(this.ValueLabel);
            this.Background.Controls.Add(this.Value);
            this.Background.Controls.Add(this.ExitButton);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1000, 600);
            this.Background.TabIndex = 0;
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Background_MouseDown);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
            // 
            // Factors
            // 
            this.Factors.Enabled = false;
            this.Factors.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Factors.Location = new System.Drawing.Point(346, 290);
            this.Factors.Name = "Factors";
            this.Factors.Size = new System.Drawing.Size(340, 39);
            this.Factors.TabIndex = 21;
            // 
            // FactorsLabel
            // 
            this.FactorsLabel.AutoSize = true;
            this.FactorsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FactorsLabel.Location = new System.Drawing.Point(127, 289);
            this.FactorsLabel.Name = "FactorsLabel";
            this.FactorsLabel.Size = new System.Drawing.Size(213, 37);
            this.FactorsLabel.TabIndex = 20;
            this.FactorsLabel.Text = "Сомножители:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(127, 470);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(161, 57);
            this.CalculateButton.TabIndex = 19;
            this.CalculateButton.Text = "Разбить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValueLabel.Location = new System.Drawing.Point(127, 185);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(100, 37);
            this.ValueLabel.TabIndex = 18;
            this.ValueLabel.Text = "Число";
            // 
            // Value
            // 
            this.Value.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Value.Location = new System.Drawing.Point(233, 186);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(252, 39);
            this.Value.TabIndex = 17;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(959, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 45);
            this.ExitButton.TabIndex = 10;
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
        private Label ValueLabel;
        private TextBox Value;
        private Button CalculateButton;
        private TextBox Factors;
        private Label FactorsLabel;
    }
}