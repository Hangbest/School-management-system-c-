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
    public partial class UserFrom : Form
    {
        public string UserID { get; set; }
        public UserFrom()
        {
            InitializeComponent();
        }

        private void UserFrom_Load(object sender, EventArgs e)
        {
            DisplayUserList();
        }

        private void DisplayUserList()
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From users", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserList_dataGridView.DataSource = dt;
            }
        }
        // the save button for user registration 
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Fname_textBox.Text == "" || Lname_textBox.Text == "" || Username_textBox.Text == "" || Password_textBox.Text == "" || ConfiPassword_textBox.Text == "" || UserType_comboBox.Text == "")
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
                cmd.CommandText = "UspAddEditUsers";
                cmd.Parameters.AddWithValue("@userid", "");
                cmd.Parameters.AddWithValue("@fname", Fname_textBox.Text);
                cmd.Parameters.AddWithValue("@lname", Lname_textBox.Text);
                cmd.Parameters.AddWithValue("@username", Username_textBox.Text);
                cmd.Parameters.AddWithValue("@password", Password_textBox.Text);
                cmd.Parameters.AddWithValue("@usertype", UserType_comboBox.Text);
                cmd.Parameters.AddWithValue("@type", "INSERT");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("user has be Added thx", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayUserList();
                ClearTextBox();
                Save_button.Enabled = true;
                Delete_button.Enabled = false;
                Update_button.Enabled = false;
            }

        }

        private void ClearTextBox()
        {
            Fname_textBox.Clear();
            Lname_textBox.Clear();
            Username_textBox.Clear();
            Password_textBox.Clear();
            ConfiPassword_textBox.Clear();
            UserType_comboBox.Text = "";
        }

        private void UserList_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserID = UserList_dataGridView.CurrentRow.Cells[0].Value.ToString();
            Fname_textBox.Text = UserList_dataGridView.CurrentRow.Cells[1].Value.ToString();
            Lname_textBox.Text = UserList_dataGridView.CurrentRow.Cells["LastName"].Value.ToString();
            Username_textBox.Text = UserList_dataGridView.CurrentRow.Cells["Username"].Value.ToString();
            Password_textBox.Text = UserList_dataGridView.CurrentRow.Cells["Password"].Value.ToString();
            ConfiPassword_textBox.Text = Password_textBox.Text;
            UserType_comboBox.Text = UserList_dataGridView.CurrentRow.Cells["Usertype"].Value.ToString();
            Save_button.Enabled = false;
            Delete_button.Enabled = true;
            Update_button.Enabled = true;
            Username_textBox.ReadOnly = true;
            Password_textBox.ReadOnly = true;
            ConfiPassword_textBox.ReadOnly = true;
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (Fname_textBox.Text == "" || Lname_textBox.Text == "" || Username_textBox.Text == "" || Password_textBox.Text == "" || ConfiPassword_textBox.Text == "" || UserType_comboBox.Text == "")
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
                cmd.CommandText = "UspAddEditUsers";
                cmd.Parameters.AddWithValue("@userid", UserID);
                cmd.Parameters.AddWithValue("@fname", Fname_textBox.Text);
                cmd.Parameters.AddWithValue("@lname", Lname_textBox.Text);
                cmd.Parameters.AddWithValue("@username", Username_textBox.Text);
                cmd.Parameters.AddWithValue("@password", Password_textBox.Text);
                cmd.Parameters.AddWithValue("@usertype", UserType_comboBox.Text);
                cmd.Parameters.AddWithValue("@type", "UPDATE");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("user has be updated thx", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayUserList();
                ClearTextBox();
                Save_button.Enabled = true;
                Delete_button.Enabled = false;
                Update_button.Enabled = false;
                Username_textBox.ReadOnly = false;
                Password_textBox.ReadOnly = false;
                ConfiPassword_textBox.ReadOnly = false;

            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Fname_textBox.Text == "" || Lname_textBox.Text == "" || Username_textBox.Text == "" || Password_textBox.Text == "" || ConfiPassword_textBox.Text == "" || UserType_comboBox.Text == "")
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
                cmd.CommandText = "UspAddEditUsers";
                cmd.Parameters.AddWithValue("@userid", UserID);
                cmd.Parameters.AddWithValue("@fname", Fname_textBox.Text);
                cmd.Parameters.AddWithValue("@lname", Lname_textBox.Text);
                cmd.Parameters.AddWithValue("@username", Username_textBox.Text);
                cmd.Parameters.AddWithValue("@password", Password_textBox.Text);
                cmd.Parameters.AddWithValue("@usertype", UserType_comboBox.Text);
                cmd.Parameters.AddWithValue("@type", "DELETE");
                cmd.ExecuteNonQuery();//DML
                MessageBox.Show("user has be deleted thx", "delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayUserList();
                ClearTextBox();
                Save_button.Enabled = true;
                Delete_button.Enabled = false;
                Update_button.Enabled = false;
                Username_textBox.ReadOnly = false;
                Password_textBox.ReadOnly = false;
                ConfiPassword_textBox.ReadOnly = false;
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From users where FristName like'" + Search_textBox.Text +"%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserList_dataGridView.DataSource = dt;
            }
        }

    }
}
