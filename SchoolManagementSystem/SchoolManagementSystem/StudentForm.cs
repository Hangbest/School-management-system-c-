using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class StudentForm : Form
    {
        public string StudentID { get; set; }
        public string ClassID { get; set; }
        public StudentForm()
        {
            InitializeComponent();
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

        private void DisplayStdList()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Student.StudentID,Student.StudentName,Student.Phone,Student.Sex,Student.status,Student.Dob,Classes.ClassID,Classes.ClassName from Student inner join Classes On Student.ClassID = Classes.ClassID", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                StdList_dataGridView.DataSource = dt;
            }
        }

        private void ClearTextBox()
        {
            Stdname_textBox.Clear();
            Phone_textBox.Clear();
            FillComboxClass();
            Gender_comboBox.Text = "";
        }

        

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Stdname_textBox.Text == "" || Phone_textBox.Text == "" || Dob_dateTimePicker.Text == "" || Gender_comboBox.Text == "" || Class_comboBox.Text == "Select Classes")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditStudent";
                cmd.Parameters.AddWithValue("@studentid", "");
                cmd.Parameters.AddWithValue("@Studentname", Stdname_textBox.Text);
                cmd.Parameters.AddWithValue("@phone", Phone_textBox.Text);
                cmd.Parameters.AddWithValue("@classname", Class_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@dob", Dob_dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@sex", Gender_comboBox.Text);
                cmd.Parameters.AddWithValue("@type", "INSERT");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("Student has be updated thx", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayStdList();
                ClearTextBox();
                Save_button.Enabled = true;
                Delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            FillComboxClass();
            DisplayStdList();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (Stdname_textBox.Text == "" || Phone_textBox.Text == "" || Dob_dateTimePicker.Text == "" || Gender_comboBox.Text == "" || Class_comboBox.Text == "Select Classes")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditStudent";
                cmd.Parameters.AddWithValue("@studentid", "");
                cmd.Parameters.AddWithValue("@Studentname", Stdname_textBox.Text);
                cmd.Parameters.AddWithValue("@phone", Phone_textBox.Text);
                cmd.Parameters.AddWithValue("@dob", Dob_dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@sex", Gender_comboBox.Text);
                cmd.Parameters.AddWithValue("@type", "INSERT");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("Student has be Added thx", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayStdList();
                ClearTextBox();
                Save_button.Enabled = true;
                Delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Stdname_textBox.Text == "" || Phone_textBox.Text == "" || Dob_dateTimePicker.Text == "" || Gender_comboBox.Text == "" || Class_comboBox.Text == "Select Classes")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditStudent";
                cmd.Parameters.AddWithValue("@studentid", StudentID);
                cmd.Parameters.AddWithValue("@Studentname", Stdname_textBox.Text);
                cmd.Parameters.AddWithValue("@phone", Phone_textBox.Text);
                cmd.Parameters.AddWithValue("@dob", Dob_dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@sex", Gender_comboBox.Text);
                cmd.Parameters.AddWithValue("@type", "DELETE");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("Student has be DELETED thx", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayStdList();
                ClearTextBox();
                Save_button.Enabled = true;
                Delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void StdList_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = StdList_dataGridView.CurrentRow.Cells[0].Value.ToString();
            Stdname_textBox.Text = StdList_dataGridView.CurrentRow.Cells["StudentName"].Value.ToString();
            Phone_textBox.Text = StdList_dataGridView.CurrentRow.Cells["Phone"].Value.ToString();
            Gender_comboBox.Text = StdList_dataGridView.CurrentRow.Cells["Sex"].Value.ToString();
            Save_button.Enabled = false;
            Update_button.Enabled = true;
            Delete_button.Enabled = true;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Student where StudentName like'" + Search_textBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                StdList_dataGridView.DataSource = dt;
            }
        }



    }
}
