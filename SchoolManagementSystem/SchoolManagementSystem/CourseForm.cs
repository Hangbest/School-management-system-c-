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
    public partial class CourseForm : Form
    {
        public string CourseID { get; set; }
        public CourseForm()
        {
            InitializeComponent();
        }

        private void DisplayStdList()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Course", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Course_dataGridView.DataSource = dt;
            }
        }

        private void ClearTextBox()
        {
            CoursName_textBox.Clear();
            CourseDescrip_textBox.Clear();
            CourseHours_textBox.Clear();
        }

        
        
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (CoursName_textBox.Text == "" || CourseDescrip_textBox.Text == "" || CourseHours_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditCourse";
                cmd.Parameters.AddWithValue("@courseid", "" );
                cmd.Parameters.AddWithValue("@coursename" , CoursName_textBox.Text);
                cmd.Parameters.AddWithValue("@coursedescrip", CourseDescrip_textBox.Text);
                cmd.Parameters.AddWithValue("@coursehours", CourseHours_textBox.Text);
                cmd.Parameters.AddWithValue("@type", "INSERT");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("new Course has be Added thx", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayStdList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;
                

            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Course where CourseName like'" + Search_textBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Course_dataGridView.DataSource = dt;
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            DisplayStdList();
        }

        private void Course_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CourseID = Course_dataGridView.CurrentRow.Cells[0].Value.ToString();
            CoursName_textBox.Text = Course_dataGridView.CurrentRow.Cells["CourseName"].Value.ToString();
            CourseDescrip_textBox.Text = Course_dataGridView.CurrentRow.Cells["CourseDescrip"].Value.ToString();
            CourseHours_textBox.Text = Course_dataGridView.CurrentRow.Cells["CourseHours"].Value.ToString();
            Save_button.Enabled = false;
            delete_button.Enabled = true;
            Update_button.Enabled = true;

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (CoursName_textBox.Text == "" || CourseDescrip_textBox.Text == "" || CourseHours_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditCourse";
                cmd.Parameters.AddWithValue("@courseid", CourseID);
                cmd.Parameters.AddWithValue("@coursename", CoursName_textBox.Text);
                cmd.Parameters.AddWithValue("@coursedescrip", CourseDescrip_textBox.Text);
                cmd.Parameters.AddWithValue("@coursehours", CourseHours_textBox.Text);
                cmd.Parameters.AddWithValue("@type", "UPDATE");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("Course has be UPDATED thx", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayStdList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;


            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (CoursName_textBox.Text == "" || CourseDescrip_textBox.Text == "" || CourseHours_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditCourse";
                cmd.Parameters.AddWithValue("@courseid", CourseID);
                cmd.Parameters.AddWithValue("@coursename", CoursName_textBox.Text);
                cmd.Parameters.AddWithValue("@coursedescrip", CourseDescrip_textBox.Text);
                cmd.Parameters.AddWithValue("@coursehours", CourseHours_textBox.Text);
                cmd.Parameters.AddWithValue("@type", "DELETE");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("Course has be DELETED thx", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayStdList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;
            }



        }
    }
}
