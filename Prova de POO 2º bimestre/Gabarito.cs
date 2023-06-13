using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_de_POO_2º_bimestre
{
    public partial class Gabarito : Form
    {
        public Gabarito()
        {
            InitializeComponent();
            rt_acerto.Text = "";
        }

        private void acerto_Click(object sender, EventArgs e)
        {
            int acertos = 0;

            string[] gab = { "A","B","D","E","C","A","A","B","E","B"};
            if(txt1.Text == gab[0])
            {
                acertos++;
            }
            else if(txt2.Text == gab[1])
            {
                acertos++;
            }
            else if(txt3.Text == gab[2])
            {
                acertos++;
            }
            else if (txt4.Text == gab[3])
            {
                acertos++;
            }
            else if (txt5.Text == gab[4])
            {
                acertos++;
            }
            else if (txt6.Text == gab[5])
            {
                acertos++;
            }
            else if (txt7.Text == gab[6])
            {
                acertos++;
            }
            else if (txt8.Text == gab[7])
            {
                acertos++;
            }
            else if (txt9.Text == gab[8])
            {
                acertos++;
            }
            else if (txt10.Text == gab[9])
            {
                acertos++;
            }
            
            rt_acerto.Text = Convert.ToString(acertos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int acertos = 0;
            int sm = 0;
            try
            {
                string[] gab = { "A", "B", "D", "E", "C", "A", "A", "B", "E", "B" };
                for (int i = 0; i < gab.Length; i++)
                {
                    if (txt1.Text == gab[0])
                    {
                        acertos++;
                        break;
                    }
                    if (txt2.Text == gab[1])
                    {
                        acertos++;
                        break;
                    }
                    if (txt3.Text == gab[2])
                    {
                        acertos++;
                        break;
                    }
                    if (txt4.Text == gab[3])
                    {
                        acertos++;
                        break;
                    }
                    if (txt5.Text == gab[4])
                    {
                        acertos++;
                        break;
                    }
                    if (txt6.Text == gab[5])
                    {
                        acertos += acertos;
                    }
                    if (txt7.Text == gab[6])
                    {
                        acertos++;
                        break;
                    }
                    if (txt8.Text == gab[7])
                    {
                        acertos++;
                        break;
                    }
                    if (txt9.Text == gab[8])
                    {
                        acertos++;
                        break;
                    }
                    if (txt10.Text == gab[9])
                    {
                        acertos++;
                        break;

                    }

                }
                MessageBox.Show($"{acertos}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Tem que ser letra maiscula");
            }
            

            /*
            else if (txt2.Text == gab[1])
            {
                acertos += acertos;
            }
            else if (txt3.Text == gab[2])
            {
                acertos += acertos;
            }
            else if (txt4.Text == gab[3])
            {
                acertos += acertos;
            }
            else if (txt5.Text == gab[4])
            {
                acertos += acertos; 
            }
            else if (txt6.Text == gab[5])
            {
                acertos += acertos;
            }
            else if (txt7.Text == gab[6])
            {
                acertos += acertos;
            }
            else if (txt8.Text == gab[7])
            {
                acertos += acertos;
            }
            else if (txt9.Text == gab[8])
            {
                acertos += acertos;
            }
            else if (txt10.Text == gab[9])
            {
                acertos += sm;
                MessageBox.Show($"{acertos}");

            }
            */
            //MessageBox.Show($"{acertos}");
        }
    }
}
