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
    public partial class Chart : Form
    {

        double[] Frequency;
        public Chart(double[] Result_input ,double minimum , double maximum)
        {
            InitializeComponent();
            Frequency = Result_input; 
            draw();
            min.Text = minimum.ToString();
            max.Text = maximum.ToString();

            
        }

        private void draw()
        {
            for (int i = 0; i < Frequency.Length; ++i)
                chart1.Series["Frequency of cost interval"].Points.AddXY("Interval " + (i + 1).ToString(), Frequency[i]);
            this.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Chart_Load(object sender, EventArgs e)
        {

            
        }
    }
}
