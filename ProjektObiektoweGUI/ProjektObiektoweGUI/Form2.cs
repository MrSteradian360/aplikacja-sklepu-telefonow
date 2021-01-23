using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Form2 form2 = new Form2();
            form2.Show();*/
            listBox1.Items.Clear();
            MagazynTelefonów.Magazyn.Clear();
            MagazynTelefonów.ListaTel.Clear();
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
            MagazynTelefonów.ListaTel.Clear();
            //listBox1.DataSource = MagazynTelefonów.Magazyn.;
            foreach (Telefon t in MagazynTelefonów.Magazyn)
            {
                listBox1.Items.Add(t);
                MagazynTelefonów.ListaTel.Add(t.ToString());

            }
            /*            foreach (var x in listBox1.Items)
                        {
                            MagazynTelefonów.ListaTel.Add(x.ToString());
                        }*/
            textBox2_Load();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

/*            foreach (string str in MagazynTelefonów.ListaTel)
            {
                if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                {
                    listBox1.Items.Add(str);
                }
                listBox1.Update();
            }*/

            foreach (Telefon t in MagazynTelefonów.Magazyn)
            {
                if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                {
                    listBox1.Items.Add(t);
                    //MagazynTelefonów.ListaTel.Add(t.ToString());
                }
            }
        }

        private void textBox2_Load()
        {
            MagazynTelefonów.LiczbaTel = MagazynTelefonów.ListaTel.Count;
            textBox2.Text = MagazynTelefonów.LiczbaTel.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                //List<string> lista = new List<string>(MagazynTelefonów.ListaTel);
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

                MagazynTelefonów.ListaTel.RemoveAll(x => lista.Contains(x));
                MagazynTelefonów.Magazyn.RemoveAll(x =>
                //lista.Contains(x.Model) && lista.Contains(x.Marka) && lista.Contains(String.Format("T-{0:D5}", x.IdTel)));
                lista.Contains(String.Format("T-{0:D5} {1} {2}", x.IdTel, x.Marka.ToString(), x.Model.ToString())));
/*                foreach (Telefon t in MagazynTelefonów.Magazyn)
                {
                    listBox1.Items.Add(t);
                    //MagazynTelefonów.ListaTel.Add(t.ToString());

                }*/
                //listBox1.Items.Clear();
/*
                foreach (string str in MagazynTelefonów.ListaTel)
                {
                    if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        listBox1.Items.Add(str);
                    }
                    listBox1.Update();
                }*/

                foreach (Telefon t in MagazynTelefonów.Magazyn)
                {
                    if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        listBox1.Items.Add(t);
                        //MagazynTelefonów.ListaTel.Add(t.ToString());
                    }
                    listBox1.Update();
                }
                textBox2_Load();
            }

            else if (!textBox1.Text.Equals("") && !textBox1.Text.Equals(" "))
            {
                listBox1.Items.Clear();

                //List<string> lista = new List<string>(MagazynTelefonów.ListaTel);
                List<string> lista = new List<string>();

                foreach (string str in MagazynTelefonów.ListaTel)
                {
                    if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        lista.Add(str);
                    }
                    //listBox1.Update();
                }

                foreach (Telefon t in MagazynTelefonów.Magazyn)
                {
                    if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        listBox1.Items.Add(t);
                        //MagazynTelefonów.ListaTel.Add(t.ToString());
                    }
                }

                MagazynTelefonów.ListaTel.RemoveAll(x => lista.Contains(x));
                MagazynTelefonów.Magazyn.RemoveAll(x =>
                //lista.Contains(x.Model) && lista.Contains(x.Marka) && lista.Contains(String.Format("T-{0:D5}", x.IdTel)));
                lista.Contains(String.Format("T-{0:D5} {1} {2}", x.IdTel, x.Marka.ToString(), x.Model.ToString())));
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

            /*            foreach (Telefon t in MagazynTelefonów.Magazyn)
                        {
                            if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                            {
                                listBox1.Items.Add(t);
                                MagazynTelefonów.ListaTel.Add(t.ToString());
                            }
                        }*/
            if (listBox1.SelectedItem != null)
            {
                Form2_1 form2_1 = new Form2_1((Telefon)listBox1.SelectedItem);
                form2_1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_2 form2_2 = new Form2_2();
            form2_2.ShowDialog();
            listBox1.Items.Clear();

            MagazynTelefonów.ListaTel.Clear();
            //listBox1.DataSource = MagazynTelefonów.Magazyn.;
            foreach (Telefon t in MagazynTelefonów.Magazyn)
            {
                listBox1.Items.Add(t);
                MagazynTelefonów.ListaTel.Add(t.ToString());

            }
            /*            foreach (var x in listBox1.Items)
                        {
                            MagazynTelefonów.ListaTel.Add(x.ToString());
                        }*/
            textBox2_Load();
        }
    }
}
