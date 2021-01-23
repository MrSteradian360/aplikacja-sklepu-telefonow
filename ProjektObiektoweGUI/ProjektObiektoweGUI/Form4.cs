using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Form4 Form4 = new Form4();
            Form4.Show();*/
            listBox1.Items.Clear();
            SpisTransakcji.SpisTrans.Clear();
            SpisTransakcji.ListaTrans.Clear();
            textBox2_Load();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form4_3cs Form4_3 = new Form4_3cs();
            //Form4_3.Show();
            //this.Close();
        }



        //List<string> list = new List<string>();


        private void Form4_Load(object sender, EventArgs e)
        {

            //();

            //items.AddRange(new string[] { "Cat", "Dog", "Carrots", "Brocolli" });

            /*            foreach (string str in lista)
                        {
                            listBox1.Items.Add(str);
                        }*/
            SpisTransakcji.ListaTrans.Clear();
            //listBox1.DataSource = SpisTransakcji.SpisTrans.;
            foreach (Transakcja t in SpisTransakcji.SpisTrans)
            {
                listBox1.Items.Add(t);
                SpisTransakcji.ListaTrans.Add(t.ToString());

            }
            /*            foreach (var x in listBox1.Items)
                        {
                            SpisTransakcji.ListaTrans.Add(x.ToString());
                        }*/
            textBox2_Load();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            /*            foreach (string str in SpisTransakcji.ListaTrans)
                        {
                            if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                            {
                                listBox1.Items.Add(str);
                            }
                            listBox1.Update();
                        }*/

            foreach (Transakcja t in SpisTransakcji.SpisTrans)
            {
                if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                {
                    listBox1.Items.Add(t);
                    //SpisTransakcji.ListaTrans.Add(t.ToString());
                }
            }
        }

        private void textBox2_Load()
        {
            SpisTransakcji.LiczbaTrans = SpisTransakcji.ListaTrans.Count;
            textBox2.Text = SpisTransakcji.LiczbaTrans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                //List<string> lista = new List<string>(SpisTransakcji.ListaTrans);
                List<string> lista = new List<string>();
                List<string> lista1 = new List<string>();

                foreach (object o in listBox1.Items)
                {
                    lista1.Add(o.ToString());
                }

                foreach (string str in lista1)
                {
                    if (str.Equals(listBox1.SelectedItem.ToString()))
                    {
                        lista.Add(str);
                    }
                }

                listBox1.Items.Clear();

                SpisTransakcji.ListaTrans.RemoveAll(x => lista.Contains(x));
                SpisTransakcji.SpisTrans.RemoveAll(x =>
                //lista.Contains(x.Model) && lista.Contains(x.Marka) && lista.Contains(String.Format("T-{0:D5}", x.IdTel)));
                lista.Contains(String.Format("TR-{0:D5} {1} {2} {3}", x.IdTrans, x.Data.ToString(), x.IdTel.ToString(), x.Cena.ToString())));
                /*                foreach (Transakcja t in SpisTransakcji.SpisTrans)
                                {
                                    listBox1.Items.Add(t);
                                    //SpisTransakcji.ListaTrans.Add(t.ToString());

                                }*/
                //listBox1.Items.Clear();
                /*
                                foreach (string str in SpisTransakcji.ListaTrans)
                                {
                                    if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                                    {
                                        listBox1.Items.Add(str);
                                    }
                                    listBox1.Update();
                                }*/

                foreach (Transakcja t in SpisTransakcji.SpisTrans)
                {
                    if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        listBox1.Items.Add(t);
                        //SpisTransakcji.ListaTrans.Add(t.ToString());
                    }
                    listBox1.Update();
                }
                textBox2_Load();
            }

            else if (!textBox1.Text.Equals("") && !textBox1.Text.Equals(" "))
            {
                listBox1.Items.Clear();

                //List<string> lista = new List<string>(SpisTransakcji.ListaTrans);
                List<string> lista = new List<string>();

                foreach (string str in SpisTransakcji.ListaTrans)
                {
                    if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        lista.Add(str);
                    }
                    //listBox1.Update();
                }

                foreach (Transakcja t in SpisTransakcji.SpisTrans)
                {
                    if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        listBox1.Items.Add(t);
                        //SpisTransakcji.ListaTrans.Add(t.ToString());
                    }
                }

                SpisTransakcji.ListaTrans.RemoveAll(x => lista.Contains(x));
                SpisTransakcji.SpisTrans.RemoveAll(x =>
                //lista.Contains(x.Model) && lista.Contains(x.Marka) && lista.Contains(String.Format("T-{0:D5}", x.IdTel)));
                lista.Contains(String.Format("TR-{0:D5} {1} {2} {3}", x.IdTrans, x.Data.ToString(), x.IdTel.ToString(), x.Cena.ToString())));
                textBox2_Load();
                listBox1.Items.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //zmienic typ listy

            /*            foreach (Transakcja t in SpisTransakcji.SpisTrans)
                        {
                            if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                            {
                                listBox1.Items.Add(t);
                                SpisTransakcji.ListaTrans.Add(t.ToString());
                            }
                        }*/
            if (listBox1.SelectedItem != null)
            {
                Form4_1 Form4_1 = new Form4_1((Transakcja)listBox1.SelectedItem);
                Form4_1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4_2 Form4_2 = new Form4_2();
            Form4_2.ShowDialog();
            listBox1.Items.Clear();

            SpisTransakcji.ListaTrans.Clear();
            //listBox1.DataSource = SpisTransakcji.SpisTrans.;
            foreach (Transakcja t in SpisTransakcji.SpisTrans)
            {
                listBox1.Items.Add(t);
                SpisTransakcji.ListaTrans.Add(t.ToString());

            }
            /*            foreach (var x in listBox1.Items)
                        {
                            SpisTransakcji.ListaTrans.Add(x.ToString());
                        }*/
            textBox2_Load();
        }
    }
}
