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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toolsDataSet2.Tools' table. You can move, or remove it, as needed.
            this.toolsTableAdapter.Fill(this.toolsDataSet2.Tools);
            // TODO: This line of code loads data into the 'databaseDataSet1.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.databaseDataSet1.Vehicles);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
