using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
namespace Proiect_Sincretic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
            if ((txt_maxvalue.Text == "") || (txt_array.Text == ""))
                MessageBox.Show("Please insert values");
            else
            if (lbl_array.Text != "")
            {
                chart_bubble.Series["Elements"].Points.Clear();
                chart_shell.Series["Elements"].Points.Clear();
                chart_quick.Series["Elements"].Points.Clear();
                chart_generation();

            }
            else
                chart_generation();
        }
        private void chart_generation()
        {
            string array_size = txt_array.Text;
            string max_value=txt_maxvalue.Text;
            string array_label = "";
            Random random = new Random();
            int size = int.Parse(array_size);
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, int.Parse(max_value));
                array_label += arr[i] + " ";
            }
            lbl_array.Text = array_label;
            for (int i = 0; i < arr.Length; i++)
            {
                chart_bubble.Series["Elements"].Points.AddXY(arr[i], arr[i]);
                chart_shell.Series["Elements"].Points.AddXY(arr[i], arr[i]);
                chart_quick.Series["Elements"].Points.AddXY(arr[i], arr[i]);
            }
        }

        private void bubbblesort(int[] arr,int N)
        {
            int i, ok, aux;
            do
            {
                chart_bubble.Series["Elements"].Points.Clear();
                ok = 1;
                for (i = 0; i < N-1; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        ok = 0;
                        aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;                    
                    }
               
                for (i=0;i<N;i++)
              {
                    Application.DoEvents();
                    chart_bubble.Series["Elements"].Points.AddXY(arr[i],arr[i]);                   
              }
                Thread.Sleep(1);
            } while (ok == 0);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string array = lbl_array.Text;
            string[] numbers = array.Split(' ');
            int[] arr = new int[int.Parse(txt_array.Text)];
            for (int i = 0; i < int.Parse(txt_array.Text); i++)
            {
                arr[i]=int.Parse(numbers[i]);
            }
            Stopwatch sw = Stopwatch.StartNew();
            bubbblesort(arr,int.Parse(txt_array.Text));
            sw.Stop();
            lbl_time1.Text = Convert.ToString(sw.Elapsed.TotalMilliseconds);
        }
    }
}
