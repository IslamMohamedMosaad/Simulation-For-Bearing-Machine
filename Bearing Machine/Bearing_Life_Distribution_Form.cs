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
    public partial class Bearing_Life_Distribution_Form : Form
    {
        public Bearing_Life_Distribution_Form()
        {
            InitializeComponent();
            intialize_Bear_Life_Distribution();
        }

        public void intialize_Bear_Life_Distribution()
        {
            for (int i = 0; i < 10; ++i)
            dataGridView1.Rows.Add();
            


            for (int i = 0; i < 10; ++i) 
                dataGridView1.Rows[i].Cells[0].Value = 1000 + (i * 100); 

            double[] probabilty_bear_life = new double[10] { .1 , .13 , .25, .13 , .09 , .12, .02, .06 , .05 ,.05 };

            for (int i = 0; i < 10; ++i)
                dataGridView1.Rows[i].Cells[1].Value = probabilty_bear_life[i];    
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            accumulation.calc_bear_life_probabilty(dataGridView1);
        }



    }
}
