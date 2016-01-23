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
    public partial class System_Output : Form
    {
        public DataGridView DGV_Current;
        public DataGridView DGV_Proposed;
        public System_Output()
        {
            InitializeComponent();
            DGV_Current = dataGridView1;
            DGV_Proposed = dataGridView2;
        }

        public void set_data_grid_current_DGV(output_result res)
        {

            bearing_cost_value_1.Text = res.All_bears_cost.ToString();

            delay_time_cost_value_1.Text = res.All_delay_time_cost.ToString();

            down_time_cost_value_1.Text = res.All_downtime_cost.ToString();

            repair_person_cost_value_1.Text = res.All_repaire_person_cost.ToString();

            total_cost_1.Text = res.total_cost.ToString();

        }

        public void set_data_grid_propsed_DGV(output_result res)
        {

            bearing_cost_value_2.Text = res.All_bears_cost.ToString();

            delay_time_cost_value_2.Text = res.All_delay_time_cost.ToString();

            down_time_cost_value_2.Text = res.All_downtime_cost.ToString();

            repair_person_cost_value_2.Text = res.All_repaire_person_cost.ToString();

            total_cost_2.Text = res.total_cost.ToString();

        }

        private void System_Output_Load(object sender, EventArgs e)
        {

        }

       
        private void Next_Click(object sender, EventArgs e)
        { 
               accumulation.set_next_trial();  
        }

        private void Previous_Click(object sender, EventArgs e)
        {
           accumulation.set_previos_trial();
        }

      
        private void current_system_chart_Click(object sender, EventArgs e)
        {
            accumulation.draw_chart(1);
        }

        private void proposed_system_chart_Click(object sender, EventArgs e)
        {
            accumulation.draw_chart(2);


        }
    }
}
