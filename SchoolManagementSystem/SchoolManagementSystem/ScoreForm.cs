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

namespace SchoolManagementSystem
{
    public partial class ScoreForm : Form
    {
        public string ScoreID { get; set; }
        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void FillComboxCourse()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT 1 AS CourseID, 'Select Course' AS CourseName " +
                    "UNION ALL SELECT CourseID, CourseName FROM Course", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Course_comboBox.ValueMember = "CourseID";
                Course_comboBox.DisplayMember = "CourseName";
                Course_comboBox.DataSource = dt;
            }
        }

        private void FillComboxStudent()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT 1 AS StudentID, 'Select Student' AS StudentName " +
                    "UNION ALL SELECT StudentID, StudentName FROM Student", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Student_comboBox.ValueMember = "StudentID";
                Student_comboBox.DisplayMember = "StudentName";
                Student_comboBox.DataSource = dt;
            }
        }


        private void ScoreForm_Load(object sender, EventArgs e)
        {
            DisplayTrList();
            FillComboxStudent();
            FillComboxCourse();
        }

        private void DisplayTrList()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Score.ScoreID,Score.Score,Course.CourseID,Course.CourseName,Student.StudentID,Student.StudentName from Score inner join Course On Score.CourseID = Course.CourseID inner join Student On Score.StudentID = Student.StudentID", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Score_dataGridView.DataSource = dt;
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Course_comboBox.Text == "Select Course" || Student_comboBox.Text == "Select Student" || Score_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditScore";
                cmd.Parameters.AddWithValue("@scoreid", "");
                cmd.Parameters.AddWithValue("@studentid", Student_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@courseid", Course_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@score", Score_textBox.Text);
                cmd.Parameters.AddWithValue("type", "INSERT");
                cmd.ExecuteNonQuery();
                MessageBox.Show(" score has ben Added thx", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayTrList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }


        private void ClearTextBox()
        {
            Score_textBox.Clear();
            FillComboxStudent();
            FillComboxCourse();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (Course_comboBox.Text == "Select Course" || Student_comboBox.Text == "Select Student" || Score_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditScore";
                cmd.Parameters.AddWithValue("@scoreid", ScoreID);
                cmd.Parameters.AddWithValue("@studentid", Student_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@courseid", Course_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@score", Score_textBox.Text);
                cmd.Parameters.AddWithValue("type", "UPDATE");
                cmd.ExecuteNonQuery();
                MessageBox.Show(" score has ben updated thx", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayTrList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (Course_comboBox.Text == "Select Course" || Student_comboBox.Text == "Select Student" || Score_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditScore";
                cmd.Parameters.AddWithValue("@scoreid", ScoreID);
                cmd.Parameters.AddWithValue("@studentid", Student_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@courseid", Course_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@score", Score_textBox.Text);
                cmd.Parameters.AddWithValue("type", "DELETE");
                cmd.ExecuteNonQuery();
                MessageBox.Show(" score has ben deleted thx", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayTrList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void Score_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ScoreID = Score_dataGridView.CurrentRow.Cells[0].Value.ToString();
            Score_textBox.Text = Score_dataGridView.CurrentRow.Cells["Score"].Value.ToString();
            Save_button.Enabled = false;
            Update_button.Enabled = true;
            delete_button.Enabled = true;
        }
    }
}
