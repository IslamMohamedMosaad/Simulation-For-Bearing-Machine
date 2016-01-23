using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bearing_Machine
{
    class Distribution
    {

        public string realvalue;
        public double Probability;
        public double CumulativeProbability;
        public double start;
        public double end;

        
        
        // calculate distribution variable
        public static void getDistributionTabel(Distribution[] distTemp, int num_probabilty)
        {
            double starting = 0, ending = 0;

            for (int i = 0; i < num_probabilty; ++i)
            {
                if(num_probabilty==10)
                    ending += distTemp[i].Probability;
                else
                    ending += distTemp[i].Probability *10;

                distTemp[i].end = distTemp[i].CumulativeProbability = ending;

                if(num_probabilty==10)
                    distTemp[i].start = (double)starting + .01;
                else
                    distTemp[i].start = (double)starting + 1;

                starting = ending;
            }
        }

        // return realvalue of probabilty that random int its range
        public static string get_life_hour(double Random_num, Distribution[] table)
        {
            for (int i = 0; i < 10; i++)
            {
                if (Random_num >= table[i].start && Random_num <= table[i].end )
                    return table[i].realvalue;
            }

            return "";
        }

        // return realvalue of probabilty that random int its range
        public static string get_delay_minute(double Random_num, Distribution[] table)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Random_num >= table[i].start && Random_num <= table[i].end )
                    return table[i].realvalue;
            }

            return "";
        }
    }
}
