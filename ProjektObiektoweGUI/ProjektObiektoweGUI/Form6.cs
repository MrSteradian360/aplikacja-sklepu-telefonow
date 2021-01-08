using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Form2 form2 = new Form2();
            form2.Show();*/
            listBox1.Items.Clear();
            SpisDostawców.SpisDost.Clear();
            SpisDostawców.ListaDost.Clear();
            textBox2_Load();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form2_3cs form2_3 = new Form2_3cs();
            //form2_3.Show();
            //this.Close();
        }



        //List<string> list = new List<string>();


        private void Form6_Load(object sender, EventArgs e)
        {

            //();

            //items.AddRange(new string[] { "Cat", "Dog", "Carrots", "Brocolli" });

            /*            foreach (string str in lista)
                        {
                            listBox1.Items.Add(str);
                        }*/
            SpisDostawców.ListaDost.Clear();
            //listBox1.DataSource = MagazynTelefonów.Magazyn.;
            foreach (Dostawca t in SpisDostawców.SpisDost)
            {
                listBox1.Items.Add(t);
                SpisDostawców.ListaDost.Add(t.ToString());

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

            foreach (Dostawca t in SpisDostawców.SpisDost)
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
            SpisDostawców.LiczbaDost = SpisDostawców.ListaDost.Count;
            textBox2.Text = SpisDostawców.LiczbaDost.ToString();
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

                SpisDostawców.ListaDost.RemoveAll(x => lista.Contains(x));
                SpisDostawców.SpisDost.RemoveAll(x =>
                //lista.Contains(x.Model) && lista.Contains(x.Marka) && lista.Contains(String.Format("T-{0:D5}", x.IdTel)));
                lista.Contains(String.Format("D-{0:D5} {1} ", x.IdDost, x.Nazwa.ToString())));
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

                foreach (Dostawca t in SpisDostawców.SpisDost)
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

                foreach (string str in SpisDostawców.ListaDost)
                {
                    if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        lista.Add(str);
                    }
                    //listBox1.Update();
                }

                foreach (Dostawca t in SpisDostawców.SpisDost)
                {
                    if (t.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                    {
                        listBox1.Items.Add(t);
                        //MagazynTelefonów.ListaTel.Add(t.ToString());
                    }
                }

                SpisDostawców.ListaDost.RemoveAll(x => lista.Contains(x));
                SpisDostawców.SpisDost.RemoveAll(x =>
                //lista.Contains(x.Model) && lista.Contains(x.Marka) && lista.Contains(String.Format("T-{0:D5}", x.IdTel)));
                lista.Contains(String.Format("D-{0:D5} {1} ", x.IdDost, x.Nazwa.ToString())));
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
                Form6_1 Form6_1 = new Form6_1((Dostawca)listBox1.SelectedItem);
                Form6_1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6_2 Form6_2 = new Form6_2();
            Form6_2.ShowDialog();
            listBox1.Items.Clear();

            SpisDostawców.ListaDost.Clear();
            foreach (Dostawca t in SpisDostawców.SpisDost)
            {
                listBox1.Items.Add(t);
                SpisDostawców.ListaDost.Add(t.ToString());

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
