using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
       
        
        public Form3()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


       private void button1_Click(object sender, EventArgs e)
        {  string[] textMass;            
            textMass = textBox1.Text.Split(' ');
            textBox3.Text = textMass.Length.ToString();
            textBox2.Text = textBox1.Text.Length.ToString();
       }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
          
           
}
