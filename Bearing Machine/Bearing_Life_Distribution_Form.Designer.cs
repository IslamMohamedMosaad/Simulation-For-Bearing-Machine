namespace Bearing_Machine
{
    partial class Bearing_Life_Distribution_Form
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
            this.calculate = new System.Windows.Forms.Button();
            this.Bearing_life = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cumulative_Probabilty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random_Digit_Assignment_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random_Digit_Assignment_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bearing_life,
            this.Probabilty,
            this.Cumulative_Probabilty,
            this.Random_Digit_Assignment_start,
            this.Random_Digit_Assignment_end});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(623, 215);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 47);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "process";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Bearing_life
            // 
            this.Bearing_life.HeaderText = "Bearing Life (hours)";
            this.Bearing_life.Name = "Bearing_life";
            // 
            // Probabilty
            // 
            this.Probabilty.HeaderText = "Probabilty";
            this.Probabilty.Name = "Probabilty";
            // 
            // Cumulative_Probabilty
            // 
            this.Cumulative_Probabilty.HeaderText = "Cumulative Probabilty";
            this.Cumulative_Probabilty.Name = "Cumulative_Probabilty";
            // 
            // Random_Digit_Assignment_start
            // 
            this.Random_Digit_Assignment_start.HeaderText = "Random Digit Assignment start";
            this.Random_Digit_Assignment_start.Name = "Random_Digit_Assignment_start";
            // 
            // Random_Digit_Assignment_end
            // 
            this.Random_Digit_Assignment_end.HeaderText = "Random Digit Assignment End";
            this.Random_Digit_Assignment_end.Name = "Random_Digit_Assignment_end";
            // 
            // Bearing_Life_Distribution_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 513);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bearing_Life_Distribution_Form";
            this.Text = "Bearing_Life_Distribution_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bearing_life;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cumulative_Probabilty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random_Digit_Assignment_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random_Digit_Assignment_end;
    }
}