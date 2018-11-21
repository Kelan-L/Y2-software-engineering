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
    public partial class Crops : Form
    {
        public Crops()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Crops_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'croptabledata.Crops' table. You can move, or remove it, as needed.
            this.cropsTableAdapter.Fill(this.croptabledata.Crops);
            // this stuff is meant to fill the rows in but currently it just breaks everything
            //[System.ComponentModel.Browsable(false)]
            //public System.Windows.Forms.DataGridViewRowCollection Rows { get; }

    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
