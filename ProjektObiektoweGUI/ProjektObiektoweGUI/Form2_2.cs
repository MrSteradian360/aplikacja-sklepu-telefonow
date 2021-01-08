using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form2_2 : Form
    {
        public Form2_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b1 = true, b2 = true, b3 = true, b4 = true, b5 = true, b6 = true;

            //if (radioButton1.Checked) b1 = true;
            if (radioButton2.Checked) b1 = false;
            //if (radioButton13.Checked) b2 = true;
            if (radioButton14.Checked) b2 = false;
            //if (radioButton3.Checked) b3 = true; ;
            if (radioButton4.Checked) b3 = false;
            //if (radioButton5.Checked) b4 = true;
            if (radioButton6.Checked) b4 = false;
            //if (radioButton7.Checked) b5 = true;
            if (radioButton8.Checked) b5 = false;
            //if (radioButton9.Checked) b6 = true;
            if (radioButton10.Checked) b6 = false;

            if (textBox1.Text != "" &&  textBox5.Text != "" && textBox3.Text != "" && 
                textBox4.Text != "" && textBox2.Text != "" && textBox6.Text != "" && 
                (radioButton1.Checked || radioButton2.Checked) && 
                (radioButton13.Checked || radioButton14.Checked) && 
                (radioButton3.Checked || radioButton4.Checked) && 
                (radioButton5.Checked || radioButton6.Checked) && 
                (radioButton7.Checked || radioButton8.Checked) && 
                (radioButton9.Checked || radioButton10.Checked) && 
                textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && 
                textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && 
                textBox19.Text != "" && textBox20.Text != "" && textBox21.Text != "" && 
                textBox22.Text != "" && textBox24.Text != "" && textBox25.Text != "")
            {
                MagazynTelefonów.Magazyn.Add(
                    new Telefon(textBox1.Text, textBox5.Text, textBox3.Text, textBox4.Text, textBox2.Text,
                    textBox6.Text, b1, b2, b3, b4, b5, b6,
                    Decimal.Parse(textBox13.Text), Decimal.Parse(textBox14.Text),
                    Decimal.Parse(textBox15.Text), Decimal.Parse(textBox16.Text),
                    Decimal.Parse(textBox17.Text), Decimal.Parse(textBox18.Text),
                    Convert.ToInt32(textBox19.Text), Convert.ToDouble(textBox20.Text),
                    Convert.ToDouble(textBox21.Text), Convert.ToInt32(textBox22.Text),
                    Convert.ToInt32(textBox24.Text), textBox25.Text));
                this.Close();
            }
            //Form1.Form2x.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_2_Load(object sender, EventArgs e)
        {

        }
    }
}
