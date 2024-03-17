using ExaminationSys.Controllers;
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

namespace ExaminationSys.Views
{
    public partial class ChooseSubject : Form
    {
        private readonly SubjectController subjectController;
        public ChooseSubject()
        {
            InitializeComponent();
            subjectController = new SubjectController();
            LoadSubjects();
        }
        private void LoadSubjects()
        {
            // Retrieve all subjects 
            ICollection<Subject> subjects = subjectController.GetAllSubjects();

            // Check if subjects are retrieved successfully
            if (subjects != null)
            {
                // Loop through each subject and create a button for it
                foreach (Subject subject in subjects)
                {
                    Subject currentSubject = subject;
                    Button subjectButton = new Button();
                    subjectButton.Text = subject.Name;
                    subjectButton.Click += (sender, e) => SubjectButton_Click(currentSubject);
                    SubjectPanel2.Controls.Add(subjectButton);
                }
            }
            else
            {
                MessageBox.Show("Failed to load subjects. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubjectButton_Click(Subject subject)
        {
            MessageBox.Show($"You clicked on the subject: {subject.Name}", "Subject Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChooseSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
