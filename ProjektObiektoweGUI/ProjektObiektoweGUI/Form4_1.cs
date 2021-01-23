using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form4_1 : Form
    {
        public Form4_1(Transakcja trans)
        {
            InitializeComponent();
            label1.Text += String.Format(" TR-{0:D5}", trans.IdTrans);
            label2.Text += trans.Platforma;
            label3.Text += trans.Rodzaj;
            label4.Text += trans.Cena;
            label5.Text += trans.IdTel;
            label6.Text += trans.Data;
            label7.Text += trans.Interesariusz;
            label8.Text += trans.Pracownik;

        }

        private void Form4_1_Load(object sender, EventArgs e)
        {

        }


        /*        private void Form4_1_Load(object sender, EventArgs e)
                {

                }

                private void button1_Click(object sender, EventArgs e)
                {

                }*/
    }
}
