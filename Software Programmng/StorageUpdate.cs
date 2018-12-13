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
    public partial class StorageUpdate : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);

        public StorageUpdate()
        {
            InitializeComponent();
        }

        private void StorageUpdate_Load(object sender, EventArgs e)
        {
            this.storageTableAdapter.Fill(this.storageDataSet2.Storage);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Crops SET Contents=@Contents,UsedSpace=@UsedSpace WHERE Contents=@Contents";

                cmd.Parameters.AddWithValue("@Contents", textBox2.Text);
                cmd.Parameters.AddWithValue("@UsedSpace", textBox4.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error " + ex.Message);
                }

                con.Close();

            }
        }
    }
}
