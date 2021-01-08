using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Form2 form2 = new Form2();
            form2.Show();*/
            listBox1.Items.Clear();
            SpisOdbiorców.SpisOdb.Clear();
            SpisOdbiorców.ListaOdb.Clear();
            textBox2_Load();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form2_3cs form2_3 = new Form2_3cs();
            //form2_3.Show();
            //this.Close();
        }



        //List<string> list = new List<string>();


        private void Form5_Load(object sender, EventArgs e)
        {

            //();

            //items.AddRange(new string[] { "Cat", "Dog", "Carrots", "Brocolli" });

            /*            foreach (string str in lista)
                        {
                            listBox1.Items.Add(str);
                        }*/
            SpisOdbiorców.ListaOdb.Clear();
            //listBox1.DataSource = MagazynTelefonów.Magazyn.;
            foreach (Odbiorca t in SpisOdbiorców.SpisOdb)
            {
                listBox1.Items.Add(t);
                SpisOdbiorców.ListaOdb.Add(t.ToString());

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

            foreach (Odbiorca t in SpisOdbiorców.SpisOdb)
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
            SpisOdbiorców.LiczbaOdb = SpisOdbiorców.ListaOdb.Count;
            textBox2.Text = SpisOdbiorców.LiczbaOdb.ToString();
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

                SpisOdbiorców.ListaOdb.RemoveAll(x => lista.Contains(x));
                SpisOdbiorców.SpisOdb.RemoveAll(x =>
                //lista.Contains(x.Model) && lista.Contains(x.Marka) && lista.Contains(String.Format("T-{0:D5}", x.IdTel)));
                lista.Contains(String.Format("O-{0:D5} {1} ", x.IdOdb, x.Nazwa.ToString())));
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

                foreach (Odbiorca t in SpisOdbiorców.SpisOdb)
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

                foreach (string str in SpisOdbiorców.ListaOdb)
                {
                    if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        lista.Add(str);
                    }
                    //listBox1.Update();
                }

                foreach (Odbiorca t in SpisOdbiorców.SpisOdb)
                {
                    if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        listBox1.Items.Add(t);
                        //MagazynTelefonów.ListaTel.Add(t.ToString());
                    }
                }

                SpisOdbiorców.ListaOdb.RemoveAll(x => lista.Contains(x));
                SpisOdbiorców.SpisOdb.RemoveAll(x =>
                //lista.Contains(x.Model) && lista.Contains(x.Marka) && lista.Contains(String.Format("T-{0:D5}", x.IdTel)));
                lista.Contains(String.Format("O-{0:D5} {1} ", x.IdOdb, x.Nazwa.ToString())));
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
                Form5_1 form5_1 = new Form5_1((Odbiorca)listBox1.SelectedItem);
                form5_1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5_2 form5_2 = new Form5_2();
            form5_2.ShowDialog();
            listBox1.Items.Clear();

            SpisOdbiorców.ListaOdb.Clear();
            foreach (Odbiorca t in SpisOdbiorców.SpisOdb)
            {
                listBox1.Items.Add(t);
                SpisOdbiorców.ListaOdb.Add(t.ToString());

            }
            /*            foreach (var x in listBox1.Items)
                        {
                            MagazynTelefonów.ListaTel.Add(x.ToString());
                        }*/
            textBox2_Load();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
