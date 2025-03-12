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
    public partial class DepartmentFrom : Form
    {
        public string DeptID { get; set; }
        public DepartmentFrom()
        {
            InitializeComponent();
        }


        private void DepartmentFrom_Load(object sender, EventArgs e)
        {
            DisplayDeptList();
        }


        private void DisplayDeptList()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Department", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Dept_dataGridView.DataSource = dt;
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (DpName_textBox.Text == "" || Hdp_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditDepartment";
                cmd.Parameters.AddWithValue("@deptid", "");
                cmd.Parameters.AddWithValue("@detyname", DpName_textBox.Text);
                cmd.Parameters.AddWithValue("@hod", Hdp_textBox.Text);
                cmd.Parameters.AddWithValue("@type", "INSERT");
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Department has be Added thx", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayDeptList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }
        private void ClearTextBox()
        {
            DpName_textBox.Clear();
            Hdp_textBox.Clear();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (DpName_textBox.Text == "" || Hdp_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditDepartment";
                cmd.Parameters.AddWithValue("@deptid", DeptID);
                cmd.Parameters.AddWithValue("@detyname", DpName_textBox.Text);
                cmd.Parameters.AddWithValue("@hod", Hdp_textBox.Text);
                cmd.Parameters.AddWithValue("@type", "UPDATE");
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Department has be Updated thx", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayDeptList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (DpName_textBox.Text == "" || Hdp_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 

            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspAddEditDepartment";
                cmd.Parameters.AddWithValue("@deptid", DeptID);
                cmd.Parameters.AddWithValue("@detyname", DpName_textBox.Text);
                cmd.Parameters.AddWithValue("@hod", Hdp_textBox.Text);
                cmd.Parameters.AddWithValue("@type", "DELETE");
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Department has be DELETED thx", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayDeptList();
                ClearTextBox();
                Save_button.Enabled = true;
                delete_button.Enabled = false;
                Update_button.Enabled = false;
            }
        }

        private void Dept_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DeptID = Dept_dataGridView.CurrentRow.Cells[0].Value.ToString();
            DpName_textBox.Text = Dept_dataGridView.CurrentRow.Cells["DetyName"].Value.ToString();
            Hdp_textBox.Text = Dept_dataGridView.CurrentRow.Cells["HoD"].Value.ToString();
            Save_button.Enabled = false;
            Update_button.Enabled = true;
            delete_button.Enabled = true;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Department where DetyName like'" + Search_textBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Dept_dataGridView.DataSource = dt;
            }
        }


    }
}
