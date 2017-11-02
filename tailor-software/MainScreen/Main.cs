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

namespace tailor_software.MainScreen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\abhis\\source\\repos\\tailor-software\\tailor-software\\db.mdf; Integrated Security=True; Connect Timeout=30";
            con.Open();
            string userId = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            SqlCommand command = new SqlCommand("select UserName,Password from LoginTable where UserName='" + userId + "'and Password='" + password + "'", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage ");
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void resetPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
