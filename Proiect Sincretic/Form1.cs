using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string array_size = txt_array.Text;
            string max_value = txt_maxvalue.Text;
            string array_label="";
            Random random = new Random();
            int size = int.Parse(array_size);
            int[] arr = new int[size];
            if ((txt_maxvalue.Text == "") || (txt_array.Text == ""))
                MessageBox.Show("Please insert values");
            else
            {
               
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(0, int.Parse(max_value));
                    array_label +=arr[i] + " ";
                }
                lbl_array.Text = array_label;
            }
            for(int i=0; i < arr.Length; i++)
            {
                chart_bubble.Series["Elements"].Points.AddXY(arr[i], arr[i]);
                chart_shell.Series["Elements"].Points.AddXY(arr[i], arr[i]);
                chart_quick.Series["Elements"].Points.AddXY(arr[i], arr[i]);
            }
        }
        private void fillchart1()
        {
            string size = txt_array.Text;
            string array=lbl_array.Text;
            int[] arr=new int[Convert.ToInt16(size)];
            string[] elements = array.Split(' ');
            foreach(string element in elements)
            {
                chart_bubble.Series["Elements"].Points.AddXY(element, size);
            }
            chart_bubble.Titles.Add("Bubblesort");


        }
    }
}
