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

        SqlConnection con = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);

        public Login()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select userid,password,userlevel from [dbo].[Staff] where userid='" + user_name.Text + "'and password='" + passsword.Text + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);

            try
            {
                
                if (dt.Rows.Count > 0)
                {
                    
                    switch (dt.Rows[0]["userlevel"] as string)
                    {
                        case "0":
                            ManagerLandingPage obj2 = new ManagerLandingPage();
                            this.Hide();
                            obj2.ShowDialog();
                            this.Show();
                            break;

                        case "1":
                            LandingPage obj1 = new LandingPage();
                            this.Hide();
                            obj1.ShowDialog();
                            this.Show();
                            break;
                        
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

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
