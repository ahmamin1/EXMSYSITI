using DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination
{
    public partial class Login : Form
    {
        private ExamDbContext dbContext;

        public Login()
        {
            InitializeComponent();
            dbContext = new ExamDbContext();
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate user credentials
            if (ValidateUser(username, password))
            {
                // Login successful
                MessageBox.Show("Login successful!");
                // Add code to navigate to the main form or perform other actions
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            registerform registerForm = new registerform();
            registerForm.Show();
            this.Hide();
        }
        private bool ValidateUser(string username, string password)
        {
            // Check the user credentials against the database
            var user = dbContext.Students.FirstOrDefault(s => s.Username == username && s.Password == password);
            if (user != null)
            {
                // User found in the Students table
                return true;
            }

            // Check in the Teachers table
            var teacher = dbContext.Teachers.FirstOrDefault(t => t.Username == username && t.Password == password);
            if (teacher != null)
            {
                // User found in the Teachers table
                return true;
            }

            // Check in the Admins table
            var admin = dbContext.Admins.FirstOrDefault(a => a.Username == username && a.Password == password);
            if (admin != null)
            {
                // User found in the Admins table
                return true;
            }

            // No matching user found
            return false;
        }
    
    //private void GotoMain_Click(object sender, EventArgs e)
    //{
    //    EntryForm entry = new EntryForm();
    //    entry.Show();
    //    this.Hide();
    //}

}
    }

