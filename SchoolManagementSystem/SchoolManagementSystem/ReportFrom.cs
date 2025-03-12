using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace SchoolManagementSystem
{
    public partial class ReportFrom : Form
    {
        DGVPrinter Report = new DGVPrinter();
        public ReportFrom()
        {
            InitializeComponent();
        }

        private void ReportFrom_Load(object sender, EventArgs e)
        {
            FillComboxClass();
            DisplayList();
        }

        private void FillComboxClass()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT 1 AS ClassID, 'Select Classes' AS ClassName " +
                    "UNION ALL SELECT ClassID, ClassName FROM Classes", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Class_comboBox.ValueMember = "ClassID";
                Class_comboBox.DisplayMember = "ClassName";
                Class_comboBox.DataSource = dt;
            }
        }


        private void DisplayList()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Student.StudentID,Student.StudentName,Student.Phone,Student.Sex,Student.status,Student.Dob,Classes.ClassID,Classes.ClassName from Student inner join Classes On Student.ClassID = Classes.ClassID", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List_dataGridView.DataSource = dt;
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Student.StudentID,Student.StudentName,Student.Phone,Student.Sex,Student.status,Student.Dob,Classes.ClassID,Classes.ClassName from Student inner join Classes On Student.ClassID = Classes.ClassID where ClassName like'" + Class_comboBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List_dataGridView.DataSource = dt;
            }
        }

        private void Male_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Student.StudentID,Student.StudentName,Student.Phone,Student.Sex,Student.status,Student.Dob,Classes.ClassID,Classes.ClassName from Student inner join Classes On Student.ClassID = Classes.ClassID where Sex = 'Male'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List_dataGridView.DataSource = dt;
            }
        }

        private void Female_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Student.StudentID,Student.StudentName,Student.Phone,Student.Sex,Student.status,Student.Dob,Classes.ClassID,Classes.ClassName from Student inner join Classes On Student.ClassID = Classes.ClassID where Sex = 'Female'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List_dataGridView.DataSource = dt;
            }
        }

        private void All_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Student.StudentID,Student.StudentName,Student.Phone,Student.Sex,Student.status,Student.Dob,Classes.ClassID,Classes.ClassName from Student inner join Classes On Student.ClassID = Classes.ClassID", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                List_dataGridView.DataSource = dt;
            }
        }

        private void Report_button_Click(object sender, EventArgs e)
        {
            Report.Title = "shafic School Student List Report";
            Report.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            Report.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Report.PageNumbers = true;
            Report.PageNumberInHeader = false;
            Report.PorportionalColumns = true;
            Report.HeaderCellAlignment = StringAlignment.Near;
            Report.Footer = "Team B";
            Report.FooterSpacing = 15;
            Report.printDocument.DefaultPageSettings.Landscape = true;
            Report.PrintDataGridView(List_dataGridView);

        }



    }
}
