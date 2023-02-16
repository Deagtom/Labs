namespace Любимые_напитки
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LovedLabel = new System.Windows.Forms.Label();
            this.UnlovedLabel = new System.Windows.Forms.Label();
            this.LovedDrinkables = new System.Windows.Forms.ListBox();
            this.Drinkables = new System.Windows.Forms.ListBox();
            this.UnlovedDrinkables = new System.Windows.Forms.ListBox();
            this.Background = new System.Windows.Forms.Panel();
            this.OutUnlovedButton = new System.Windows.Forms.Button();
            this.InUnlovedButton = new System.Windows.Forms.Button();
            this.OutLovedButton = new System.Windows.Forms.Button();
            this.InLovedButton = new System.Windows.Forms.Button();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(46, 509);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 52);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(796, 509);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(160, 52);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LovedLabel
            // 
            this.LovedLabel.AutoSize = true;
            this.LovedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LovedLabel.Location = new System.Drawing.Point(94, 54);
            this.LovedLabel.Name = "LovedLabel";
            this.LovedLabel.Size = new System.Drawing.Size(101, 25);
            this.LovedLabel.TabIndex = 2;
            this.LovedLabel.Text = "Любимые";
            // 
            // UnlovedLabel
            // 
            this.UnlovedLabel.AutoSize = true;
            this.UnlovedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UnlovedLabel.Location = new System.Drawing.Point(780, 54);
            this.UnlovedLabel.Name = "UnlovedLabel";
            this.UnlovedLabel.Size = new System.Drawing.Size(123, 25);
            this.UnlovedLabel.TabIndex = 3;
            this.UnlovedLabel.Text = "Нелюбимые";
            // 
            // LovedDrinkables
            // 
            this.LovedDrinkables.AllowDrop = true;
            this.LovedDrinkables.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LovedDrinkables.FormattingEnabled = true;
            this.LovedDrinkables.ItemHeight = 21;
            this.LovedDrinkables.Location = new System.Drawing.Point(46, 93);
            this.LovedDrinkables.Name = "LovedDrinkables";
            this.LovedDrinkables.Size = new System.Drawing.Size(225, 340);
            this.LovedDrinkables.TabIndex = 4;
            this.LovedDrinkables.DragDrop += new System.Windows.Forms.DragEventHandler(this.LovedDrinkables_DragDrop);
            this.LovedDrinkables.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drinkables_DragEnter);
            this.LovedDrinkables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drinkables_MouseDown);
            // 
            // Drinkables
            // 
            this.Drinkables.AllowDrop = true;
            this.Drinkables.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Drinkables.FormattingEnabled = true;
            this.Drinkables.ItemHeight = 21;
            this.Drinkables.Location = new System.Drawing.Point(390, 72);
            this.Drinkables.Name = "Drinkables";
            this.Drinkables.Size = new System.Drawing.Size(225, 361);
            this.Drinkables.TabIndex = 5;
            this.Drinkables.DragDrop += new System.Windows.Forms.DragEventHandler(this.Drinkables_DragDrop);
            this.Drinkables.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drinkables_DragEnter);
            this.Drinkables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drinkables_MouseDown);
            // 
            // UnlovedDrinkables
            // 
            this.UnlovedDrinkables.AllowDrop = true;
            this.UnlovedDrinkables.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UnlovedDrinkables.FormattingEnabled = true;
            this.UnlovedDrinkables.ItemHeight = 21;
            this.UnlovedDrinkables.Location = new System.Drawing.Point(731, 93);
            this.UnlovedDrinkables.Name = "UnlovedDrinkables";
            this.UnlovedDrinkables.Size = new System.Drawing.Size(225, 340);
            this.UnlovedDrinkables.TabIndex = 6;
            this.UnlovedDrinkables.DragDrop += new System.Windows.Forms.DragEventHandler(this.UnlovedDrinkables_DragDrop);
            this.UnlovedDrinkables.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drinkables_DragEnter);
            this.UnlovedDrinkables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drinkables_MouseDown);
            // 
            // Background
            // 
            this.Background.Controls.Add(this.LovedLabel);
            this.Background.Controls.Add(this.UnlovedLabel);
            this.Background.Controls.Add(this.UnlovedDrinkables);
            this.Background.Controls.Add(this.OutUnlovedButton);
            this.Background.Controls.Add(this.LovedDrinkables);
            this.Background.Controls.Add(this.InUnlovedButton);
            this.Background.Controls.Add(this.OutLovedButton);
            this.Background.Controls.Add(this.Drinkables);
            this.Background.Controls.Add(this.InLovedButton);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1000, 600);
            this.Background.TabIndex = 7;
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Background_MouseDown);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
            // 
            // OutUnlovedButton
            // 
            this.OutUnlovedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutUnlovedButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutUnlovedButton.Location = new System.Drawing.Point(638, 264);
            this.OutUnlovedButton.Name = "OutUnlovedButton";
            this.OutUnlovedButton.Size = new System.Drawing.Size(64, 64);
            this.OutUnlovedButton.TabIndex = 7;
            this.OutUnlovedButton.Text = "<";
            this.OutUnlovedButton.UseVisualStyleBackColor = true;
            this.OutUnlovedButton.Click += new System.EventHandler(this.OutUnlovedButton_Click);
            // 
            // InUnlovedButton
            // 
            this.InUnlovedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InUnlovedButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InUnlovedButton.Location = new System.Drawing.Point(638, 148);
            this.InUnlovedButton.Name = "InUnlovedButton";
            this.InUnlovedButton.Size = new System.Drawing.Size(64, 64);
            this.InUnlovedButton.TabIndex = 6;
            this.InUnlovedButton.Text = ">";
            this.InUnlovedButton.UseVisualStyleBackColor = true;
            this.InUnlovedButton.Click += new System.EventHandler(this.InUnlovedButton_Click);
            // 
            // OutLovedButton
            // 
            this.OutLovedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutLovedButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutLovedButton.Location = new System.Drawing.Point(300, 264);
            this.OutLovedButton.Name = "OutLovedButton";
            this.OutLovedButton.Size = new System.Drawing.Size(64, 64);
            this.OutLovedButton.TabIndex = 1;
            this.OutLovedButton.Text = ">";
            this.OutLovedButton.UseVisualStyleBackColor = true;
            this.OutLovedButton.Click += new System.EventHandler(this.OutLovedButton_Click);
            // 
            // InLovedButton
            // 
            this.InLovedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InLovedButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InLovedButton.Location = new System.Drawing.Point(300, 148);
            this.InLovedButton.Name = "InLovedButton";
            this.InLovedButton.Size = new System.Drawing.Size(64, 64);
            this.InLovedButton.TabIndex = 0;
            this.InLovedButton.Text = "<";
            this.InLovedButton.UseVisualStyleBackColor = true;
            this.InLovedButton.Click += new System.EventHandler(this.InLovedButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button SaveButton;
        private Button ExitButton;
        private Label LovedLabel;
        private Label UnlovedLabel;
        private ListBox LovedDrinkables;
        private ListBox Drinkables;
        private ListBox UnlovedDrinkables;
        private Panel Background;
        private Button OutUnlovedButton;
        private Button InUnlovedButton;
        private Button OutLovedButton;
        private Button InLovedButton;
    }
}