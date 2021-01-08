using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Form2 form2 = new Form2();
            form2.Show();*/
            listBox1.Items.Clear();
            SpisPracowników.Spis.Clear();
            SpisPracowników.ListaPrac.Clear();
            textBox2_Load();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form2_3cs form2_3 = new Form2_3cs();
            //form2_3.Show();
            //this.Close();
        }



        //List<string> list = new List<string>();


        private void Form2_Load(object sender, EventArgs e)
        {

            //();

            //items.AddRange(new string[] { "Cat", "Dog", "Carrots", "Brocolli" });

            /*            foreach (string str in lista)
                        {
                            listBox1.Items.Add(str);
                        }*/
            SpisPracowników.ListaPrac.Clear();
            //listBox1.DataSource = SpisPracowników.Spis.;
            foreach (Pracownik t in SpisPracowników.Spis)
            {
                listBox1.Items.Add(t);
                SpisPracowników.ListaPrac.Add(t.ToString());

            }
            /*            foreach (var x in listBox1.Items)
                        {
                            SpisPracowników.ListaPrac.Add(x.ToString());
                        }*/
            textBox2_Load();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            /*            foreach (string str in SpisPracowników.ListaPrac)
                        {
                            if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                            {
                                listBox1.Items.Add(str);
                            }
                            listBox1.Update();
                        }*/

            foreach (Pracownik t in SpisPracowników.Spis)
            {
                if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                {
                    listBox1.Items.Add(t);
                    //SpisPracowników.ListaPrac.Add(t.ToString());
                }
            }
        }

        private void textBox2_Load()
        {
            SpisPracowników.LiczbaPrac = SpisPracowników.ListaPrac.Count;
            textBox2.Text = SpisPracowników.LiczbaPrac.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                //List<string> lista = new List<string>(SpisPracowników.ListaPrac);
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

                SpisPracowników.ListaPrac.RemoveAll(x => lista.Contains(x));
                SpisPracowników.Spis.RemoveAll(x =>
                //lista.Contains(x.Model) && lista.Contains(x.Marka) && lista.Contains(String.Format("T-{0:D5}", x.IdTel)));
                lista.Contains(String.Format("P-{0:D5} {1}", x.IdPrac, x.Nazwa)));
                /*                foreach (Pracownik t in SpisPracowników.Spis)
                                {
                                    listBox1.Items.Add(t);
                                    //SpisPracowników.ListaPrac.Add(t.ToString());

                                }*/
                //listBox1.Items.Clear();
                /*
                                foreach (string str in SpisPracowników.ListaPrac)
                                {
                                    if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                                    {
                                        listBox1.Items.Add(str);
                                    }
                                    listBox1.Update();
                                }*/

                foreach (Pracownik t in SpisPracowników.Spis)
                {
                    if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        listBox1.Items.Add(t);
                        //SpisPracowników.ListaPrac.Add(t.ToString());
                    }
                    listBox1.Update();
                }
                textBox2_Load();
            }

            else if (!textBox1.Text.Equals("") && !textBox1.Text.Equals(" "))
            {
                listBox1.Items.Clear();

                //List<string> lista = new List<string>(SpisPracowników.ListaPrac);
                List<string> lista = new List<string>();

                foreach (string str in SpisPracowników.ListaPrac)
                {
                    if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        lista.Add(str);
                    }
                    //listBox1.Update();
                }

                foreach (Pracownik t in SpisPracowników.Spis)
                {
                    if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        listBox1.Items.Add(t);
                        //SpisPracowników.ListaPrac.Add(t.ToString());
                    }
                }

                SpisPracowników.ListaPrac.RemoveAll(x => lista.Contains(x));
                SpisPracowników.Spis.RemoveAll(x =>
                //lista.Contains(x.Model) && lista.Contains(x.Marka) && lista.Contains(String.Format("T-{0:D5}", x.IdTel)));
                lista.Contains(String.Format("P-{0:D5} {1}", x.IdPrac, x.Nazwa)));
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

            /*            foreach (Pracownik t in SpisPracowników.Spis)
                        {
                            if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                            {
                                listBox1.Items.Add(t);
                                SpisPracowników.ListaPrac.Add(t.ToString());
                            }
                        }*/
            if (listBox1.SelectedItem != null)
            {
                Form3_1 form3_1 = new Form3_1((Pracownik)listBox1.SelectedItem);
                form3_1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3_2 form3_2 = new Form3_2();
            form3_2.ShowDialog();
            listBox1.Items.Clear();

            SpisPracowników.ListaPrac.Clear();
            //listBox1.DataSource = SpisPracowników.Spis.;
            foreach (Pracownik t in SpisPracowników.Spis)
            {
                listBox1.Items.Add(t);
                SpisPracowników.ListaPrac.Add(t.ToString());

            }
            /*            foreach (var x in listBox1.Items)
                        {
                            SpisPracowników.ListaPrac.Add(x.ToString());
                        }*/
            textBox2_Load();
        }
    }
}

