using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form5_1 : Form
    {
        public Form5_1(Odbiorca odb)
        {
            InitializeComponent();
            label1.Text += String.Format(" O-{0:D5}", odb.IdOdb);
            label2.Text += odb.Nazwa;
            label3.Text += odb.Adres;
            label4.Text += odb.KodPocztowy;
            label5.Text += odb.Miasto;

        }

        private void Form5_1_Load(object sender, EventArgs e)
        {

        }
    }
}
