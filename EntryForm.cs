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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenRegistrationForm(UserType.Student);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            OpenRegistrationForm(UserType.Teacher);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenRegistrationForm(UserType.Admin);
        }

        private void OpenRegistrationForm(UserType userType)
        {
            registerform registrationForm = new registerform(userType);
            registrationForm.ShowDialog();
        }
    }
}
