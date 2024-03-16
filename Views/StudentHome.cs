using ExaminationSys.Views;

namespace ExaminationSys
{
    public partial class TeacherHome : Form
    {

        bool sidebarexpand;
        public TeacherHome()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.Clear();

            TakeExamForm TEF = new TakeExamForm();

            // Set properties of the external form
            TEF.TopLevel = false;
            TEF.FormBorderStyle = FormBorderStyle.None;
            TEF.Dock = DockStyle.Fill;

            // Add the external form to the panel
            HomePanel.Controls.Add(TEF);

            // Show the external form
            TEF.Show();

        }

        private void settings_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.Clear();

            ChooseSubject CSF = new ChooseSubject();

            // Set properties of the external form
            CSF.TopLevel = false;
            CSF.FormBorderStyle = FormBorderStyle.None;
            CSF.Dock = DockStyle.Fill;

            // Add the external form to the panel
            HomePanel.Controls.Add(CSF);

            // Show the external form
            CSF.Show();

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TeacherHome_Load(object sender, EventArgs e)
        {

        }
    }
}