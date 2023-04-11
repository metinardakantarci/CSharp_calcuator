using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sayiBir = Convert.ToInt32(textBox1.Text);
            int sayiIki = Convert.ToInt32(textBox2.Text);

            int sonuc = sayiBir + sayiIki;

            textBox3.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayiBir = Convert.ToInt32(textBox1.Text);
            int sayiIki = Convert.ToInt32(textBox2.Text);

            int sonuc = sayiBir - sayiIki;


            textBox3.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayiBir = Convert.ToInt32(textBox1.Text);
            int sayiIki = Convert.ToInt32(textBox2.Text);

            int sonuc = sayiBir * sayiIki;

            textBox3.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayiBir = Convert.ToInt32(textBox1.Text);
            int sayiIki = Convert.ToInt32(textBox2.Text);

            int sonuc = sayiBir / sayiIki;

            textBox3.Text = sonuc.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
