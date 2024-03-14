using ExaminationSys.Views;

namespace ExaminationSys
{
    public partial class Home : Form
    {

        bool sidebarexpand;
        public Home()
        {
            InitializeComponent();
        }

        private void sidebartick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                //if sidebar expand ,minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarexpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarexpand = true;
                    SidebarTimer.Stop();
                }
            }

        }

        private void BtnExpand_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherHomePanel.Controls.Clear();

            CreateExam CEF = new CreateExam();

            // Set properties of the external form
            CEF.TopLevel = false;
            CEF.FormBorderStyle = FormBorderStyle.None;
            CEF.Dock = DockStyle.Fill;

            // Add the external form to the panel
            TeacherHomePanel.Controls.Add(CEF);

            // Show the external form
            CEF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            TeacherHomePanel.Controls.Clear();

            ChooseSubject CSF = new ChooseSubject();

            // Set properties of the external form
            CSF.TopLevel = false;
            CSF.FormBorderStyle = FormBorderStyle.None;
            CSF.Dock = DockStyle.Fill;

            // Add the external form to the panel
            TeacherHomePanel.Controls.Add(CSF);

            // Show the external form
            CSF.Show();
        }
    }
}