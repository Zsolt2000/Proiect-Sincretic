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

        //Function that generates the charts
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
        //Function that generates the array with random values
        private void chart_generation()
        {
            string array_size = txt_array.Text;
            string max_value = txt_maxvalue.Text;
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

        //Function for the Bubblesort algorithm
        private void bubbblesort(int[] arr, int N)
        {
            int i, ok, aux;
            do
            {
                chart_bubble.Series["Elements"].Points.Clear();
                ok = 1;
                for (i = 0; i < N - 1; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        ok = 0;
                        aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                    }

                for (i = 0; i < N; i++)
                {
                    Application.DoEvents();
                    chart_bubble.Series["Elements"].Points.AddXY(arr[i], arr[i]);
                }
                Thread.Sleep(1);
            } while (ok == 0);
        }

        //Function for the Shellsort algorithm
        private void shellsort(int[] arr, int N)
        {

            for (int gap = N / 2; gap > 0; gap /= 2)
            {
                chart_shell.Series["Elements"].Points.Clear();
                for (int i = gap; i < N; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];
                    arr[j] = temp;
                  
                }  for (int m = 0; m < arr.Length; m++)
                    {
                        Application.DoEvents();
                        chart_shell.Series["Elements"].Points.AddXY(arr[m], arr[m]);
                    }
                Thread.Sleep(1);
            }
        }
       
        //Function for swapping 2 values needed for Quicksort
        private void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        //Function for determining the partition needed for Quicksort
        private int partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j <= right - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }

            }
            swap(arr, i + 1, right);
            return (i + 1);
        }



        //Function for the Quicksort algorithm
        private void quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                chart_quick.Series["Elements"].Points.Clear();
                int pivot = partition(arr, left, right);
                for (int i = 0; i < arr.Length; i++)
                {
                    Application.DoEvents();
                    chart_quick.Series["Elements"].Points.AddXY(arr[i], arr[i]);
                }
                Thread.Sleep(1);
                quicksort(arr, left, pivot - 1);
                quicksort(arr, pivot + 1, right);
            }
        }
        //Function that sorts the array with the Bubblesort algorithm
        private void button1_Click(object sender, EventArgs e)
        {
            lbl_test.Text = "";
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
            for (int i = 0; i < arr.Length; i++)
                lbl_test.Text =lbl_test.Text+ Convert.ToString(arr[i]) + " ";  
            lbl_time1.Text = Convert.ToString(sw.Elapsed.TotalMilliseconds);
        }

        //Function that sorts the array with the Shellsort algorithm
        private void btn_shellsort_Click(object sender, EventArgs e)
        {
            lbl_test.Text = "";
            string array = lbl_array.Text;
            string[] numbers = array.Split(' ');
            int[] arr = new int[int.Parse(txt_array.Text)];
            for (int i = 0; i < int.Parse(txt_array.Text); i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }
            Stopwatch sw = Stopwatch.StartNew();
           shellsort(arr, int.Parse(txt_array.Text));
            sw.Stop();
            for (int i = 0; i < arr.Length; i++)
                lbl_test.Text = lbl_test.Text + Convert.ToString(arr[i]) + " ";
            lbl_time2.Text = Convert.ToString(sw.Elapsed.TotalMilliseconds);
        }

        //Function that sorts the array with the Quicksort algorithm
        private void button3_Click(object sender, EventArgs e)
        {
            lbl_test.Text = "";
            string array = lbl_array.Text;
            string[] numbers = array.Split(' ');
            int[] arr = new int[int.Parse(txt_array.Text)];
            for (int i = 0; i < int.Parse(txt_array.Text); i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }
            Stopwatch sw = Stopwatch.StartNew();
            quicksort(arr,0,arr.Length-1);
            sw.Stop();
            for (int i = 0; i < arr.Length; i++)
                lbl_test.Text = lbl_test.Text + Convert.ToString(arr[i]) + " ";
            lbl_time3.Text = Convert.ToString(sw.Elapsed.TotalMilliseconds);
        }
        //Function that exits the application
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
