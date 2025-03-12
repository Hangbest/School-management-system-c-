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
    public partial class ChangePasswordForm : Form
    {
        public string UserID { get; set; }
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            DisplayUserList();
        }

        private void DisplayUserList()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select UserID,UserName,Password,UserType from Users", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserList_dataGridView.DataSource = dt;
            }
        }

        private void ClearTextBox()
        {
            Username_textBox.Clear();
            Password_textBox.Clear();
            ConfiPassword_textBox.Clear();

        }


 

        private void UserList_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserID = UserList_dataGridView.CurrentRow.Cells[0].Value.ToString();
            Username_textBox.Text = UserList_dataGridView.CurrentRow.Cells["Username"].Value.ToString();
            Password_textBox.Text = UserList_dataGridView.CurrentRow.Cells["Password"].Value.ToString();
            ConfiPassword_textBox.Text = Password_textBox.Text;
            Update_button.Enabled = true;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From users where FristName like'" + Search_textBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserList_dataGridView.DataSource = dt;
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (Username_textBox.Text == "" || Password_textBox.Text == "" || ConfiPassword_textBox.Text == "")
            {
                MessageBox.Show("fill the blank input fileds please", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Password_textBox.Text != ConfiPassword_textBox.Text)
            {
                MessageBox.Show("Password did not much", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //save user data
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UspUserChangePassword";
                cmd.Parameters.AddWithValue("@userid", UserID);
                cmd.Parameters.AddWithValue("@username", Username_textBox.Text);
                cmd.Parameters.AddWithValue("@password", Password_textBox.Text);
                cmd.Parameters.AddWithValue("@type", "UPDATE");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("user has be updated thx", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayUserList();
                ClearTextBox();
                Update_button.Enabled = false;
                Username_textBox.ReadOnly = false;
                Password_textBox.ReadOnly = false;
                ConfiPassword_textBox.ReadOnly = false;

            }
        }




    }
}
