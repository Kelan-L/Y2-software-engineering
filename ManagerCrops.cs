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
    public partial class ManagerCrops : Form
    {
        public ManagerCrops()
        {
            InitializeComponent();
        }

        private void ManagerCrops_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cropsDataSet.Crops' table. You can move, or remove it, as needed.
            this.cropsTableAdapter.Fill(this.cropsDataSet.Crops);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateForm frm2 = new UpdateForm();

            this.Hide();
            frm2.ShowDialog();
            this.Show();
        }
    }
}
