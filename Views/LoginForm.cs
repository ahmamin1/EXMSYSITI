using ExaminationSys.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSys.Views
{


    public partial class LoginForm : Form
    {
        private LoginController _loginController;
        public LoginForm()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserTypeCombobox.Items.Add("Teacher");
            UserTypeCombobox.Items.Add("Student");
            UserTypeCombobox.Items.Add("Admin");
            UserTypeCombobox.SelectedIndex = 0;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUserName.Text;
            string password = LoginPassword.Text;
            string role = UserTypeCombobox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                ErrorMsgLoginLabel.Text = "Please enter username, password, and select a role.";
                return;
            }

            bool isAuthenticated = _loginController.AuthenticateUser(username, password, role);

            if (isAuthenticated)
            {
                ErrorMsgLoginLabel.Text="Authentication successful!";
                // Open appropriate form based on user role
                switch (role.ToLower())
                {
                    case "student":
                        StudentHome studentHomeForm = new StudentHome();
                        studentHomeForm.Show();
                        break;
                    case "teacher":
                        TeacherHome teacherHomeForm = new TeacherHome();
                        teacherHomeForm.Show();
                        break;
                    case "admin":
                        AdminHome adminHomeForm = new AdminHome();
                        adminHomeForm.Show();
                        break;
                }
                this.Hide();
            }
            else
            {
                ErrorMsgLoginLabel.Text = "Authentication failed. Please check your credentials.";
            }
        }

       

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewAccountLabel_Click(object sender, EventArgs e)
        {
            RegisterController controller = new RegisterController();

            RegisterForm Rform = new RegisterForm(controller);
            Rform.Show();

            this.Hide();
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
