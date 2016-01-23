using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;



namespace Bearing_Machine
{
    class accumulation
    {

        public static Random rand;
        public static Distribution[] beerProb;
        public static Distribution[] delayProb;
        public static Life_Beer_Method_one[,] Beer_Life;
        public static Bear_Propreties bear_propreties;
        public static System_Output[] obj;
        public static double[] all_costs;
        public static double[] frequency_current;
        public static double[] frequency_proposed;
        public static double[] ranges_value;
        public static Chart chart;
        public static int bear_one_delay;
        public static int bear_two_delay;
        public static int bear_three_delay;
        public static int delay;
        public static double min_cost_current = 1000000000, max_cost_current=-1;
        public static double min_cost_proposed = 1000000000, max_cost_proposed = -1;
        public static int num_trial, hour_num , num_ranges;
        public static int now_terial=0;




        // Function related of Generate random number
        /////////////////////////////////////////////

        // intializtion for random object
        public static void intialize_random()
        {
            rand = new Random();
        } 

        //return random number like that => " 0.any_digit "
        public static double randomize()
        {

            return rand.NextDouble();
        }

        // return random number with two digit
        public static int generate_random_value_two_digit()
        {
            double rand = randomize() * 100;
            int cast_random = Convert.ToInt32(rand);
            if (cast_random == 0)
                cast_random++;

            return cast_random;
        }


        // return random number with one digit
        public static int generate_random_value_one_digit()
        {
            double rand = randomize() * 10;
            int cast_random = Convert.ToInt32(rand);
            if (cast_random == 0)
                cast_random++;

            return cast_random;
        }

        ////////////////////////////////////////////////////////////////////////////////////

        //Get inputs from Main Form 
        ////////////////////////////

        // get number of trial , system hour time and number of ranges from Main form
        public static void get_number_trial_and_hour_number(string number_trial, string hour_number , string number_ranges)
        {
            num_trial = Convert.ToInt32(number_trial);
            hour_num = Convert.ToInt32(hour_number);
            num_ranges = Convert.ToInt32(number_ranges);
        }


        // get Bear properties from Main form
        public static void get_Bear_values(string Bear_cost, string Downtime_cost, string Repaire_Person_cost, string Repaire_time_one, string Repaire_time_two ,string Repaire_time_three)
        {
            bear_propreties = new Bear_Propreties();
            bear_propreties.Bear_cost = Convert.ToDouble(Bear_cost);
            bear_propreties.Downtime_cost = Convert.ToDouble(Downtime_cost);
            bear_propreties.Repaire_Person_cost = Convert.ToDouble(Repaire_Person_cost);
            bear_propreties.Repaire_time_one = Convert.ToDouble(Repaire_time_one);
            bear_propreties.Repaire_time_two = Convert.ToDouble(Repaire_time_two);
            bear_propreties.Repaire_time_three = Convert.ToDouble(Repaire_time_three);


        }
        
        //////////////////////////////////////////////////////////////////////////////////////

        // calculate frequency
        public static void calculate_frequency(double range , double[] freq , double min_cost )
    {
         for (int i = 0; i < num_ranges; i++)
            {
                if (i == 0)  
                    ranges_value[0] =  Math.Round((range / num_ranges) + min_cost); 
                else
                    ranges_value[i] =Math.Round(ranges_value[i]+ ranges_value[i - 1] + (range / num_ranges));
            }
         ranges_value[num_ranges - 1]+=50;
            for (int i = 0; i < num_trial; i++)
            {
                for (int j = 0; j < num_ranges; j++)
                {
                    if (all_costs[i] <= ranges_value[j])
                    {
                        freq[j]++;
                        break;
                    }
                }
            }
    }

        // check if probabilty cell is missen
        public static bool check(int i, int j, System.Windows.Forms.DataGridView DGV)
        {

            if (DGV.Rows[i].Cells[j].Value != null)
                return true;

            return false;
        }


        // calculation of Bearing life Distribution
        public static void calc_bear_life_probabilty(System.Windows.Forms.DataGridView DGV)
        {
            
            int probabilty_num=DGV.Rows.Count-1;
             beerProb = new Distribution[probabilty_num];
            for (int i = 0; i < probabilty_num; ++i)
            {
                beerProb[i] = new Distribution();
                beerProb[i].realvalue = DGV.Rows[i].Cells[0].Value.ToString();

                if (check(i, 1, DGV) == true)
                    beerProb[i].Probability = double.Parse(DGV.Rows[i].Cells[1].Value.ToString());
                else
                    beerProb[i].Probability = 0;

            } 
            Distribution.getDistributionTabel(beerProb, probabilty_num);

            for (int i = 0; i < probabilty_num; ++i)
            {

                double temp = Math.Round(beerProb[i].CumulativeProbability,2);

                    DGV.Rows[i].Cells[2].Value = beerProb[i].CumulativeProbability;
                    DGV.Rows[i].Cells[3].Value = beerProb[i].start *= 100 ;
                    DGV.Rows[i].Cells[4].Value = beerProb[i].end *= 100 ;

                   

                    beerProb[i].start =Convert.ToInt32( beerProb[i].start);
                    beerProb[i].end = Convert.ToInt32(beerProb[i].end);
                
               
            }
            
        }
      
      
        // calculation of Delay Time Distribution
        public static void calc_delay_time(System.Windows.Forms.DataGridView DGV)
        {

            int probabilty_num = DGV.Rows.Count - 1;
            delayProb = new Distribution[probabilty_num];
            for (int i = 0; i < probabilty_num; ++i)
            {
                delayProb[i] = new Distribution();
                delayProb[i].realvalue = DGV.Rows[i].Cells[0].Value.ToString();
                if (check(i, 1, DGV) == true)
                    delayProb[i].Probability = double.Parse(DGV.Rows[i].Cells[1].Value.ToString());
                else
                    delayProb[i].Probability = 0;

            }
            Distribution.getDistributionTabel(delayProb, probabilty_num);

            for (int i = 0; i < probabilty_num; ++i)
            {

                DGV.Rows[i].Cells[2].Value = delayProb[i].CumulativeProbability /= 10;
                DGV.Rows[i].Cells[3].Value = delayProb[i].start;
                DGV.Rows[i].Cells[4].Value = delayProb[i].end;
                
            }

        }
        

        // Helper function in current system 
        public static bool three_beer(int num_object_now , int cnt, int i, int j, int k, int l, int m)
        {

            if (cnt - 1 >= 0 && Convert.ToDouble(obj[num_object_now].DGV_Current.Rows[cnt - 1].Cells[k].Value) >= hour_num)
                return true;

            double rand=randomize()*100;           
            int cast_random = Convert.ToInt32(rand);
            if (cast_random == 0)
                cast_random++;

            obj[num_object_now].DGV_Current.Rows[cnt].Cells[i].Value = cast_random;
            obj[num_object_now].DGV_Current.Rows[cnt].Cells[j].Value = Distribution.get_life_hour(cast_random, beerProb);



            if (cnt > 0)
            {
                double ee = Convert.ToDouble(obj[num_object_now].DGV_Current.Rows[cnt].Cells[j].Value);
                double ff = Convert.ToDouble(obj[num_object_now].DGV_Current.Rows[cnt - 1].Cells[k].Value);
                obj[num_object_now].DGV_Current.Rows[cnt].Cells[k].Value = ee + ff;
            }
            else
                obj[num_object_now].DGV_Current.Rows[cnt].Cells[k].Value = obj[num_object_now].DGV_Current.Rows[cnt].Cells[j].Value;

            rand = randomize() * 10;
            cast_random = Convert.ToInt32(rand);
            if (cast_random == 0)
                cast_random++;

            obj[num_object_now].DGV_Current.Rows[cnt].Cells[l].Value = cast_random;
            obj[num_object_now].DGV_Current.Rows[cnt].Cells[m].Value = Distribution.get_delay_minute(cast_random, delayProb);




            if (i == 1)
            {
                bear_one_delay+=Convert.ToInt32( obj[num_object_now].DGV_Current.Rows[cnt].Cells[m].Value);
                Beer_Life[num_object_now,cnt].beer_one = Convert.ToString(obj[num_object_now].DGV_Current.Rows[cnt].Cells[j].Value);
            }
            else if (i == 6)
            {
                bear_two_delay+=Convert.ToInt32(obj[num_object_now].DGV_Current.Rows[cnt].Cells[m].Value);
                Beer_Life[num_object_now,cnt].beer_two = Convert.ToString(obj[num_object_now].DGV_Current.Rows[cnt].Cells[j].Value);
            }
            else
            {
                bear_three_delay += Convert.ToInt32(obj[num_object_now].DGV_Current.Rows[cnt].Cells[m].Value);
                Beer_Life[num_object_now,cnt].beer_three = Convert.ToString(obj[num_object_now].DGV_Current.Rows[cnt].Cells[j].Value);
            }
            
            

            return false;
        }

        //calculation of current system
        public static void current_system()
        {
            min_cost_current = 1000000;
            max_cost_current = -1;

            all_costs= new double[num_trial];

            int sze =  hour_num / int.Parse(beerProb[0].realvalue);
            if (sze == 0)
                sze = 1000;
            Beer_Life = new Life_Beer_Method_one[num_trial , sze];

            obj = new System_Output[num_trial];

            output_result temp = new output_result();
            int cnt ,num_used_bear;
            bool one, two, three;
            intialize_random();
            for (int i = 0; i < num_trial; ++i)
            {
                 cnt = 0;
                one = two = three = false;
                num_used_bear = bear_one_delay = bear_two_delay = bear_three_delay = 0;

                obj[i] = new System_Output();

                while (true)
                {
                    Beer_Life[i,cnt] = new Life_Beer_Method_one();
                    

                    obj[i].DGV_Current.Rows.Add();
                    obj[i].DGV_Current.Rows[cnt].Cells[0].Value = cnt + 1;

                    if (one == false)
                    {
                        ++num_used_bear;
                        one = three_beer(i, cnt, 1, 2, 3, 4, 5);
                    }
                    if (two == false)
                    {
                        ++num_used_bear;
                        two = three_beer(i, cnt, 6, 7, 8, 9, 10);
                    }
                    if (three == false)
                    {
                        ++num_used_bear;
                        three = three_beer(i, cnt, 11, 12, 13, 14, 15);
                    }
                    if (one == true && two == true && three == true)
                        break;
                    ++cnt;
                }
                num_used_bear -= 3;

                temp.All_bears_cost = num_used_bear * bear_propreties.Bear_cost;
                temp.All_delay_time_cost = (bear_one_delay + bear_two_delay + bear_three_delay) * bear_propreties.Downtime_cost;
                temp.All_downtime_cost = bear_propreties.Repaire_time_one * bear_propreties.Downtime_cost * num_used_bear;
                temp.All_repaire_person_cost = num_used_bear * bear_propreties.Repaire_time_one * (bear_propreties.Repaire_Person_cost) / 60;
                temp.total_cost = temp.All_bears_cost + temp.All_delay_time_cost + temp.All_downtime_cost + temp.All_repaire_person_cost;
                all_costs[i] = temp.total_cost;
                min_cost_current = Math.Min(all_costs[i], min_cost_current);
                max_cost_current = Math.Max(all_costs[i], max_cost_current);
                obj[i].set_data_grid_current_DGV(temp);
            }




            double range = max_cost_current - min_cost_current;
            frequency_current = new double[num_ranges];
            ranges_value = new double[num_ranges];

            calculate_frequency(range, frequency_current, min_cost_current);

        }


        //calculation of proposed system
        public static void proposed_system()
        {
            min_cost_proposed = 1000000;
            max_cost_proposed = -1;
            all_costs = new double[num_trial];
            output_result temp = new output_result();
            int cnt;
           // intialize_random();

            for (int i = 0; i < num_trial; ++i)
            {
                cnt = 0;
                delay = 0;

                while (true)
                {
                    if (cnt > 0 && Convert.ToUInt32(obj[i].DGV_Proposed.Rows[cnt - 1].Cells[5].Value) >= hour_num)
                        break;

                    obj[i].DGV_Proposed.Rows.Add();
                    obj[i].DGV_Proposed.Rows[cnt].Cells[0].Value = cnt + 1;


                    if (Beer_Life[i,cnt] == null || Beer_Life[i,cnt].beer_one == null)
                        obj[i].DGV_Proposed.Rows[cnt].Cells[1].Value = Distribution.get_life_hour(generate_random_value_two_digit(), beerProb);

                    else
                        obj[i].DGV_Proposed.Rows[cnt].Cells[1].Value = Beer_Life[i,cnt].beer_one;



                    if (Beer_Life[i,cnt] == null || Beer_Life[i,cnt].beer_two == null)
                        obj[i].DGV_Proposed.Rows[cnt].Cells[2].Value = Distribution.get_life_hour(generate_random_value_two_digit(), beerProb);

                    else
                        obj[i].DGV_Proposed.Rows[cnt].Cells[2].Value = Beer_Life[i,cnt].beer_two;




                    if (Beer_Life[i,cnt] == null || Beer_Life[i,cnt].beer_three == null)
                        obj[i].DGV_Proposed.Rows[cnt].Cells[3].Value = Distribution.get_life_hour(generate_random_value_two_digit(), beerProb);

                    else
                        obj[i].DGV_Proposed.Rows[cnt].Cells[3].Value = Beer_Life[i,cnt].beer_three;




                    obj[i].DGV_Proposed.Rows[cnt].Cells[4].Value = Math.Min(Math.Min(Convert.ToUInt32(obj[i].DGV_Proposed.Rows[cnt].Cells[1].Value), Convert.ToUInt32(obj[i].DGV_Proposed.Rows[cnt].Cells[2].Value)), Convert.ToUInt32(obj[i].DGV_Proposed.Rows[cnt].Cells[3].Value));

                    if (cnt == 0)
                        obj[i].DGV_Proposed.Rows[cnt].Cells[5].Value = obj[i].DGV_Proposed.Rows[cnt].Cells[4].Value;
                    else
                        obj[i].DGV_Proposed.Rows[cnt].Cells[5].Value = Convert.ToUInt32(obj[i].DGV_Proposed.Rows[cnt].Cells[4].Value) + Convert.ToUInt32(obj[i].DGV_Proposed.Rows[cnt - 1].Cells[5].Value);

                    obj[i].DGV_Proposed.Rows[cnt].Cells[6].Value = generate_random_value_one_digit();

                    obj[i].DGV_Proposed.Rows[cnt].Cells[7].Value = Distribution.get_delay_minute(Convert.ToUInt32(obj[i].DGV_Proposed.Rows[cnt].Cells[6].Value), delayProb);
                    delay += Convert.ToInt32(obj[i].DGV_Proposed.Rows[cnt].Cells[7].Value);

                    ++cnt;
                }
                temp.All_bears_cost = cnt * 3 * bear_propreties.Bear_cost;
                temp.All_delay_time_cost = (delay) * bear_propreties.Downtime_cost;
                temp.All_downtime_cost = bear_propreties.Repaire_time_three * bear_propreties.Downtime_cost * cnt;
                temp.All_repaire_person_cost = cnt * bear_propreties.Repaire_time_three * (bear_propreties.Repaire_Person_cost) / 60;
                temp.total_cost = temp.All_bears_cost + temp.All_delay_time_cost + temp.All_downtime_cost + temp.All_repaire_person_cost;

                all_costs[i] = temp.total_cost;
                min_cost_proposed = Math.Min(all_costs[i], min_cost_proposed);
                max_cost_proposed = Math.Max(all_costs[i], max_cost_proposed);

                obj[i].set_data_grid_propsed_DGV(temp);
            }



            double range = max_cost_proposed - min_cost_proposed;
            frequency_proposed = new double[num_ranges];
            ranges_value = new double[num_ranges];

            calculate_frequency(range, frequency_proposed, min_cost_proposed);
           

            obj[0].Show();
        }

        // controller of next and previos Button 
        /////////////////////////////////////////

        //set Next trial in DGV
        public static void set_next_trial()
        {
           
           
            obj[now_terial].Hide();
            ++now_terial;
            obj[now_terial].Show();

            if (now_terial == num_trial - 1)
              obj[now_terial].Next.Enabled = false;
            
            else
                obj[now_terial].Next.Enabled = true;
           

        }

        //set Previos trial in DGV
        public static void set_previos_trial()
        {
            obj[now_terial].Hide();
            --now_terial;
            obj[now_terial].Show();


            if (now_terial == 0 )
                obj[now_terial].Previous.Enabled = false;  
       
            else
                obj[now_terial].Previous.Enabled = true;
        }
        
       /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      
        // draw chart for current or proposed 
        public static void draw_chart(int n)
        {
            if(n==1)
                chart = new Chart(frequency_current, min_cost_current, max_cost_current);
            else
                chart = new Chart(frequency_proposed, min_cost_proposed, max_cost_proposed);
                  
        }
    
    
    
    }
}
