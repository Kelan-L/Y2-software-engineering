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
    public partial class ManStoragePage : Form
    {
        public ManStoragePage()
        {
            InitializeComponent();
        }

        private void ManStoragePage_Load(object sender, EventArgs e)
        {
            this.storageTableAdapter.Fill(this.manStorageData.Storage);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StorageUpdate storageupdate = new StorageUpdate();

            this.Hide();
            storageupdate.ShowDialog();
            this.Show();
        }
    }
}
