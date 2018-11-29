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
       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
                con.Open();
                string userid = user_name.Text;
                string password = passsword.Text;
                SqlCommand cmd = new SqlCommand("select userid,password from Staff where userid='" + user_name.Text + "'and password='" + passsword.Text + "'", con); // grabs user and pword from dbase + user imput
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                if (dt.Rows.Count > 0)
                {
                    //this.Hide();

                    string userlevel = dt.Rows[0]["userlevel"].ToString();


                    switch (userlevel)
                    {
                        case "1":
                            LandingPage obj1 = new LandingPage();
                            this.Hide();
                            obj1.ShowDialog();
                            this.Show();
                            break;
                        case "0":
                            ManagerLandingPage obj2 = new ManagerLandingPage();
                            this.Hide();
                            obj2.ShowDialog();
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("INVALID USERNAME OR PASSWORD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*public DataTable Staff(String Username, String Password)
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from tbl_Staff where Username=@Username and Password=@Password", con);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                //this.Close();
                LandingPage obj1 = new LandingPage();
                this.Hide();
                obj1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            //con.Close();
        }
        */
        private void Username(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) =>
            //this closes the aplication once clicked
            Application.Exit();


        private void Login_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'password1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter3.Fill(this.password1.Staff);
            // TODO: This line of code loads data into the 'userID1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter2.Fill(this.userID1.Staff);

        }
    }
}
