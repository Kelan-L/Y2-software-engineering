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
    public partial class UpdateForm : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Crops(CropID,GrowTime,PlantTime,HarvestTime,Fertiliser) VALUES (@CropID,@GrowTime,@PlantTime,@HarvestTime,@Fertiliser)";
                
                cmd.Parameters.AddWithValue("@CropID", textBox1.Text);
                cmd.Parameters.AddWithValue("@GrowTime", textBox2.Text);
                cmd.Parameters.AddWithValue("@PlantTime", textBox3.Text);
                cmd.Parameters.AddWithValue("@HarvestTime", textBox4.Text);
                cmd.Parameters.AddWithValue("@Fertiliser", textBox5.Text);
                

                try
                {
                    Int32 rowsAffected = cmd.ExecuteNonQuery(); Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    //cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error " + ex.Message);
                }

                con.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}