namespace ExaminationSys.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginUserName = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateNewAccountLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UserTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorMsgLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginUserName
            // 
            this.LoginUserName.Location = new System.Drawing.Point(455, 118);
            this.LoginUserName.Multiline = true;
            this.LoginUserName.Name = "LoginUserName";
            this.LoginUserName.Size = new System.Drawing.Size(335, 52);
            this.LoginUserName.TabIndex = 8;
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(444, 198);
            this.LoginPassword.Multiline = true;
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(335, 59);
            this.LoginPassword.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(236, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(236, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // CreateNewAccountLabel
            // 
            this.CreateNewAccountLabel.AutoSize = true;
            this.CreateNewAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateNewAccountLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CreateNewAccountLabel.ForeColor = System.Drawing.Color.Navy;
            this.CreateNewAccountLabel.Location = new System.Drawing.Point(546, 396);
            this.CreateNewAccountLabel.Name = "CreateNewAccountLabel";
            this.CreateNewAccountLabel.Size = new System.Drawing.Size(178, 21);
            this.CreateNewAccountLabel.TabIndex = 14;
            this.CreateNewAccountLabel.Text = "Create New Account?";
            this.CreateNewAccountLabel.Click += new System.EventHandler(this.CreateNewAccountLabel_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Navy;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(495, 435);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(219, 72);
            this.LoginButton.TabIndex = 15;
            this.LoginButton.Text = "Log  In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(401, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Login As";
            // 
            // UserTypeCombobox
            // 
            this.UserTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserTypeCombobox.FormattingEnabled = true;
            this.UserTypeCombobox.Location = new System.Drawing.Point(533, 316);
            this.UserTypeCombobox.Name = "UserTypeCombobox";
            this.UserTypeCombobox.Size = new System.Drawing.Size(159, 23);
            this.UserTypeCombobox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(546, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorMsgLoginLabel
            // 
            this.ErrorMsgLoginLabel.AutoSize = true;
            this.ErrorMsgLoginLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorMsgLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMsgLoginLabel.Location = new System.Drawing.Point(495, 362);
            this.ErrorMsgLoginLabel.Name = "ErrorMsgLoginLabel";
            this.ErrorMsgLoginLabel.Size = new System.Drawing.Size(0, 25);
            this.ErrorMsgLoginLabel.TabIndex = 20;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(997, 533);
            this.Controls.Add(this.ErrorMsgLoginLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserTypeCombobox);
            this.Controls.Add(this.CreateNewAccountLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginUserName);
            this.Controls.Add(this.LoginPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private TextBox LoginUserName;
        private TextBox LoginPassword;
        private Label label1;
        private Label label2;
        private Label CreateNewAccountLabel;
        private Button LoginButton;
        private Label label3;
        private Label label4;
        private ComboBox UserTypeCombobox;
<<<<<<< HEAD
        private Label ErrorMsgLoginLabel;
=======
>>>>>>> b7b55ddcf57b7150e28d3d31c39ced31c8339c38
    }
}