using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_LP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Q = new int[20];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                Q[i] = rand.Next(1, 20);
                listBox1.Items.Add("Q[" + (i+1).ToString() + "] = " + Q[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < 20; i++) 
                if(Q[i]%7==1 || Q[i] % 7 == 2 || Q[i] % 7 == 5)
                listBox2.Items.Add("Q[" + (i + 1).ToString() + "] = " + Q[i].ToString());
        }
    }
}

