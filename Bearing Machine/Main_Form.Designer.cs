namespace Bearing_Machine
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bear_life_table = new System.Windows.Forms.Button();
            this.delay_time = new System.Windows.Forms.Button();
            this.bearing_cost = new System.Windows.Forms.Label();
            this.bearing_cost_value = new System.Windows.Forms.TextBox();
            this.downtime_cost = new System.Windows.Forms.Label();
            this.downtime_cost_value = new System.Windows.Forms.TextBox();
            this.hours_number = new System.Windows.Forms.Label();
            this.hours_number_value = new System.Windows.Forms.TextBox();
            this.repair_person_cost = new System.Windows.Forms.Label();
            this.repair_person_cost_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cost_repaire1 = new System.Windows.Forms.TextBox();
            this.cost_repaire2 = new System.Windows.Forms.TextBox();
            this.cost_repaire3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.num_trial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num_ranges = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bear_life_table
            // 
            this.bear_life_table.Location = new System.Drawing.Point(16, 15);
            this.bear_life_table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bear_life_table.Name = "bear_life_table";
            this.bear_life_table.Size = new System.Drawing.Size(145, 63);
            this.bear_life_table.TabIndex = 0;
            this.bear_life_table.Text = "Bearing_Life_Table";
            this.bear_life_table.UseVisualStyleBackColor = true;
            this.bear_life_table.Click += new System.EventHandler(this.bear_life_table_Click);
            // 
            // delay_time
            // 
            this.delay_time.Location = new System.Drawing.Point(181, 16);
            this.delay_time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delay_time.Name = "delay_time";
            this.delay_time.Size = new System.Drawing.Size(139, 62);
            this.delay_time.TabIndex = 1;
            this.delay_time.Text = "Delay_Time_Table";
            this.delay_time.UseVisualStyleBackColor = true;
            this.delay_time.Click += new System.EventHandler(this.delay_time_Click);
            // 
            // bearing_cost
            // 
            this.bearing_cost.AutoSize = true;
            this.bearing_cost.Location = new System.Drawing.Point(12, 95);
            this.bearing_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bearing_cost.Name = "bearing_cost";
            this.bearing_cost.Size = new System.Drawing.Size(86, 17);
            this.bearing_cost.TabIndex = 4;
            this.bearing_cost.Text = "bearing cost";
            // 
            // bearing_cost_value
            // 
            this.bearing_cost_value.Location = new System.Drawing.Point(151, 95);
            this.bearing_cost_value.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bearing_cost_value.Name = "bearing_cost_value";
            this.bearing_cost_value.Size = new System.Drawing.Size(63, 22);
            this.bearing_cost_value.TabIndex = 5;
            this.bearing_cost_value.Text = "32";
            // 
            // downtime_cost
            // 
            this.downtime_cost.AutoSize = true;
            this.downtime_cost.Location = new System.Drawing.Point(12, 146);
            this.downtime_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downtime_cost.Name = "downtime_cost";
            this.downtime_cost.Size = new System.Drawing.Size(101, 17);
            this.downtime_cost.TabIndex = 6;
            this.downtime_cost.Text = "downtime_cost";
            // 
            // downtime_cost_value
            // 
            this.downtime_cost_value.Location = new System.Drawing.Point(151, 146);
            this.downtime_cost_value.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downtime_cost_value.Name = "downtime_cost_value";
            this.downtime_cost_value.Size = new System.Drawing.Size(63, 22);
            this.downtime_cost_value.TabIndex = 7;
            this.downtime_cost_value.Text = "10";
            // 
            // hours_number
            // 
            this.hours_number.AutoSize = true;
            this.hours_number.Location = new System.Drawing.Point(12, 201);
            this.hours_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hours_number.Name = "hours_number";
            this.hours_number.Size = new System.Drawing.Size(100, 17);
            this.hours_number.TabIndex = 8;
            this.hours_number.Text = "hours_number";
            // 
            // hours_number_value
            // 
            this.hours_number_value.Location = new System.Drawing.Point(151, 201);
            this.hours_number_value.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hours_number_value.Name = "hours_number_value";
            this.hours_number_value.Size = new System.Drawing.Size(63, 22);
            this.hours_number_value.TabIndex = 9;
            this.hours_number_value.Text = "20000";
            // 
            // repair_person_cost
            // 
            this.repair_person_cost.AutoSize = true;
            this.repair_person_cost.Location = new System.Drawing.Point(315, 98);
            this.repair_person_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.repair_person_cost.Name = "repair_person_cost";
            this.repair_person_cost.Size = new System.Drawing.Size(131, 17);
            this.repair_person_cost.TabIndex = 10;
            this.repair_person_cost.Text = "repaire person cost";
            // 
            // repair_person_cost_value
            // 
            this.repair_person_cost_value.Location = new System.Drawing.Point(485, 95);
            this.repair_person_cost_value.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.repair_person_cost_value.Name = "repair_person_cost_value";
            this.repair_person_cost_value.Size = new System.Drawing.Size(63, 22);
            this.repair_person_cost_value.TabIndex = 11;
            this.repair_person_cost_value.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "repaire 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "repaire one";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "repaire 2";
            // 
            // cost_repaire1
            // 
            this.cost_repaire1.Location = new System.Drawing.Point(348, 192);
            this.cost_repaire1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cost_repaire1.Name = "cost_repaire1";
            this.cost_repaire1.Size = new System.Drawing.Size(63, 22);
            this.cost_repaire1.TabIndex = 15;
            this.cost_repaire1.Text = "20";
            // 
            // cost_repaire2
            // 
            this.cost_repaire2.Location = new System.Drawing.Point(464, 192);
            this.cost_repaire2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cost_repaire2.Name = "cost_repaire2";
            this.cost_repaire2.Size = new System.Drawing.Size(63, 22);
            this.cost_repaire2.TabIndex = 16;
            this.cost_repaire2.Text = "30";
            // 
            // cost_repaire3
            // 
            this.cost_repaire3.Location = new System.Drawing.Point(585, 192);
            this.cost_repaire3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cost_repaire3.Name = "cost_repaire3";
            this.cost_repaire3.Size = new System.Drawing.Size(63, 22);
            this.cost_repaire3.TabIndex = 17;
            this.cost_repaire3.Text = "40";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Bearing Replacement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "number_trial";
            // 
            // num_trial
            // 
            this.num_trial.Location = new System.Drawing.Point(151, 257);
            this.num_trial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_trial.Name = "num_trial";
            this.num_trial.Size = new System.Drawing.Size(73, 22);
            this.num_trial.TabIndex = 20;
            this.num_trial.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "number_ranges";
            // 
            // num_ranges
            // 
            this.num_ranges.Location = new System.Drawing.Point(485, 256);
            this.num_ranges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_ranges.Name = "num_ranges";
            this.num_ranges.Size = new System.Drawing.Size(132, 22);
            this.num_ranges.TabIndex = 23;
            this.num_ranges.Text = "5";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 449);
            this.Controls.Add(this.num_ranges);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.num_trial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cost_repaire3);
            this.Controls.Add(this.cost_repaire2);
            this.Controls.Add(this.cost_repaire1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repair_person_cost_value);
            this.Controls.Add(this.repair_person_cost);
            this.Controls.Add(this.hours_number_value);
            this.Controls.Add(this.hours_number);
            this.Controls.Add(this.downtime_cost_value);
            this.Controls.Add(this.downtime_cost);
            this.Controls.Add(this.bearing_cost_value);
            this.Controls.Add(this.bearing_cost);
            this.Controls.Add(this.delay_time);
            this.Controls.Add(this.bear_life_table);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bear_life_table;
        private System.Windows.Forms.Button delay_time;
        private System.Windows.Forms.Label bearing_cost;
        private System.Windows.Forms.TextBox bearing_cost_value;
        private System.Windows.Forms.Label downtime_cost;
        private System.Windows.Forms.TextBox downtime_cost_value;
        private System.Windows.Forms.Label hours_number;
        private System.Windows.Forms.TextBox hours_number_value;
        private System.Windows.Forms.Label repair_person_cost;
        private System.Windows.Forms.TextBox repair_person_cost_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cost_repaire1;
        private System.Windows.Forms.TextBox cost_repaire2;
        private System.Windows.Forms.TextBox cost_repaire3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_trial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox num_ranges;
    }
}

