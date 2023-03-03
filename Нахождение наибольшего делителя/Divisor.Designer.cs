namespace Нахождение_наибольшего_делителя
{
    partial class Divisor
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Label();
            this.DivisorValue = new System.Windows.Forms.TextBox();
            this.SecondValue = new System.Windows.Forms.TextBox();
            this.FirstValue = new System.Windows.Forms.TextBox();
            this.DivisorValueLabel = new System.Windows.Forms.Label();
            this.SecondValueLabel = new System.Windows.Forms.Label();
            this.FirstValueLabel = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.CalculateButton);
            this.Background.Controls.Add(this.ExitButton);
            this.Background.Controls.Add(this.DivisorValue);
            this.Background.Controls.Add(this.SecondValue);
            this.Background.Controls.Add(this.FirstValue);
            this.Background.Controls.Add(this.DivisorValueLabel);
            this.Background.Controls.Add(this.SecondValueLabel);
            this.Background.Controls.Add(this.FirstValueLabel);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1000, 600);
            this.Background.TabIndex = 0;
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Background_MouseDown);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(309, 252);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(200, 65);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Расчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(959, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 45);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // DivisorValue
            // 
            this.DivisorValue.Enabled = false;
            this.DivisorValue.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DivisorValue.Location = new System.Drawing.Point(435, 446);
            this.DivisorValue.Name = "DivisorValue";
            this.DivisorValue.Size = new System.Drawing.Size(216, 35);
            this.DivisorValue.TabIndex = 5;
            // 
            // SecondValue
            // 
            this.SecondValue.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecondValue.Location = new System.Drawing.Point(398, 178);
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(216, 35);
            this.SecondValue.TabIndex = 4;
            // 
            // FirstValue
            // 
            this.FirstValue.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstValue.Location = new System.Drawing.Point(398, 73);
            this.FirstValue.Name = "FirstValue";
            this.FirstValue.Size = new System.Drawing.Size(216, 35);
            this.FirstValue.TabIndex = 3;
            // 
            // DivisorValueLabel
            // 
            this.DivisorValueLabel.AutoSize = true;
            this.DivisorValueLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DivisorValueLabel.Location = new System.Drawing.Point(181, 443);
            this.DivisorValueLabel.Name = "DivisorValueLabel";
            this.DivisorValueLabel.Size = new System.Drawing.Size(248, 37);
            this.DivisorValueLabel.TabIndex = 2;
            this.DivisorValueLabel.Text = "Общий делитель:";
            // 
            // SecondValueLabel
            // 
            this.SecondValueLabel.AutoSize = true;
            this.SecondValueLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecondValueLabel.Location = new System.Drawing.Point(181, 175);
            this.SecondValueLabel.Name = "SecondValueLabel";
            this.SecondValueLabel.Size = new System.Drawing.Size(205, 37);
            this.SecondValueLabel.TabIndex = 1;
            this.SecondValueLabel.Text = "Второе число:";
            // 
            // FirstValueLabel
            // 
            this.FirstValueLabel.AutoSize = true;
            this.FirstValueLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstValueLabel.Location = new System.Drawing.Point(181, 70);
            this.FirstValueLabel.Name = "FirstValueLabel";
            this.FirstValueLabel.Size = new System.Drawing.Size(211, 37);
            this.FirstValueLabel.TabIndex = 0;
            this.FirstValueLabel.Text = "Первое число:";
            // 
            // Divisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Divisor";
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Background;
        private Label SecondValueLabel;
        private Label FirstValueLabel;
        private TextBox DivisorValue;
        private TextBox SecondValue;
        private TextBox FirstValue;
        private Label DivisorValueLabel;
        private Label ExitButton;
        private Button CalculateButton;
    }
}