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
    public partial class TeacherFrom : Form
    {
        public string TeacherID { get; set; }
        public TeacherFrom()
        {
            InitializeComponent();
        }

        private void TeacherFrom_Load(object sender, EventArgs e)
        {
            DisplayTrList();
        }

        private void DisplayTrList()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Teacher", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TrList_dataGridView.DataSource = dt;
            }
        }

        private void ClearTextBox()
        {
            TrName_textBox.Clear();
            Subject_textBox.Clear();
            Phone_textBox.Clear();
            Gender_comboBox.Text = "";
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (TrName_textBox.Text == "" || Subject_textBox.Text == "" || Phone_textBox.Text == "" || Gender_comboBox.Text == "" || Dob_dateTimePicker.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditTeacher";
                cmd.Parameters.AddWithValue("@teacherid", "");
                cmd.Parameters.AddWithValue("@teachername", TrName_textBox.Text);
                cmd.Parameters.AddWithValue("@teachersubj", Subject_textBox.Text);
                cmd.Parameters.AddWithValue("@phone", Phone_textBox.Text);
                cmd.Parameters.AddWithValue("@dob", Dob_dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@gender", Gender_comboBox.Text);
                cmd.Parameters.AddWithValue("@type", "INSERT");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("teacher has be added thx", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayTrList();
                ClearTextBox();
                Save_button.Enabled = true;
                Delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (TrName_textBox.Text == "" || Subject_textBox.Text == "" || Phone_textBox.Text == "" || Gender_comboBox.Text == "" || Dob_dateTimePicker.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditTeacher";
                cmd.Parameters.AddWithValue("@teacherid", TeacherID);
                cmd.Parameters.AddWithValue("@teachername", TrName_textBox.Text);
                cmd.Parameters.AddWithValue("@teachersubj", Subject_textBox.Text);
                cmd.Parameters.AddWithValue("@phone", Phone_textBox.Text);
                cmd.Parameters.AddWithValue("@dob", Dob_dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@gender", Gender_comboBox.Text);
                cmd.Parameters.AddWithValue("@type", "UPDATE");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("teacher has be updated thx", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayTrList();
                ClearTextBox();
                Save_button.Enabled = true;
                Delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (TrName_textBox.Text == "" || Subject_textBox.Text == "" || Phone_textBox.Text == "" || Gender_comboBox.Text == "" || Dob_dateTimePicker.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditTeacher";
                cmd.Parameters.AddWithValue("@teacherid", TeacherID);
                cmd.Parameters.AddWithValue("@teachername", TrName_textBox.Text);
                cmd.Parameters.AddWithValue("@teachersubj", Subject_textBox.Text);
                cmd.Parameters.AddWithValue("@phone", Phone_textBox.Text);
                cmd.Parameters.AddWithValue("@dob", Dob_dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@gender", Gender_comboBox.Text);
                cmd.Parameters.AddWithValue("@type", "DELETE");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("teacher has be deleted thx", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayTrList();
                ClearTextBox();
                Save_button.Enabled = true;
                Delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void TrList_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TeacherID = TrList_dataGridView.CurrentRow.Cells[0].Value.ToString();
            TrName_textBox.Text = TrList_dataGridView.CurrentRow.Cells["StudentName"].Value.ToString();
            Phone_textBox.Text = TrList_dataGridView.CurrentRow.Cells["Phone"].Value.ToString();
            Gender_comboBox.Text = TrList_dataGridView.CurrentRow.Cells["Gender"].Value.ToString();
            Subject_textBox.Text = TrList_dataGridView.CurrentRow.Cells["TeacherSubj"].Value.ToString();
            Save_button.Enabled = false;
            Update_button.Enabled = true;
            Delete_button.Enabled = true;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Teacher where TeacherID like'" + Search_textBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TrList_dataGridView.DataSource = dt;
            }
        }



    }
}
