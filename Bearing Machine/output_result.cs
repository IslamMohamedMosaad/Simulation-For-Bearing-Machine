using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bearing_Machine
{
   public class output_result
    {
        public double All_bears_cost;
        public double All_delay_time_cost;
        public double All_downtime_cost;
        public double All_repaire_person_cost;
        public double total_cost;

        public output_result()
        {
            All_bears_cost = 0;
            All_delay_time_cost = 0;
            All_downtime_cost = 0;
            All_repaire_person_cost = 0;
            total_cost = 0;
        }
    }
}
