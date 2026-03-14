using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ProgramowanieSystemowSterowaniaWMechatronice
{
    public partial class Zadanie1 : Form
    {
        

        public Zadanie1()
        {
            InitializeComponent();
            button1.Text = "Aktywny";
            button2.Text = "Tekst";
            button2.Enabled = false;
            button3.Text = "Nie Aktywny";
            button3.Enabled = false;
            label1.Text = "Cw1";
            textBox1.Text = "Cw1";
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
           label1.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
