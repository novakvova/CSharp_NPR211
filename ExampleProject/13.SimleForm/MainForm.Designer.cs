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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuHead = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileExit = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            optionsConnectionDB = new ToolStripMenuItem();
            label1 = new Label();
            dgvDatabases = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            btnDeleteDatabase = new Button();
            txtDbName = new TextBox();
            label2 = new Label();
            btnCreateDatabase = new Button();
            menuHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatabases).BeginInit();
            SuspendLayout();
            // 
            // menuHead
            // 
            menuHead.ImageScalingSize = new Size(20, 20);
            menuHead.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem });
            menuHead.Location = new Point(0, 0);
            menuHead.Name = "menuHead";
            menuHead.Size = new Size(1066, 28);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(340, 49);
            label1.Name = "label1";
            label1.Size = new Size(386, 41);
            label1.TabIndex = 3;
            label1.Text = "Керування Базами даних";
            // 
            // dgvDatabases
            // 
            dgvDatabases.AllowUserToAddRows = false;
            dgvDatabases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDatabases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatabases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatabases.Columns.AddRange(new DataGridViewColumn[] { ColName });
            dgvDatabases.Location = new Point(12, 110);
            dgvDatabases.Name = "dgvDatabases";
            dgvDatabases.ReadOnly = true;
            dgvDatabases.RowHeadersWidth = 51;
            dgvDatabases.RowTemplate.Height = 29;
            dgvDatabases.Size = new Size(1042, 417);
            dgvDatabases.TabIndex = 4;
            dgvDatabases.CellDoubleClick += dgvDatabases_CellDoubleClick;
            // 
            // ColName
            // 
            ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColName.HeaderText = "Назва";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // btnDeleteDatabase
            // 
            btnDeleteDatabase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteDatabase.ForeColor = Color.Red;
            btnDeleteDatabase.Location = new Point(912, 560);
            btnDeleteDatabase.Name = "btnDeleteDatabase";
            btnDeleteDatabase.Size = new Size(142, 50);
            btnDeleteDatabase.TabIndex = 5;
            btnDeleteDatabase.Text = "Видалить";
            btnDeleteDatabase.UseVisualStyleBackColor = true;
            btnDeleteDatabase.Click += btnDeleteDatabase_Click;
            // 
            // txtDbName
            // 
            txtDbName.Location = new Point(26, 583);
            txtDbName.Name = "txtDbName";
            txtDbName.Size = new Size(225, 27);
            txtDbName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(26, 543);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 7;
            label2.Text = "Назва Бази даних";
            // 
            // btnCreateDatabase
            // 
            btnCreateDatabase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateDatabase.ForeColor = Color.Blue;
            btnCreateDatabase.Location = new Point(285, 560);
            btnCreateDatabase.Name = "btnCreateDatabase";
            btnCreateDatabase.Size = new Size(142, 50);
            btnCreateDatabase.TabIndex = 8;
            btnCreateDatabase.Text = "Створить";
            btnCreateDatabase.UseVisualStyleBackColor = true;
            btnCreateDatabase.Click += btnCreateDatabase_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 630);
            Controls.Add(btnCreateDatabase);
            Controls.Add(label2);
            Controls.Add(txtDbName);
            Controls.Add(btnDeleteDatabase);
            Controls.Add(dgvDatabases);
            Controls.Add(label1);
            Controls.Add(menuHead);
            MainMenuStrip = menuHead;
            Name = "MainForm";
            Text = "Магазин";
            Load += MainForm_Load;
            menuHead.ResumeLayout(false);
            menuHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatabases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuHead;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileExit;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem optionsConnectionDB;
        private Label label1;
        private DataGridView dgvDatabases;
        private DataGridViewTextBoxColumn ColName;
        private Button btnDeleteDatabase;
        private TextBox txtDbName;
        private Label label2;
        private Button btnCreateDatabase;
    }
}
