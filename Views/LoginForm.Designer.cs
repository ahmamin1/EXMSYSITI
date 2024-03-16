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
            // 
            // groupBox1
            // 
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
        }

        #endregion

        private TextBox UserName;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Label CreateNewAccountLabel;
        private Button LoginButton;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}