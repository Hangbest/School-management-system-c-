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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = MainClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("select * from Users where UserName = @username and Password = @password", conn);
                cmd.Parameters.AddWithValue("@username", TxtUsername.Text);
                cmd.Parameters.AddWithValue("@password", TxtPassword.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect", "Erro login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }



    }
}
