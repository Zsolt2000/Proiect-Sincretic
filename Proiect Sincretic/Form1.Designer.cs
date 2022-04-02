namespace Proiect_Sincretic
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_array = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maxvalue = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.chart_bubble = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_shell = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_quick = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_execBubble = new System.Windows.Forms.Label();
            this.lbl_execQuick = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_bubblesort = new System.Windows.Forms.Button();
            this.btn_shellsort = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_array = new System.Windows.Forms.Label();
            this.lbl_time1 = new System.Windows.Forms.Label();
            this.lbl_time2 = new System.Windows.Forms.Label();
            this.lbl_time3 = new System.Windows.Forms.Label();
            this.lbl_test = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bubble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_shell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_quick)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(291, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 332);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(53, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Array size:";
            // 
            // txt_array
            // 
            this.txt_array.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_array.Location = new System.Drawing.Point(150, 129);
            this.txt_array.Name = "txt_array";
            this.txt_array.Size = new System.Drawing.Size(100, 20);
            this.txt_array.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(52, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maximum Value:";
            // 
            // txt_maxvalue
            // 
            this.txt_maxvalue.Location = new System.Drawing.Point(150, 165);
            this.txt_maxvalue.Name = "txt_maxvalue";
            this.txt_maxvalue.Size = new System.Drawing.Size(100, 20);
            this.txt_maxvalue.TabIndex = 5;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(80, 214);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(170, 59);
            this.btn_generate.TabIndex = 6;
            this.btn_generate.Text = "Generate array";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // chart_bubble
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_bubble.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_bubble.Legends.Add(legend1);
            this.chart_bubble.Location = new System.Drawing.Point(342, 181);
            this.chart_bubble.Name = "chart_bubble";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Elements";
            this.chart_bubble.Series.Add(series1);
            this.chart_bubble.Size = new System.Drawing.Size(289, 159);
            this.chart_bubble.TabIndex = 8;
            this.chart_bubble.Text = "chart1";
            // 
            // chart_shell
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_shell.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_shell.Legends.Add(legend2);
            this.chart_shell.Location = new System.Drawing.Point(656, 181);
            this.chart_shell.Name = "chart_shell";
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Elements";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_shell.Series.Add(series2);
            this.chart_shell.Size = new System.Drawing.Size(289, 159);
            this.chart_shell.TabIndex = 9;
            this.chart_shell.Text = "chart2";
            // 
            // chart_quick
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_quick.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_quick.Legends.Add(legend3);
            this.chart_quick.Location = new System.Drawing.Point(951, 181);
            this.chart_quick.Name = "chart_quick";
            series3.ChartArea = "ChartArea1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Elements";
            this.chart_quick.Series.Add(series3);
            this.chart_quick.Size = new System.Drawing.Size(289, 159);
            this.chart_quick.TabIndex = 10;
            this.chart_quick.Text = "chart3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bubblesort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(778, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Shellsort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1076, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quicksort";
            // 
            // lbl_execBubble
            // 
            this.lbl_execBubble.AutoSize = true;
            this.lbl_execBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_execBubble.Location = new System.Drawing.Point(384, 405);
            this.lbl_execBubble.Name = "lbl_execBubble";
            this.lbl_execBubble.Size = new System.Drawing.Size(98, 13);
            this.lbl_execBubble.TabIndex = 14;
            this.lbl_execBubble.Text = "Execution Time:";
            // 
            // lbl_execQuick
            // 
            this.lbl_execQuick.AutoSize = true;
            this.lbl_execQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_execQuick.Location = new System.Drawing.Point(997, 405);
            this.lbl_execQuick.Name = "lbl_execQuick";
            this.lbl_execQuick.Size = new System.Drawing.Size(98, 13);
            this.lbl_execQuick.TabIndex = 18;
            this.lbl_execQuick.Text = "Execution Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(693, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Execution Time:";
            // 
            // btn_bubblesort
            // 
            this.btn_bubblesort.Location = new System.Drawing.Point(438, 358);
            this.btn_bubblesort.Name = "btn_bubblesort";
            this.btn_bubblesort.Size = new System.Drawing.Size(75, 23);
            this.btn_bubblesort.TabIndex = 23;
            this.btn_bubblesort.Text = "Sort";
            this.btn_bubblesort.UseVisualStyleBackColor = true;
            this.btn_bubblesort.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_shellsort
            // 
            this.btn_shellsort.Location = new System.Drawing.Point(750, 358);
            this.btn_shellsort.Name = "btn_shellsort";
            this.btn_shellsort.Size = new System.Drawing.Size(75, 23);
            this.btn_shellsort.TabIndex = 24;
            this.btn_shellsort.Text = "Sort";
            this.btn_shellsort.UseVisualStyleBackColor = true;
            this.btn_shellsort.Click += new System.EventHandler(this.btn_shellsort_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1053, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Sort";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_array
            // 
            this.lbl_array.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_array.Location = new System.Drawing.Point(342, 109);
            this.lbl_array.Name = "lbl_array";
            this.lbl_array.Size = new System.Drawing.Size(900, 15);
            this.lbl_array.TabIndex = 26;
            // 
            // lbl_time1
            // 
            this.lbl_time1.AutoSize = true;
            this.lbl_time1.Location = new System.Drawing.Point(489, 405);
            this.lbl_time1.Name = "lbl_time1";
            this.lbl_time1.Size = new System.Drawing.Size(0, 13);
            this.lbl_time1.TabIndex = 27;
            // 
            // lbl_time2
            // 
            this.lbl_time2.AutoSize = true;
            this.lbl_time2.Location = new System.Drawing.Point(798, 405);
            this.lbl_time2.Name = "lbl_time2";
            this.lbl_time2.Size = new System.Drawing.Size(0, 13);
            this.lbl_time2.TabIndex = 28;
            // 
            // lbl_time3
            // 
            this.lbl_time3.AutoSize = true;
            this.lbl_time3.Location = new System.Drawing.Point(1102, 405);
            this.lbl_time3.Name = "lbl_time3";
            this.lbl_time3.Size = new System.Drawing.Size(0, 13);
            this.lbl_time3.TabIndex = 29;
            // 
            // lbl_test
            // 
            this.lbl_test.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_test.Location = new System.Drawing.Point(341, 129);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(901, 20);
            this.lbl_test.TabIndex = 30;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(696, 483);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(129, 23);
            this.btn_exit.TabIndex = 31;
            this.btn_exit.Text = "Exit Application";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1309, 566);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.lbl_time3);
            this.Controls.Add(this.lbl_time2);
            this.Controls.Add(this.lbl_time1);
            this.Controls.Add(this.lbl_array);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_shellsort);
            this.Controls.Add(this.btn_bubblesort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_execQuick);
            this.Controls.Add(this.lbl_execBubble);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart_quick);
            this.Controls.Add(this.chart_shell);
            this.Controls.Add(this.chart_bubble);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.txt_maxvalue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_array);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_bubble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_shell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_quick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_array;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maxvalue;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_bubble;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_shell;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_quick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_execBubble;
        private System.Windows.Forms.Label lbl_execQuick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_bubblesort;
        private System.Windows.Forms.Button btn_shellsort;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_array;
        private System.Windows.Forms.Label lbl_time1;
        private System.Windows.Forms.Label lbl_time2;
        private System.Windows.Forms.Label lbl_time3;
        private System.Windows.Forms.Label lbl_test;
        private System.Windows.Forms.Button btn_exit;
    }
}

