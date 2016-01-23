using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bearing_Machine
{
    public partial class Delay_Time_Distribution_Form : Form
    {
        public Delay_Time_Distribution_Form()
        {
            InitializeComponent();
            Intialize_Delay_Time();
        }


        public void Intialize_Delay_Time()
        {
            for (int i = 0; i < 3; ++i)
                dataGridView1.Rows.Add();

            for (int i = 0; i < 3; ++i)
                dataGridView1.Rows[i].Cells[0].Value = 5 + i*5;

            dataGridView1.Rows[0].Cells[1].Value = .6;
            dataGridView1.Rows[1].Cells[1].Value = .3;
            dataGridView1.Rows[2].Cells[1].Value = .1;

               
        }
        private void calc_Click(object sender, EventArgs e)
        {
             accumulation.calc_delay_time(dataGridView1);
        }
    }
}
