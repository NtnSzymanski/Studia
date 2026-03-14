using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ProgramowanieSystemowSterowaniaWMechatronice
{
    public partial class Zadanie2 : Form
    {
        double  stan, b;
        enum operacja {Dodawanie,Odejmowanie,Mnozenie,Dzielenie};
        operacja Operacja;


        public Zadanie2()
        {
            InitializeComponent();
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "=";
            button11.Text = "clr";
            button12.Text = "0";
            toolStripMenuItem1.Text = "Operacje";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            b = 1;

        }






             

        private void button10_Click(object sender, EventArgs e)
        {
            switch (Operacja)
            {
                case operacja.Dodawanie:
                    stan += b;
                    break;
                case operacja.Odejmowanie:
                    stan -= b;
                    break;
                case operacja.Mnozenie:
                    stan *= b;
                    break;
                case operacja.Dzielenie:
                    if (b != 0)
                        stan /= b;
                    else
                        MessageBox.Show("Nie można dzielić przez zero!");
                    break;



            }
            maskedTextBox1.Text = stan.ToString();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            stan = 0;
            maskedTextBox1.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b = 7;
            maskedTextBox1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            b = 8;
            maskedTextBox1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            b = 9;
            maskedTextBox1.Text = "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b = 4;
            maskedTextBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b = 5;
            maskedTextBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b = 6;
            maskedTextBox1.Text = "6";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            b = 3;
            maskedTextBox1.Text = "3";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            b = 2;
            maskedTextBox1.Text = "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b = 0;
            maskedTextBox1.Text = "0";
        }

        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacja = operacja.Odejmowanie;
        }

        private void mnożenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacja = operacja.Mnozenie;
        }

        private void dzielenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacja = operacja.Dzielenie;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dodawanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacja = operacja.Dodawanie;
        }
    }
}
