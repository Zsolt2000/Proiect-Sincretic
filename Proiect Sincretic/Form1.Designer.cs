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
            this.label1 = new System.Windows.Forms.Label();
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
            this.list_Bubble = new System.Windows.Forms.ListBox();
            this.list_Shell = new System.Windows.Forms.ListBox();
            this.list_Quick = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_array = new System.Windows.Forms.Label();
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
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // chart_bubble
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_bubble.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_bubble.Legends.Add(legend1);
            this.chart_bubble.Location = new System.Drawing.Point(302, 215);
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
            this.chart_shell.Location = new System.Drawing.Point(616, 227);
            this.chart_shell.Name = "chart_shell";
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Elements";
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
            this.chart_quick.Location = new System.Drawing.Point(911, 215);
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
            // lbl_execBubble
            // 
            this.lbl_execBubble.AutoSize = true;
            this.lbl_execBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_execBubble.Location = new System.Drawing.Point(344, 439);
            this.lbl_execBubble.Name = "lbl_execBubble";
            this.lbl_execBubble.Size = new System.Drawing.Size(98, 13);
            this.lbl_execBubble.TabIndex = 14;
            this.lbl_execBubble.Text = "Execution Time:";
            // 
            // lbl_execQuick
            // 
            this.lbl_execQuick.AutoSize = true;
            this.lbl_execQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_execQuick.Location = new System.Drawing.Point(957, 439);
            this.lbl_execQuick.Name = "lbl_execQuick";
            this.lbl_execQuick.Size = new System.Drawing.Size(98, 13);
            this.lbl_execQuick.TabIndex = 18;
            this.lbl_execQuick.Text = "Execution Time:";
            // 
            // list_Bubble
            // 
            this.list_Bubble.BackColor = System.Drawing.SystemColors.MenuBar;
            this.list_Bubble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_Bubble.FormattingEnabled = true;
            this.list_Bubble.Location = new System.Drawing.Point(448, 439);
            this.list_Bubble.Name = "list_Bubble";
            this.list_Bubble.Size = new System.Drawing.Size(92, 13);
            this.list_Bubble.TabIndex = 19;
            // 
            // list_Shell
            // 
            this.list_Shell.BackColor = System.Drawing.SystemColors.MenuBar;
            this.list_Shell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_Shell.FormattingEnabled = true;
            this.list_Shell.Location = new System.Drawing.Point(757, 439);
            this.list_Shell.Name = "list_Shell";
            this.list_Shell.Size = new System.Drawing.Size(92, 13);
            this.list_Shell.TabIndex = 20;
            // 
            // list_Quick
            // 
            this.list_Quick.BackColor = System.Drawing.SystemColors.MenuBar;
            this.list_Quick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_Quick.FormattingEnabled = true;
            this.list_Quick.Location = new System.Drawing.Point(1061, 439);
            this.list_Quick.Name = "list_Quick";
            this.list_Quick.Size = new System.Drawing.Size(92, 13);
            this.list_Quick.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(653, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Execution Time:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1013, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Sort";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbl_array
            // 
            this.lbl_array.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_array.Location = new System.Drawing.Point(302, 143);
            this.lbl_array.Name = "lbl_array";
            this.lbl_array.Size = new System.Drawing.Size(900, 15);
            this.lbl_array.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1309, 566);
            this.Controls.Add(this.lbl_array);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.list_Quick);
            this.Controls.Add(this.list_Shell);
            this.Controls.Add(this.list_Bubble);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_bubble;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_shell;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_quick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_execBubble;
        private System.Windows.Forms.Label lbl_execQuick;
        private System.Windows.Forms.ListBox list_Bubble;
        private System.Windows.Forms.ListBox list_Shell;
        private System.Windows.Forms.ListBox list_Quick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_array;
    }
}

