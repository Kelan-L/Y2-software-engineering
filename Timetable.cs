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
    public partial class Timetable : Form
    {

        public Timetable()
        {
            InitializeComponent();

   
        }

        private void Timetable_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.MinDate = new DateTime(2018, 12, 1);
            dateTimePicker1.MaxDate = new DateTime(2018, 12, 30);
  
           
            MessageBox.Show("The Day of the week is " + dateTimePicker1.ToString());
            
              

        }
    }
}
