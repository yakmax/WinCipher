using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox03.Text = Encoder.Code(textBox02.Text);
            textBox04.Text = Encoder.Crypt(textBox02.Text, textBox01.Text);
            textBox05.Text = Encoder.Crypt(Encoder.Crypt(textBox02.Text, textBox01.Text), textBox01.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox01.Text = "И поэтому все так произошло.";
            textBox02.Text = "Три герлицы под виндом пряли поздним ивнингом...";
        }

        private void textBox01_TextChanged(object sender, EventArgs e)
        {
            textBox03.Text = Encoder.Code(textBox02.Text);
            textBox04.Text = Encoder.Crypt(textBox02.Text, textBox01.Text); 
            textBox05.Text = Encoder.Crypt(Encoder.Crypt(textBox02.Text, textBox01.Text), textBox01.Text);
        }

        private void textBox03_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
