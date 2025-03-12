namespace SchoolManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentAddEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trencherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherAddEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreAddEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.acaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegistrationToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.userReportToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(149, 43);
            this.userToolStripMenuItem.Text = "Manage";
            // 
            // userRegistrationToolStripMenuItem
            // 
            this.userRegistrationToolStripMenuItem.Name = "userRegistrationToolStripMenuItem";
            this.userRegistrationToolStripMenuItem.Size = new System.Drawing.Size(362, 44);
            this.userRegistrationToolStripMenuItem.Text = "User Add/Edit";
            this.userRegistrationToolStripMenuItem.Click += new System.EventHandler(this.userRegistrationToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(362, 44);
            this.userManagementToolStripMenuItem.Text = "Change Password";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // userReportToolStripMenuItem
            // 
            this.userReportToolStripMenuItem.Name = "userReportToolStripMenuItem";
            this.userReportToolStripMenuItem.Size = new System.Drawing.Size(362, 44);
            this.userReportToolStripMenuItem.Text = "Logout";
            this.userReportToolStripMenuItem.Click += new System.EventHandler(this.userReportToolStripMenuItem_Click);
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentAddEditToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(143, 43);
            this.sTUDENTToolStripMenuItem.Text = "Student";
            // 
            // studentAddEditToolStripMenuItem
            // 
            this.studentAddEditToolStripMenuItem.Name = "studentAddEditToolStripMenuItem";
            this.studentAddEditToolStripMenuItem.Size = new System.Drawing.Size(358, 44);
            this.studentAddEditToolStripMenuItem.Text = "Student Add/Edit";
            this.studentAddEditToolStripMenuItem.Click += new System.EventHandler(this.studentAddEditToolStripMenuItem_Click);
            // 
            // trencherToolStripMenuItem
            // 
            this.trencherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherAddEditToolStripMenuItem});
            this.trencherToolStripMenuItem.Name = "trencherToolStripMenuItem";
            this.trencherToolStripMenuItem.Size = new System.Drawing.Size(149, 43);
            this.trencherToolStripMenuItem.Text = "Teacher";
            this.trencherToolStripMenuItem.Click += new System.EventHandler(this.trencherToolStripMenuItem_Click);
            // 
            // teacherAddEditToolStripMenuItem
            // 
            this.teacherAddEditToolStripMenuItem.Name = "teacherAddEditToolStripMenuItem";
            this.teacherAddEditToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.teacherAddEditToolStripMenuItem.Text = "Teacher Add/Edit";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreAddEditToolStripMenuItem});
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(111, 43);
            this.scoreToolStripMenuItem.Text = "Score";
            this.scoreToolStripMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // scoreAddEditToolStripMenuItem
            // 
            this.scoreAddEditToolStripMenuItem.Name = "scoreAddEditToolStripMenuItem";
            this.scoreAddEditToolStripMenuItem.Size = new System.Drawing.Size(326, 44);
            this.scoreAddEditToolStripMenuItem.Text = "Score Add/Edit";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Calisto MT", 17F, System.Drawing.FontStyle.Bold);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.acaToolStripMenuItem,
            this.sTUDENTToolStripMenuItem,
            this.trencherToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(911, 47);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // acaToolStripMenuItem
            // 
            this.acaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.addEditClassesToolStripMenuItem,
            this.addEditCoursesToolStripMenuItem});
            this.acaToolStripMenuItem.Name = "acaToolStripMenuItem";
            this.acaToolStripMenuItem.Size = new System.Drawing.Size(191, 43);
            this.acaToolStripMenuItem.Text = "Academics";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(425, 44);
            this.departmentToolStripMenuItem.Text = "Add/Edit Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // addEditClassesToolStripMenuItem
            // 
            this.addEditClassesToolStripMenuItem.Name = "addEditClassesToolStripMenuItem";
            this.addEditClassesToolStripMenuItem.Size = new System.Drawing.Size(425, 44);
            this.addEditClassesToolStripMenuItem.Text = "Add/Edit Classes";
            this.addEditClassesToolStripMenuItem.Click += new System.EventHandler(this.addEditClassesToolStripMenuItem_Click);
            // 
            // addEditCoursesToolStripMenuItem
            // 
            this.addEditCoursesToolStripMenuItem.Name = "addEditCoursesToolStripMenuItem";
            this.addEditCoursesToolStripMenuItem.Size = new System.Drawing.Size(425, 44);
            this.addEditCoursesToolStripMenuItem.Text = "Add/Edit Courses";
            this.addEditCoursesToolStripMenuItem.Click += new System.EventHandler(this.addEditCoursesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(144, 43);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(911, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(911, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trencherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem studentAddEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherAddEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreAddEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEditClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEditCoursesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

