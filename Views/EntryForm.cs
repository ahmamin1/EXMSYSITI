﻿using System;
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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            RegisterForm Rform = new RegisterForm();
            Rform.Show();

           
            this.Hide();

        }

        private void TeacherButton_Click(object sender, EventArgs e)
        {

            RegisterForm Rform = new RegisterForm();
            Rform.Show();


            this.Hide();

        }
    }
}
