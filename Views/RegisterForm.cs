using ExaminationSys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExaminationSys.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void RegisterForm_Load(object sender, EventArgs e)
        {

            UserTypeCombobox.Items.Add("Teacher");
            UserTypeCombobox.Items.Add("Student");
            UserTypeCombobox.Items.Add("Admin");
            UserTypeCombobox.SelectedIndex = 0;

        }

        private void UserTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = UserTypeCombobox.SelectedItem.ToString();

            // Display SecondaryForm based on the selected value
            if (selectedValue == "Option 1")
            {
                LoginForm Lform = new LoginForm();
                Lform.Show();
            }
            else if (selectedValue == "Option 2")
            {
                // Show another form or perform other actions based on the selected value
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SubmitToLogin_Click_1(object sender, EventArgs e)
        {

            LoginForm Lform = new LoginForm();
            Lform.Show();


            this.Hide();
        }

        private void LoginLabel_Click_1(object sender, EventArgs e)
        {
            LoginForm Lform = new LoginForm();
            Lform.Show();


            this.Hide();
        }
    }
}
