namespace _13.SimleForm.Options
{
    partial class ConnectionForm
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
            txtServerHost = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label2 = new Label();
            txtUserName = new TextBox();
            txtUserPasssword = new TextBox();
            label3 = new Label();
            btnCheckConnection = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 0;
            label1.Text = "Сервер";
            // 
            // txtServerHost
            // 
            txtServerHost.Location = new Point(22, 45);
            txtServerHost.Name = "txtServerHost";
            txtServerHost.Size = new Size(285, 34);
            txtServerHost.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(343, 21);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 39);
            btnSave.TabIndex = 2;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(343, 66);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 39);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(22, 80);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 0;
            label2.Text = "Користувач";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(22, 107);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(285, 34);
            txtUserName.TabIndex = 1;
            // 
            // txtUserPasssword
            // 
            txtUserPasssword.Location = new Point(22, 173);
            txtUserPasssword.Name = "txtUserPasssword";
            txtUserPasssword.Size = new Size(285, 34);
            txtUserPasssword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(22, 146);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // btnCheckConnection
            // 
            btnCheckConnection.ForeColor = Color.Blue;
            btnCheckConnection.Location = new Point(22, 226);
            btnCheckConnection.Name = "btnCheckConnection";
            btnCheckConnection.Size = new Size(190, 39);
            btnCheckConnection.TabIndex = 2;
            btnCheckConnection.Text = "Перевірити з'єднання";
            btnCheckConnection.UseVisualStyleBackColor = true;
            btnCheckConnection.Click += btnCheckConnection_Click;
            // 
            // ConnectionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 282);
            Controls.Add(txtUserPasssword);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnCheckConnection);
            Controls.Add(btnSave);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtServerHost);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ConnectionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Підключення до сервера";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtServerHost;
        private Button btnSave;
        private Button btnCancel;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtUserPasssword;
        private Label label3;
        private Button btnCheckConnection;
    }
}