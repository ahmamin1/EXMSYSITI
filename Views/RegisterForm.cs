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

        private void SubmitToLogin_Click(object sender, EventArgs e)
        {

            LoginForm Lform = new LoginForm();
            Lform.Show();


            this.Hide();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

            LoginForm Lform = new LoginForm();
            Lform.Show();


            this.Hide();
        }
    }
}
