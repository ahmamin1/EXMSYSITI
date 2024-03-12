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
    }
}