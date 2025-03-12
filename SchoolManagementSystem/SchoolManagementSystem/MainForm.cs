using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserFrom form = new UserFrom();
            form.Show();

        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentFrom form = new DepartmentFrom();
            form.Show();
        }

        private void addEditClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassesForm form = new ClassesForm();
            form.Show();

        }

        private void studentAddEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            form.Show();

        }

        private void trencherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherFrom form = new TeacherFrom();
            form.Show();
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreForm form = new ScoreForm();
            form.Show();
        }

        private void addEditCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseForm form = new CourseForm();
            form.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();
            form.Show();
        }

        private void userReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("are you sure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
            LoginForm form = new LoginForm();
            form.Show();
        }


        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportFrom form = new ReportFrom();
            form.Show();
        }



    }
}
