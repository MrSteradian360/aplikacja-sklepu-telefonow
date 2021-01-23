using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form6_1 : Form
    {
        public Form6_1(Dostawca dost)
        {
            InitializeComponent();
            label1.Text += String.Format(" D-{0:D5}", dost.IdDost);
            label2.Text += dost.Nazwa;
            label3.Text += dost.Adres;
            label4.Text += dost.KodPocztowy;
            label5.Text += dost.Miasto;

        }

        private void Form6_1_Load(object sender, EventArgs e)
        {

        }
    }
}
