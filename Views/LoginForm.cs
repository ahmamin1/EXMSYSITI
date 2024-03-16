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
        public LoginForm()
        {
            InitializeComponent();
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

            string selectedValue = UserTypeCombobox.SelectedItem.ToString();

            // Display SecondaryForm based on the selected value
            if (selectedValue == "Student")
            {

                TeacherHome SHform = new TeacherHome();
                SHform.Show();
                
                this.Hide();
            }
            else if (selectedValue == "Teacher")
            {
               Home THform = new Home();
                THform.Show();

                this.Hide();
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewAccountLabel_Click(object sender, EventArgs e)
        {
            RegisterForm Rform = new RegisterForm();
            Rform.Show();


            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
