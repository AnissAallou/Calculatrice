using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string bufferChiffre1;
        string bufferChiffre2;
        double reponse;
        double bufferChiffreString;
        string operateur;
        double convertChiffre1;
        double convertChiffre2;
        double memoireMPlus = 0;
        
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += ", ";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            bufferChiffre1 = textBox1.Text;
            textBox2.Text = bufferChiffre1;
            operateur = "+";
            textBox1.Text += " + ";
            textBox2.Text += " + ";
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {

            bufferChiffre1 = textBox1.Text;
            textBox2.Text = bufferChiffre1;
            operateur = "/";
            textBox1.Text += " / ";
            textBox2.Text += " / ";
            textBox1.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            bufferChiffre1 = textBox1.Text;
            textBox2.Text = bufferChiffre1;
            operateur = "*";
            textBox1.Text += " * ";
            textBox2.Text += " * ";
            textBox1.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            bufferChiffre1 = textBox1.Text;
            textBox2.Text = bufferChiffre1;
            operateur = "-";
            textBox1.Text += " - ";
            textBox2.Text += " - ";
            textBox1.Clear();
        }
        private void button28_Click(object sender, EventArgs e)
        {
            bufferChiffre1 = textBox1.Text;
            textBox2.Text = bufferChiffre1;
            operateur = "%";
            textBox1.Text += " % ";
            textBox2.Text += " % ";
            textBox1.Clear();
        }
        private void button27_Click(object sender, EventArgs e)
        {
            operateur = "1/x";

            textBox2.Text = "reciproc(" + textBox1.Text + ")";

        }
        private void button9_Click(object sender, EventArgs e)
        {
            operateur = "±";
            try
            {
                reponse = Convert.ToDouble(textBox1.Text);
                reponse = reponse - (2 * reponse);
                bufferChiffre1 = Convert.ToString(reponse);
                textBox1.Text = bufferChiffre1;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Veuillez indiquez un chiffre avant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            operateur = "√";
            try
            {
                bufferChiffre1 = textBox1.Text;
                bufferChiffreString = Convert.ToDouble(bufferChiffre1);
                reponse = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                textBox2.Text = "√" + textBox1.Text;
                textBox1.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Veuillez indiquez un chiffre avant", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (operateur == "+")
            {
                bufferChiffre2 = textBox1.Text;
                textBox2.Text += bufferChiffre2 + " = ";
                convertChiffre1 = Convert.ToDouble(bufferChiffre1);
                convertChiffre2 = Convert.ToDouble(bufferChiffre2);
                reponse = convertChiffre1 + convertChiffre2;
                textBox2.Text += reponse;
                textBox1.Text = Convert.ToString(reponse);                
                convertChiffre1 = reponse;
                
            }
            else if (operateur == "√")
            {
                textBox2.Text = "√" + bufferChiffre1 + " = " + reponse;
                textBox1.Clear();
                
            }
            else if (operateur == "1/x")
            {
                try
                {
                    reponse = Convert.ToDouble(textBox1.Text);
                    reponse = 1 / reponse;
                    textBox2.Text = "reciproc(" + textBox1.Text + ") = " + reponse;
                   
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Avant de faire égale, entrez un calcul", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (operateur == "*")
            {
                bufferChiffre2 = textBox1.Text;
                textBox2.Text += bufferChiffre2 + " = ";
                convertChiffre1 = Convert.ToDouble(bufferChiffre1);
                convertChiffre2 = Convert.ToDouble(bufferChiffre2);
                reponse = convertChiffre1 * convertChiffre2;
                textBox2.Text += reponse;
                textBox1.Text = Convert.ToString(reponse);
                convertChiffre1 = reponse;
                
            }
            else if (operateur == "/")
            {
                bufferChiffre2 = textBox1.Text;
                textBox2.Text += bufferChiffre2 + " = ";
                convertChiffre1 = Convert.ToDouble(bufferChiffre1);
                convertChiffre2 = Convert.ToDouble(bufferChiffre2);
                
                
            }
            else if (operateur == "%")
            {
                bufferChiffre2 = textBox1.Text;
                textBox2.Text += bufferChiffre2 + " = ";
                convertChiffre1 = Convert.ToDouble(bufferChiffre1);
                convertChiffre2 = Convert.ToDouble(bufferChiffre2);
                reponse = convertChiffre1 % convertChiffre2;
                textBox2.Text += reponse;
                textBox1.Text = Convert.ToString(reponse);
                convertChiffre1 = reponse;
                
            }

            else if (operateur == "-")
            {
                bufferChiffre2 = textBox1.Text;
                textBox2.Text += bufferChiffre2 + " = ";
                convertChiffre1 = Convert.ToDouble(bufferChiffre1);
                convertChiffre2 = Convert.ToDouble(bufferChiffre2);
                reponse = convertChiffre1 - convertChiffre2;
                textBox2.Text += reponse;
                textBox1.Text = Convert.ToString(reponse);
                convertChiffre1 = reponse;

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }


        















    }
}
