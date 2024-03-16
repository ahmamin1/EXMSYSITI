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

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            StudentHome SHform = new StudentHome();
            SHform.Show();
            //here i want to check if user student will show student home page  and teacher also


            this.Hide();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
