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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateNewAccountLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UserTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(473, 191);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(335, 52);
            this.UserName.TabIndex = 8;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(473, 111);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(335, 59);
            this.Password.TabIndex = 9;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
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
=======
            UserName = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CreateNewAccountLabel = new Label();
            LoginButton = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Location = new Point(253, 92);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.Size = new Size(244, 37);
            UserName.TabIndex = 8;
            UserName.TextChanged += UserName_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(253, 143);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(244, 36);
            Password.TabIndex = 9;
            Password.TextChanged += Password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 95);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 11;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 146);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // CreateNewAccountLabel
            // 
            CreateNewAccountLabel.AutoSize = true;
            CreateNewAccountLabel.Cursor = Cursors.Hand;
            CreateNewAccountLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CreateNewAccountLabel.ForeColor = Color.LawnGreen;
            CreateNewAccountLabel.Location = new Point(277, 305);
            CreateNewAccountLabel.Name = "CreateNewAccountLabel";
            CreateNewAccountLabel.Size = new Size(220, 28);
            CreateNewAccountLabel.TabIndex = 14;
            CreateNewAccountLabel.Text = "Create New Account?";
            CreateNewAccountLabel.Click += CreateNewAccountLabel_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.LimeGreen;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Location = new Point(303, 355);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 63);
            LoginButton.TabIndex = 15;
            LoginButton.Text = "Log  In";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
>>>>>>> 419449561f07131810871bbdbee19faa0d994aea
            // 
            // label4
            // 
<<<<<<< HEAD
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(997, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserTypeCombobox);
            this.Controls.Add(this.CreateNewAccountLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

=======
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(UserName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LoginButton);
            groupBox1.Controls.Add(CreateNewAccountLabel);
            groupBox1.Controls.Add(Password);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(89, 99);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(746, 452);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(425, 32);
            label3.Name = "label3";
            label3.Size = new Size(100, 39);
            label3.TabIndex = 17;
            label3.Text = "Login";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(253, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 207);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 17;
            label4.Text = "Login As";
            label4.Click += label4_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(889, 600);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
>>>>>>> 419449561f07131810871bbdbee19faa0d994aea
        }

        #endregion

        private TextBox UserName;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Label CreateNewAccountLabel;
        private Button LoginButton;
        private Label label3;
        private Label label4;
<<<<<<< HEAD
        private ComboBox UserTypeCombobox;
=======
        private ComboBox comboBox1;
>>>>>>> 419449561f07131810871bbdbee19faa0d994aea
    }
}