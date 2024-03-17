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
    public partial class SubjectManagementForm : Form
    {
        private SubjectController _subjectController;
        public SubjectManagementForm()
        {
            InitializeComponent();
            _subjectController = new SubjectController();
        }
        private void InitializeDataGridView()
        {
            // Set up DataGridView columns
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "SubjectId";
            idColumn.HeaderText = "ID";

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";

          

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;

            SubjectDataGridView.Columns.Add(idColumn);
            SubjectDataGridView.Columns.Add(nameColumn);
           
            SubjectDataGridView.Columns.Add(deleteColumn);

            SubjectDataGridView.AutoGenerateColumns = false;
            SubjectDataGridView.CellClick += SubjectDataGridView_CellContentClick;
        }

        private void LoadSubjects()
        {
            List<Subject> subjects = _subjectController.GetAllSubjects()?.ToList();

            if (subjects != null)
            {
                DataTable dataTable = ConvertToDataTable(subjects);
                SubjectDataGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Failed to load subjects. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ConvertToDataTable(List<Subject> subjects)
        {
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable
            dataTable.Columns.Add("SubjectId", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));

            // Add rows to the DataTable
            foreach (var subject in subjects)
            {
                dataTable.Rows.Add(subject.SubjectId, subject.Name);
            }

            return dataTable;
        }

        private void DeleteSubject(int subjectId)
        {
            
            bool success = _subjectController.DeleteSubject(subjectId);

            if (success)
            {
                // Refresh the DataGridView
                LoadSubjects();
            }
            else
            {
                // Handle error or display message
            }
        }
        private void SubjectManagementForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            LoadSubjects();
        }


        private void SubjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int subjectId = (int)SubjectDataGridView.Rows[e.RowIndex].Cells["SubjectId"].Value;
                string subjectName = (string)SubjectDataGridView.Rows[e.RowIndex].Cells["Name"].Value;

                if (e.ColumnIndex == SubjectDataGridView.Columns["Delete"].Index)
                {
                    // Handle delete button click
                    DeleteSubject(subjectId);
                }
            }

        }

        private void AddSubjectNameBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the subject name from the textbox
            string subjectName = SubjectNameTextBox.Text;

            // Check if the subject name is empty
            if (string.IsNullOrWhiteSpace(subjectName))
            {
                MessageBox.Show("Please enter a subject name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Subject object
            Subject newSubject = new Subject
            {
                Name = subjectName
            };

            // Add the subject to the database
            bool success = _subjectController.AddSubject(newSubject);

            if (success)
            {
                MessageBox.Show("Subject added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the textbox after adding the subject
                SubjectNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add subject. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
