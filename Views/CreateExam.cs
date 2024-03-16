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
    public partial class CreateExam : Form
    {
        public CreateExam()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrueFalseGroupBox.Visible = false;
           OneChoiceGroupBox.Visible = false;
            MultipleChoiceGroupBox.Visible = false;

            switch (QuestionType.SelectedIndex)
            {
                case 0: // True/False
                    TrueFalseGroupBox.Visible = true;
                    OneChoiceGroupBox.Visible = false;
                    MultipleChoiceGroupBox.Visible = false;
                    break;
                case 1: // One Choice
                    TrueFalseGroupBox.Visible = false;
                    OneChoiceGroupBox.Visible = true;
                    MultipleChoiceGroupBox.Visible = false;
                    break;
                case 2: // Multiple Choice
                    TrueFalseGroupBox.Visible = false;
                    OneChoiceGroupBox.Visible = false;
                    MultipleChoiceGroupBox.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void CreateExam_Load(object sender, EventArgs e)
        {
            QuestionType.Items.Add("True/False");
            QuestionType.Items.Add("One Choice");
            QuestionType.Items.Add("Multiple Choice");

            TrueFalseGroupBox.Visible = false;
            OneChoiceGroupBox.Visible = false;
            MultipleChoiceGroupBox.Visible = true;
        }
    }
}
