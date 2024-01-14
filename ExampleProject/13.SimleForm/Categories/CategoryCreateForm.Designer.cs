namespace _13.SimleForm.Categories
{
    partial class CategoryCreateForm
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDescription = new TextBox();
            pbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(238, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 41);
            label1.TabIndex = 4;
            label1.Text = "Створення категорії";
            // 
            // txtName
            // 
            txtName.Location = new Point(54, 119);
            txtName.Name = "txtName";
            txtName.Size = new Size(285, 34);
            txtName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(54, 92);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 5;
            label2.Text = "Назва";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(54, 161);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 5;
            label3.Text = "Опис";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(54, 188);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(581, 207);
            txtDescription.TabIndex = 6;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(674, 188);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(179, 187);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 7;
            pbImage.TabStop = false;
            // 
            // CategoryCreateForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 437);
            Controls.Add(pbImage);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CategoryCreateForm";
            Text = "CategoryCreateForm";
            Load += CategoryCreateForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtDescription;
        private PictureBox pbImage;
    }
}