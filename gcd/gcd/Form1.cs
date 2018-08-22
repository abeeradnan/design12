using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gcd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            int x = 1;
            while(x!=0)
            {
                x = a % n;
                a = n;
                n = x;

            }
            textBox3.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            for(int i=0;i<n;i++)
            {
                if(a*i%n==1)
                {
                    textBox3.Text = i.ToString();
                }
            }
        }
    }
}
