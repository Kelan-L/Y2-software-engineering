using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Programmng
{
    public partial class LandingPage : Form
    {
        private Login login;

        public LandingPage(Login myLogin)
        {
            InitializeComponent();
            login = myLogin;
        }
        
        public LandingPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userID.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.userID.Staff);

        }



        private void button1_Click(object sender, EventArgs e)
        {

            Crops form2 = new Crops();
            
            this.Hide();
            form2.ShowDialog();
            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Storage storagepage = new Storage();

            this.Hide();
            storagepage.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Timetable schedule = new Timetable();

            this.Hide();
            schedule.ShowDialog();
            this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Vehicles vehiclepage = new Vehicles();

            this.Hide();
            vehiclepage.ShowDialog();
            this.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
