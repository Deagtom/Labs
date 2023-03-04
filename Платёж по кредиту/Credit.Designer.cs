namespace Платёж_по_кредиту
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
            this.Interest = new System.Windows.Forms.Label();
            this.MontlyPaymentCreditLabel = new System.Windows.Forms.Label();
            this.MontlyPaymentCredit = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TermCreditLabel = new System.Windows.Forms.Label();
            this.InterestCreditLabel = new System.Windows.Forms.Label();
            this.AmountCreditLabel = new System.Windows.Forms.Label();
            this.TermCredit = new System.Windows.Forms.TextBox();
            this.InterestCredit = new System.Windows.Forms.TextBox();
            this.AmountCredit = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Label();
            this.TermCountLabel = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.TermCountLabel);
            this.Background.Controls.Add(this.Interest);
            this.Background.Controls.Add(this.MontlyPaymentCreditLabel);
            this.Background.Controls.Add(this.MontlyPaymentCredit);
            this.Background.Controls.Add(this.CalculateButton);
            this.Background.Controls.Add(this.TermCreditLabel);
            this.Background.Controls.Add(this.InterestCreditLabel);
            this.Background.Controls.Add(this.AmountCreditLabel);
            this.Background.Controls.Add(this.TermCredit);
            this.Background.Controls.Add(this.InterestCredit);
            this.Background.Controls.Add(this.AmountCredit);
            this.Background.Controls.Add(this.ExitButton);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1000, 600);
            this.Background.TabIndex = 0;
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Background_MouseDown);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
            // 
            // Interest
            // 
            this.Interest.AutoSize = true;
            this.Interest.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Interest.Location = new System.Drawing.Point(642, 277);
            this.Interest.Name = "Interest";
            this.Interest.Size = new System.Drawing.Size(40, 37);
            this.Interest.TabIndex = 18;
            this.Interest.Text = "%";
            // 
            // MontlyPaymentCreditLabel
            // 
            this.MontlyPaymentCreditLabel.AutoSize = true;
            this.MontlyPaymentCreditLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MontlyPaymentCreditLabel.Location = new System.Drawing.Point(122, 466);
            this.MontlyPaymentCreditLabel.Name = "MontlyPaymentCreditLabel";
            this.MontlyPaymentCreditLabel.Size = new System.Drawing.Size(310, 37);
            this.MontlyPaymentCreditLabel.TabIndex = 17;
            this.MontlyPaymentCreditLabel.Text = "Ежемесячный платёж";
            // 
            // MontlyPaymentCredit
            // 
            this.MontlyPaymentCredit.Enabled = false;
            this.MontlyPaymentCredit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MontlyPaymentCredit.Location = new System.Drawing.Point(438, 467);
            this.MontlyPaymentCredit.Name = "MontlyPaymentCredit";
            this.MontlyPaymentCredit.Size = new System.Drawing.Size(252, 39);
            this.MontlyPaymentCredit.TabIndex = 16;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(763, 457);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(161, 57);
            this.CalculateButton.TabIndex = 15;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // TermCreditLabel
            // 
            this.TermCreditLabel.AutoSize = true;
            this.TermCreditLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TermCreditLabel.Location = new System.Drawing.Point(763, 222);
            this.TermCreditLabel.Name = "TermCreditLabel";
            this.TermCreditLabel.Size = new System.Drawing.Size(198, 37);
            this.TermCreditLabel.TabIndex = 14;
            this.TermCreditLabel.Text = "Срок кредита";
            // 
            // InterestCreditLabel
            // 
            this.InterestCreditLabel.AutoSize = true;
            this.InterestCreditLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InterestCreditLabel.Location = new System.Drawing.Point(442, 222);
            this.InterestCreditLabel.Name = "InterestCreditLabel";
            this.InterestCreditLabel.Size = new System.Drawing.Size(274, 37);
            this.InterestCreditLabel.TabIndex = 13;
            this.InterestCreditLabel.Text = "Процентная ставка";
            // 
            // AmountCreditLabel
            // 
            this.AmountCreditLabel.AutoSize = true;
            this.AmountCreditLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountCreditLabel.Location = new System.Drawing.Point(122, 222);
            this.AmountCreditLabel.Name = "AmountCreditLabel";
            this.AmountCreditLabel.Size = new System.Drawing.Size(221, 37);
            this.AmountCreditLabel.TabIndex = 12;
            this.AmountCreditLabel.Text = "Сумма кредита";
            // 
            // TermCredit
            // 
            this.TermCredit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TermCredit.Location = new System.Drawing.Point(817, 275);
            this.TermCredit.Name = "TermCredit";
            this.TermCredit.Size = new System.Drawing.Size(71, 39);
            this.TermCredit.TabIndex = 11;
            // 
            // InterestCredit
            // 
            this.InterestCredit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InterestCredit.Location = new System.Drawing.Point(519, 275);
            this.InterestCredit.Name = "InterestCredit";
            this.InterestCredit.Size = new System.Drawing.Size(117, 39);
            this.InterestCredit.TabIndex = 10;
            // 
            // AmountCredit
            // 
            this.AmountCredit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountCredit.Location = new System.Drawing.Point(122, 275);
            this.AmountCredit.Name = "AmountCredit";
            this.AmountCredit.Size = new System.Drawing.Size(252, 39);
            this.AmountCredit.TabIndex = 9;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(959, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 45);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // TermCountLabel
            // 
            this.TermCountLabel.AutoSize = true;
            this.TermCountLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TermCountLabel.Location = new System.Drawing.Point(894, 277);
            this.TermCountLabel.Name = "TermCountLabel";
            this.TermCountLabel.Size = new System.Drawing.Size(38, 37);
            this.TermCountLabel.TabIndex = 19;
            this.TermCountLabel.Text = "м";
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
        private Label TermCreditLabel;
        private Label InterestCreditLabel;
        private Label AmountCreditLabel;
        private TextBox TermCredit;
        private TextBox InterestCredit;
        private TextBox AmountCredit;
        private Button CalculateButton;
        private Label MontlyPaymentCreditLabel;
        private TextBox MontlyPaymentCredit;
        private Label Interest;
        private Label TermCountLabel;
    }
}