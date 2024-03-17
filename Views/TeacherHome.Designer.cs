namespace ExaminationSys
{
    partial class TeacherHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherHome));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExpand = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateExamBtn = new System.Windows.Forms.Button();
            this.GetAllSubjectBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.TeacherHomePanel = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExpand)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.AllowDrop = true;
            this.sidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.CreateExamBtn);
            this.sidebar.Controls.Add(this.GetAllSubjectBtn);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Controls.Add(this.button5);
            this.sidebar.Controls.Add(this.button6);
            this.sidebar.Controls.Add(this.button7);
            this.sidebar.Controls.Add(this.button8);
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.Name = "sidebar";
            this.sidebar.Resize += new System.EventHandler(this.Home_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.BtnExpand);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // BtnExpand
            // 
            this.BtnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnExpand, "BtnExpand");
            this.BtnExpand.Name = "BtnExpand";
            this.BtnExpand.TabStop = false;
            this.BtnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // CreateExamBtn
            // 
            this.CreateExamBtn.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.CreateExamBtn, "CreateExamBtn");
            this.CreateExamBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateExamBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateExamBtn.Name = "CreateExamBtn";
            this.CreateExamBtn.UseVisualStyleBackColor = false;
            this.CreateExamBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // GetAllSubjectBtn
            // 
            this.GetAllSubjectBtn.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.GetAllSubjectBtn, "GetAllSubjectBtn");
            this.GetAllSubjectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetAllSubjectBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetAllSubjectBtn.Name = "GetAllSubjectBtn";
            this.GetAllSubjectBtn.UseVisualStyleBackColor = false;
            this.GetAllSubjectBtn.Click += new System.EventHandler(this.GetAllSubjectBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.button6, "button6");
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.button7, "button7");
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.button8, "button8");
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Tick += new System.EventHandler(this.sidebartick);
            // 
            // TeacherHomePanel
            // 
            this.TeacherHomePanel.AllowDrop = true;
            resources.ApplyResources(this.TeacherHomePanel, "TeacherHomePanel");
            this.TeacherHomePanel.Name = "TeacherHomePanel";
            this.TeacherHomePanel.Resize += new System.EventHandler(this.Home_Load);
            // 
            // TeacherHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeacherHomePanel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExpand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private PictureBox BtnExpand;
        private Label label1;
        private Button CreateExamBtn;
        private System.Windows.Forms.Timer SidebarTimer;
        private Button GetAllSubjectBtn;
        private Panel TeacherHomePanel;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}