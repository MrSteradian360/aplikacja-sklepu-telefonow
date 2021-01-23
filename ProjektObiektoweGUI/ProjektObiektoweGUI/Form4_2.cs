using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form4_2 : Form
    {
        public Form4_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox6.Text !="" && textBox7.Text != ""  
                && textBox1.Text != "" && textBox3.Text != "" 
                && textBox2.Text != "" && textBox4.Text != ""
                && textBox5.Text != "" && decimal.TryParse(textBox1.Text, out _) && DateTime.TryParse(textBox2.Text, out _))
            {
                SpisTransakcji.SpisTrans.Add(
                    new Transakcja(textBox6.Text, textBox7.Text,
                    Decimal.Parse(textBox1.Text), textBox3.Text,
                    textBox2.Text, textBox4.Text, textBox5.Text));
                this.Close();
            }
            //Form1.Form2x.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
