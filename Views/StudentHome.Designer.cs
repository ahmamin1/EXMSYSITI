﻿namespace ExaminationSys
{
    partial class StudentHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHome));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExpand = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.HomePanel = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExpand)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.button2);
            this.sidebar.Controls.Add(this.button3);
            this.sidebar.Controls.Add(this.settings);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(141, 450);
            this.sidebar.MinimumSize = new System.Drawing.Size(43, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(141, 450);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExpand);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 70);
            this.panel1.TabIndex = 1;
            // 
            // BtnExpand
            // 
            this.BtnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExpand.Image = ((System.Drawing.Image)(resources.GetObject("BtnExpand.Image")));
            this.BtnExpand.Location = new System.Drawing.Point(3, 9);
            this.BtnExpand.Name = "BtnExpand";
            this.BtnExpand.Size = new System.Drawing.Size(31, 34);
            this.BtnExpand.TabIndex = 2;
            this.BtnExpand.TabStop = false;
            this.BtnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = " Take Exam";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "See Exams";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.settings.Location = new System.Drawing.Point(3, 187);
            this.settings.Name = "settings";
            this.settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settings.Size = new System.Drawing.Size(159, 48);
            this.settings.TabIndex = 4;
            this.settings.Text = "ChooseSubject";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Tick += new System.EventHandler(this.sidebartick);
            // 
            // HomePanel
            // 
            this.HomePanel.Location = new System.Drawing.Point(147, 3);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(801, 413);
            this.HomePanel.TabIndex = 1;
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentHome";
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
        private Button button3;
        private Button button2;
        private System.Windows.Forms.Timer SidebarTimer;
        private Button settings;
        private Panel HomePanel;
    }
}