namespace Номера_машины
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NumbersListLabel = new System.Windows.Forms.Label();
            this.NumbersListBox = new System.Windows.Forms.ListBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.CarNumbersTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.CarNumbersLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.DeleteButton);
            this.Background.Controls.Add(this.NumbersListLabel);
            this.Background.Controls.Add(this.NumbersListBox);
            this.Background.Controls.Add(this.InfoGroupBox);
            this.Background.Controls.Add(this.ExitButton);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1000, 600);
            this.Background.TabIndex = 0;
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Background_MouseDown);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(40, 498);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(223, 43);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NumbersListLabel
            // 
            this.NumbersListLabel.AutoSize = true;
            this.NumbersListLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumbersListLabel.Location = new System.Drawing.Point(31, 84);
            this.NumbersListLabel.Name = "NumbersListLabel";
            this.NumbersListLabel.Size = new System.Drawing.Size(184, 30);
            this.NumbersListLabel.TabIndex = 4;
            this.NumbersListLabel.Text = "Список номеров";
            // 
            // NumbersListBox
            // 
            this.NumbersListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumbersListBox.FormattingEnabled = true;
            this.NumbersListBox.ItemHeight = 25;
            this.NumbersListBox.Location = new System.Drawing.Point(31, 119);
            this.NumbersListBox.Name = "NumbersListBox";
            this.NumbersListBox.Size = new System.Drawing.Size(242, 354);
            this.NumbersListBox.TabIndex = 3;
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.ColorComboBox);
            this.InfoGroupBox.Controls.Add(this.ResetButton);
            this.InfoGroupBox.Controls.Add(this.SaveButton);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.ModelTextBox);
            this.InfoGroupBox.Controls.Add(this.CarNumbersTextBox);
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Controls.Add(this.ColorLabel);
            this.InfoGroupBox.Controls.Add(this.ModelLabel);
            this.InfoGroupBox.Controls.Add(this.CarNumbersLabel);
            this.InfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoGroupBox.Location = new System.Drawing.Point(459, 84);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(488, 457);
            this.InfoGroupBox.TabIndex = 2;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Данные";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Белый",
            "Чёрный",
            "Красный",
            "Жёлтый",
            "Зелёный",
            "Синий",
            "Серый"});
            this.ColorComboBox.Location = new System.Drawing.Point(197, 223);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(285, 38);
            this.ColorComboBox.TabIndex = 10;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(259, 396);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(223, 43);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Сбросить";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(6, 396);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(223, 43);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(197, 298);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(285, 35);
            this.NameTextBox.TabIndex = 7;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(197, 144);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(285, 35);
            this.ModelTextBox.TabIndex = 5;
            // 
            // CarNumbersTextBox
            // 
            this.CarNumbersTextBox.Location = new System.Drawing.Point(197, 65);
            this.CarNumbersTextBox.Name = "CarNumbersTextBox";
            this.CarNumbersTextBox.Size = new System.Drawing.Size(285, 35);
            this.CarNumbersTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(20, 298);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(157, 25);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "ФИО владельца";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColorLabel.Location = new System.Drawing.Point(20, 223);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(56, 25);
            this.ColorLabel.TabIndex = 2;
            this.ColorLabel.Text = "Цвет";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ModelLabel.Location = new System.Drawing.Point(20, 144);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(83, 25);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Модель";
            // 
            // CarNumbersLabel
            // 
            this.CarNumbersLabel.AutoSize = true;
            this.CarNumbersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarNumbersLabel.Location = new System.Drawing.Point(20, 65);
            this.CarNumbersLabel.Name = "CarNumbersLabel";
            this.CarNumbersLabel.Size = new System.Drawing.Size(96, 25);
            this.CarNumbersLabel.TabIndex = 0;
            this.CarNumbersLabel.Text = "Госномер";
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
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Background;
        private Label ExitButton;
        private GroupBox InfoGroupBox;
        private Label NameLabel;
        private Label ColorLabel;
        private Label ModelLabel;
        private Label CarNumbersLabel;
        private Button ResetButton;
        private Button SaveButton;
        private TextBox NameTextBox;
        private TextBox ModelTextBox;
        private TextBox CarNumbersTextBox;
        private ComboBox ColorComboBox;
        private Button DeleteButton;
        private Label NumbersListLabel;
        private ListBox NumbersListBox;
    }
}