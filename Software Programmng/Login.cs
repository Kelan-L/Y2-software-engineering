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
namespace Software_Programmng
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userID.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter1.Fill(this.userID.Staff);
            // TODO: This line of code loads data into the 'password.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.password.Staff);

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
            con.Open();
            string userid = username.Text;
            string password = passcode.Text;
            SqlCommand cmd = new SqlCommand("select userid,password from Staff where userid='" + username.Text + "'and password='" + passcode.Text + "'", con); // grabs user and pword from dbase + user imput
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                LandingPage obj1 = new LandingPage();
                this.Close();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            //con.Close();
        }

        private void Username(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) =>
            //this closes the aplication once clicked
            Application.Exit();
    }
}
