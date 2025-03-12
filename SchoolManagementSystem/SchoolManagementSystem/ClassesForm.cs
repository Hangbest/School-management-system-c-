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
    public partial class ClassesForm : Form
    {
        public string ClassID { get; set; }
        public string DeptID { get; set; }
        public ClassesForm()
        {
            InitializeComponent();
        }

        private void CLasses_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassID = CLasses_dataGridView.CurrentRow.Cells[0].Value.ToString();
            CLassName_textBox.Text = CLasses_dataGridView.CurrentRow.Cells["ClassName"].Value.ToString();
            Save_button.Enabled = false;
            Update_button.Enabled = true;
            delete_button.Enabled = true;
        }

        private void DisplayClassList()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Classes.ClassID,Classes.ClassName,Department.DeptID,Department.DetyName from Classes inner join Department On Classes.DeptID = Department.DeptID", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CLasses_dataGridView.DataSource = dt;
            }
        }

        private void ClassesForm_Load(object sender, EventArgs e)
        {
            FillComboxDept();
            DisplayClassList();
        }

        private void FillComboxDept()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT 1 AS DeptID, 'Select Department' AS DetyName " +
                    "UNION ALL SELECT DeptID, DetyName FROM Department", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Dept_comboBox.ValueMember = "DeptID";
                Dept_comboBox.DisplayMember = "DetyName";
                Dept_comboBox.DataSource = dt;
            }
        }


        private void Save_button_Click(object sender, EventArgs e)
        {
            if (CLassName_textBox.Text == "" || Dept_comboBox.Text == "Select Department")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditClass";
                cmd.Parameters.AddWithValue("@classid", "");
                cmd.Parameters.AddWithValue("@classname",CLassName_textBox.Text);
                cmd.Parameters.AddWithValue("@deptid", Dept_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@type", "INSERT");
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Class has ben Added thx", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayClassList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void ClearTextBox()
        {
            CLassName_textBox.Clear();
            FillComboxDept();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (CLassName_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditClass";
                cmd.Parameters.AddWithValue("@classid", ClassID);
                cmd.Parameters.AddWithValue("@classname", CLassName_textBox.Text);
                cmd.Parameters.AddWithValue("@deptid", Dept_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@type", "UPDATE");
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Class has ben updated thx", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayClassList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (CLassName_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditClass";
                cmd.Parameters.AddWithValue("@classid", ClassID);
                cmd.Parameters.AddWithValue("@classname", CLassName_textBox.Text);
                cmd.Parameters.AddWithValue("@deptid", Dept_comboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@type", "DELETE");
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Class has ben deleted thx", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayClassList();
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
                SqlDataAdapter da = new SqlDataAdapter("Select * From Classes where ClassName like'" + Search_textBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CLasses_dataGridView.DataSource = dt;
            }
        }






    }
}
