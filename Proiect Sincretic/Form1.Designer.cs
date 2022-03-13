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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_array = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maxvalue = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.list_array = new System.Windows.Forms.ListBox();
            this.chart_bubble = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_shell = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_quick = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bubble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_shell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_quick)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(708, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorting Algorithm Performance Analizer";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(251, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 332);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Array size:";
            // 
            // txt_array
            // 
            this.txt_array.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_array.Location = new System.Drawing.Point(110, 163);
            this.txt_array.Name = "txt_array";
            this.txt_array.Size = new System.Drawing.Size(100, 20);
            this.txt_array.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maximum Value:";
            // 
            // txt_maxvalue
            // 
            this.txt_maxvalue.Location = new System.Drawing.Point(110, 199);
            this.txt_maxvalue.Name = "txt_maxvalue";
            this.txt_maxvalue.Size = new System.Drawing.Size(100, 20);
            this.txt_maxvalue.TabIndex = 5;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(40, 248);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(170, 59);
            this.btn_generate.TabIndex = 6;
            this.btn_generate.Text = "Generate array";
            this.btn_generate.UseVisualStyleBackColor = true;
            // 
            // list_array
            // 
            this.list_array.FormattingEnabled = true;
            this.list_array.Location = new System.Drawing.Point(302, 143);
            this.list_array.Name = "list_array";
            this.list_array.Size = new System.Drawing.Size(966, 17);
            this.list_array.TabIndex = 7;
            // 
            // chart_bubble
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_bubble.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_bubble.Legends.Add(legend4);
            this.chart_bubble.Location = new System.Drawing.Point(302, 215);
            this.chart_bubble.Name = "chart_bubble";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_bubble.Series.Add(series4);
            this.chart_bubble.Size = new System.Drawing.Size(289, 159);
            this.chart_bubble.TabIndex = 8;
            this.chart_bubble.Text = "chart1";
            // 
            // chart_shell
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_shell.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_shell.Legends.Add(legend5);
            this.chart_shell.Location = new System.Drawing.Point(607, 215);
            this.chart_shell.Name = "chart_shell";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart_shell.Series.Add(series5);
            this.chart_shell.Size = new System.Drawing.Size(289, 159);
            this.chart_shell.TabIndex = 9;
            this.chart_shell.Text = "chart2";
            // 
            // chart_quick
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_quick.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_quick.Legends.Add(legend6);
            this.chart_quick.Location = new System.Drawing.Point(911, 215);
            this.chart_quick.Name = "chart_quick";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart_quick.Series.Add(series6);
            this.chart_quick.Size = new System.Drawing.Size(289, 159);
            this.chart_quick.TabIndex = 10;
            this.chart_quick.Text = "chart3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bubblesort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(738, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Shellsort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1036, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quicksort";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(321, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Execution Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(623, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Execution Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(945, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Execution Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1309, 566);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart_quick);
            this.Controls.Add(this.chart_shell);
            this.Controls.Add(this.chart_bubble);
            this.Controls.Add(this.list_array);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.txt_maxvalue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_array);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_bubble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_shell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_quick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_array;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maxvalue;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.ListBox list_array;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_bubble;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_shell;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_quick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}

