namespace _13.SimleForm
{
    partial class TabelsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvTabels = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTabels).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(432, 27);
            label1.Name = "label1";
            label1.Size = new Size(305, 41);
            label1.TabIndex = 4;
            label1.Text = "Таблиці бази даних";
            // 
            // dgvTabels
            // 
            dgvTabels.AllowUserToAddRows = false;
            dgvTabels.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvTabels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTabels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabels.Columns.AddRange(new DataGridViewColumn[] { ColName });
            dgvTabels.Location = new Point(12, 94);
            dgvTabels.Name = "dgvTabels";
            dgvTabels.ReadOnly = true;
            dgvTabels.RowHeadersWidth = 51;
            dgvTabels.RowTemplate.Height = 29;
            dgvTabels.Size = new Size(1145, 464);
            dgvTabels.TabIndex = 5;
            // 
            // ColName
            // 
            ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColName.HeaderText = "Назва";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // TabelsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 639);
            Controls.Add(dgvTabels);
            Controls.Add(label1);
            Name = "TabelsForm";
            Text = "Керування таблицями";
            Load += TabelsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTabels;
        private DataGridViewTextBoxColumn ColName;
    }
}