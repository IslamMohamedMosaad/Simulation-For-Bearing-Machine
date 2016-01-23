namespace Bearing_Machine
{
    partial class Delay_Time_Distribution_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delay_Time_minute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cumulative_Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random_Digit_Assignment_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random_Digit_Assignment_End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delay_Time_minute,
            this.Probability,
            this.Cumulative_Probability,
            this.Random_Digit_Assignment_Start,
            this.Random_Digit_Assignment_End});
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Delay_Time_minute
            // 
            this.Delay_Time_minute.HeaderText = "Delay Time (minute)";
            this.Delay_Time_minute.Name = "Delay_Time_minute";
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            // 
            // Cumulative_Probability
            // 
            this.Cumulative_Probability.HeaderText = "Cumulative Probability";
            this.Cumulative_Probability.Name = "Cumulative_Probability";
            // 
            // Random_Digit_Assignment_Start
            // 
            this.Random_Digit_Assignment_Start.HeaderText = "Random Digit Assignment Start";
            this.Random_Digit_Assignment_Start.Name = "Random_Digit_Assignment_Start";
            // 
            // Random_Digit_Assignment_End
            // 
            this.Random_Digit_Assignment_End.HeaderText = "Random Digit Assignment End";
            this.Random_Digit_Assignment_End.Name = "Random_Digit_Assignment_End";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(403, 280);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 47);
            this.calc.TabIndex = 1;
            this.calc.Text = "process";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // Delay_Time_Distribution_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 368);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Delay_Time_Distribution_Form";
            this.Text = "Delay_Time_Distribution_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay_Time_minute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cumulative_Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random_Digit_Assignment_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random_Digit_Assignment_End;
        private System.Windows.Forms.Button calc;
    }
}