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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void bear_life_table_Click(object sender, EventArgs e)
        {
            Bearing_Life_Distribution_Form generate = new Bearing_Life_Distribution_Form();
            generate.Show();
        }

        private void delay_time_Click(object sender, EventArgs e)
        {
            Delay_Time_Distribution_Form generate = new Delay_Time_Distribution_Form();
            generate.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // send data in main form
            accumulation.get_number_trial_and_hour_number(num_trial.Text, hours_number_value.Text,num_ranges.Text);
            accumulation.get_Bear_values(bearing_cost_value.Text, downtime_cost_value.Text, repair_person_cost_value.Text, cost_repaire1.Text, cost_repaire2.Text, cost_repaire3.Text);
           
            // call function to show output table
            accumulation.current_system();
            accumulation.proposed_system();
        }
    }
}
