using ExaminationSys.Controllers;
using ExaminationSys.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExaminationSys.Views
{
    public partial class RegisterForm : Form
    {
        private RegisterController _controller;
       
        public RegisterForm(RegisterController controller)
        {
            _controller = controller;
            InitializeComponent();
            LoadUserTypes();
        }

        private void LoadUserTypes()
        {
            UserTypeCombobox.Items.Add("Teacher");
            UserTypeCombobox.Items.Add("Student");
            UserTypeCombobox.Items.Add("Admin");
            UserTypeCombobox.SelectedIndex = 0;
        }

        private void SubmitToLogin_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            string confirmPassword = ConfirmPassword.Text;

            // Clear previous error messages
            ClearError();

            // Validate user input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                ShowError("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                ShowError("Password and Confirm Password do not match.");
                return;
            }

            // Create a new instance of the user class
            User newUser = new User
            {
                Username = username,
                Password = password
            };

            // Call the RegisterUser method from the controller
            bool registrationSuccess = _controller.RegisterUser(newUser);

            if (registrationSuccess)
            {
                ShowSuccessMessage("Registration successful!");
                Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                ShowError("Registration failed. Please try again.");
            }
        }

        private void ShowSuccessMessage(string message)
        {
            RegisterValidateErrorLabel.ForeColor = Color.Green;
            RegisterValidateErrorLabel.Text = message;
        }

        private void ShowError(string message)
        {
            RegisterValidateErrorLabel.ForeColor = Color.Red;
            RegisterValidateErrorLabel.Text = message;
        }

        private void ClearError()
        {
            RegisterValidateErrorLabel.Text = string.Empty;
        }

        

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Implement your logic for the form load event
        }

        private void UserTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = UserTypeCombobox.SelectedItem.ToString();

            // Display SecondaryForm based on the selected value
            if (selectedValue == "Student")
            {
                LoginForm Lform = new LoginForm();
                Lform.Show();
            }
            else if (selectedValue == "Teacher")
            {
                // Show another form or perform other actions based on the selected value
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Implement your logic for label1 click event
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Implement your logic for label4 click event
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Implement your logic for groupBox1 enter event
        }

        private void LoginLabel_Click_1(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
