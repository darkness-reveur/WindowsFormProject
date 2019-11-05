namespace CourseWork
{
    partial class Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.TextBox();
            this.CalculationError = new System.Windows.Forms.TextBox();
            this.Friction = new System.Windows.Forms.TextBox();
            this.Angle = new System.Windows.Forms.TextBox();
            this.StepLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(2, 82);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(797, 356);
            this.chart.TabIndex = 0;
            this.chart.Text = "graph";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Построить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(104, 37);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(59, 22);
            this.Step.TabIndex = 4;
            this.Step.Text = "0,5";
            // 
            // CalculationError
            // 
            this.CalculationError.Location = new System.Drawing.Point(274, 37);
            this.CalculationError.Name = "CalculationError";
            this.CalculationError.Size = new System.Drawing.Size(59, 22);
            this.CalculationError.TabIndex = 6;
            this.CalculationError.Text = "0,05";
            // 
            // Friction
            // 
            this.Friction.Location = new System.Drawing.Point(436, 37);
            this.Friction.Name = "Friction";
            this.Friction.Size = new System.Drawing.Size(59, 22);
            this.Friction.TabIndex = 7;
            this.Friction.Text = "0,6";
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(599, 37);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(59, 22);
            this.Angle.TabIndex = 8;
            this.Angle.Text = "55";
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Location = new System.Drawing.Point(12, 25);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(87, 34);
            this.StepLabel.TabIndex = 10;
            this.StepLabel.Text = "Первый шаг\r\nграфика:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Погрешность\r\nвычислений:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Коэфициент\r\nтрения μ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Угол\r\nнаклона, °:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 15;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.Friction);
            this.Controls.Add(this.CalculationError);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart);
            this.Name = "Graph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Step;
        private System.Windows.Forms.TextBox CalculationError;
        private System.Windows.Forms.TextBox Friction;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}