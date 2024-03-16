namespace ExaminationSys.Views
{
    partial class RegisterForm
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
            groupBox1 = new GroupBox();
            SubmitToLogin = new Button();
            LoginLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ConfirmPassword = new TextBox();
            Password = new TextBox();
            UserName = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DimGray;
            groupBox1.Controls.Add(SubmitToLogin);
            groupBox1.Controls.Add(LoginLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ConfirmPassword);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(UserName);
            groupBox1.Location = new Point(38, 79);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(720, 452);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // SubmitToLogin
            // 
            SubmitToLogin.BackColor = Color.LimeGreen;
            SubmitToLogin.Cursor = Cursors.Hand;
            SubmitToLogin.Location = new Point(293, 352);
            SubmitToLogin.Margin = new Padding(3, 4, 3, 4);
            SubmitToLogin.Name = "SubmitToLogin";
            SubmitToLogin.Size = new Size(195, 68);
            SubmitToLogin.TabIndex = 15;
            SubmitToLogin.Text = "Submit";
            SubmitToLogin.UseVisualStyleBackColor = false;
            SubmitToLogin.Click += SubmitToLogin_Click;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Cursor = Cursors.Hand;
            LoginLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LoginLabel.ForeColor = Color.Chartreuse;
            LoginLabel.Location = new Point(264, 307);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(354, 28);
            LoginLabel.TabIndex = 14;
            LoginLabel.Text = "Already have Account? Go to Login";
            LoginLabel.Click += LoginLabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 252);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 13;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 143);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 43);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 11;
            label1.Text = "User Name";
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.Location = new Point(293, 228);
            ConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            ConfirmPassword.Multiline = true;
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.PasswordChar = '*';
            ConfirmPassword.Size = new Size(244, 56);
            ConfirmPassword.TabIndex = 10;
            // 
            // Password
            // 
            Password.Location = new Point(293, 125);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(244, 56);
            Password.TabIndex = 9;
            // 
            // UserName
            // 
            UserName.Location = new Point(293, 19);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.Size = new Size(244, 56);
            UserName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(344, 12);
            label5.Name = "label5";
            label5.Size = new Size(147, 39);
            label5.TabIndex = 9;
            label5.Text = "Register";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(832, 627);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button SubmitToLogin;
        private Label LoginLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ConfirmPassword;
        private TextBox Password;
        private TextBox UserName;
        private Label label5;
    }
}