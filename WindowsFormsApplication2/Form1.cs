using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            
            Equation equation = new Equation(a, b, c);

        
            if (b < 0 && c > 0) label5.Text = a + "X² - " + -b + "x + " + c + " = 0 " + "\n"
                                     + " x₁ = " + equation.getX1() + "\n" 
                                     + " x₂ = " + equation.getX2();
            else if (c < 0 && b > 0) label5.Text = a + "X² + " + b + "x - " + -c + " = 0 " + "\n"
                                     + " x₁ = " + equation.getX1() + "\n" 
                                     + " x₂ = " + equation.getX2();
            else if (b < 0 && c < 0) label5.Text = a + "X² - " + -b + "x - " + -c + " = 0 " + "\n"
                                              + " x₁ = " + equation.getX1() + "\n" 
                                              + " x₂ = " + equation.getX2();
            else  label5.Text = a + "X² + " + b + "x + " + c + " = 0 " + "\n"
                                                   + " x₁ = " + equation.getX1() + "\n" 
                                                   + " x₂ = " + equation.getX2();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Википедия");
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
