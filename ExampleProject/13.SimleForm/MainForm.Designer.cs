namespace _13.SimleForm
{
    partial class MainForm
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
            btnSearch = new Button();
            txtName = new TextBox();
            menuHead = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileExit = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            optionsConnectionDB = new ToolStripMenuItem();
            menuHead.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(639, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Нажми мене";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(19, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // menuHead
            // 
            menuHead.ImageScalingSize = new Size(20, 20);
            menuHead.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem });
            menuHead.Location = new Point(0, 0);
            menuHead.Name = "menuHead";
            menuHead.Size = new Size(800, 28);
            menuHead.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // fileExit
            // 
            fileExit.Name = "fileExit";
            fileExit.ShortcutKeys = Keys.Control | Keys.X;
            fileExit.Size = new Size(180, 26);
            fileExit.Text = "Вихід";
            fileExit.Click += fileExit_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsConnectionDB });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(125, 24);
            optionsToolStripMenuItem.Text = "Налаштування";
            // 
            // optionsConnectionDB
            // 
            optionsConnectionDB.Name = "optionsConnectionDB";
            optionsConnectionDB.Size = new Size(228, 26);
            optionsConnectionDB.Text = "Підключення до БД";
            optionsConnectionDB.Click += optionsConnectionDB_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(btnSearch);
            Controls.Add(menuHead);
            MainMenuStrip = menuHead;
            Name = "MainForm";
            Text = "Магазин";
            menuHead.ResumeLayout(false);
            menuHead.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtName;
        private MenuStrip menuHead;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileExit;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem optionsConnectionDB;
    }
}
