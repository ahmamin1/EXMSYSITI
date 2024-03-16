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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserTypeCombobox = new System.Windows.Forms.ComboBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.SubmitToLogin = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
=======
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
>>>>>>> 419449561f07131810871bbdbee19faa0d994aea
            // 
            // label5
            // 
<<<<<<< HEAD
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(540, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Register";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(434, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Register As";
            // 
            // UserTypeCombobox
            // 
            this.UserTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserTypeCombobox.FormattingEnabled = true;
            this.UserTypeCombobox.Location = new System.Drawing.Point(576, 345);
            this.UserTypeCombobox.Name = "UserTypeCombobox";
            this.UserTypeCombobox.Size = new System.Drawing.Size(159, 23);
            this.UserTypeCombobox.TabIndex = 26;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(538, 114);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(287, 50);
            this.UserName.TabIndex = 18;
            // 
            // SubmitToLogin
            // 
            this.SubmitToLogin.BackColor = System.Drawing.Color.Navy;
            this.SubmitToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitToLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitToLogin.Location = new System.Drawing.Point(507, 416);
            this.SubmitToLogin.Name = "SubmitToLogin";
            this.SubmitToLogin.Size = new System.Drawing.Size(188, 62);
            this.SubmitToLogin.TabIndex = 25;
            this.SubmitToLogin.Text = "Submit";
            this.SubmitToLogin.UseVisualStyleBackColor = false;
            this.SubmitToLogin.Click += new System.EventHandler(this.SubmitToLogin_Click_1);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.ForeColor = System.Drawing.Color.Navy;
            this.LoginLabel.Location = new System.Drawing.Point(443, 387);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(285, 21);
            this.LoginLabel.TabIndex = 24;
            this.LoginLabel.Text = "Already have Account? Go to Login";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(267, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(267, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(267, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "User Name";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(540, 258);
            this.ConfirmPassword.Multiline = true;
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(287, 49);
            this.ConfirmPassword.TabIndex = 20;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(540, 180);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(287, 49);
            this.Password.TabIndex = 19;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(947, 490);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserTypeCombobox);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.SubmitToLogin);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

=======
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
>>>>>>> 419449561f07131810871bbdbee19faa0d994aea
        }

        #endregion
        private Label label5;
        private Label label4;
        private ComboBox UserTypeCombobox;
        private TextBox UserName;
        private Button SubmitToLogin;
        private Label LoginLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ConfirmPassword;
        private TextBox Password;
    }
}