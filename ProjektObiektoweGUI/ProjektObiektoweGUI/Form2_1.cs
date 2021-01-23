using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form2_1 : Form
    {
        public Form2_1(Telefon tel)
        {
            InitializeComponent();
            label1.Text += String.Format(" T-{0:D5}",tel.IdTel);
            label2.Text += tel.Marka;
            label3.Text += tel.Model;
            label4.Text += tel.Szybkieładowanie;
            label5.Text += tel.Wodoodp;
            label6.Text += tel.System;
            label7.Text += tel.Procesor;
            if(tel.Sieć4G == true) label8.Text += "Tak";
            else label8.Text += "Nie";
            if (tel.Sieć5G == true) label9.Text += "Tak";
            else label9.Text += "Nie";
            if (tel.Dotykowy == true) label10.Text += "Tak";
            else label10.Text += "Nie";
            if (tel.Indukcyjne == true) label11.Text += "Tak";
            else label11.Text += "Nie";
            if (tel.DualSIM == true) label12.Text += "Tak";
            else label12.Text += "Nie";
            if (tel.NFC == true) label13.Text += "Tak";
            else label13.Text += "Nie";
            //label9.Text += tel.Sieć5G;
            //label10.Text += tel.Dotykowy;
            //label11.Text += tel.Indukcyjne;
            //label12.Text += tel.DualSIM;
            //label13.Text += tel.NFC;
            label14.Text += tel.Wysokość;
            label15.Text += tel.Szerokość;
            label16.Text += tel.Grubość;
            label17.Text += tel.Przekątna;
            label18.Text += tel.Waga;
            label19.Text += tel.CenaDetal;
            label20.Text += tel.Bateria;
            label21.Text += tel.RAM;
            label22.Text += tel.ROM;
            label23.Text += tel.LiczbaAparatów;
            label24.Text += tel.GłównyAparat;
            label25.Text += tel.Bluetooth;
            
        }

        private void Form2_1_Load(object sender, EventArgs e)
        {

        }


        /*        private void Form2_1_Load(object sender, EventArgs e)
                {

                }

                private void button1_Click(object sender, EventArgs e)
                {

                }*/
    }
}
