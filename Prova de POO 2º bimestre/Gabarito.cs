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
            rt.Text = "";
        }

        private void acerto_Click(object sender, EventArgs e)
        {
            
        }

        private void Novo()
        {
           
            
            int acertos = 0;
            
            try
            {
                //Atualização para enviar para o gitHub
                string[] gab = { "A", "B", "D", "E", "C", "A", "A", "D", "E", "B" };
                for (int i = 0; i < gab.Length; i++)
                {
                    acertos = 0;
                    if (txt1.Text.ToUpper() == gab[0])
                    {
                        acertos++;

                    }
                    if (txt2.Text.ToUpper() == gab[1])
                    {
                        acertos++;

                    }

                    if (txt3.Text.ToUpper() == gab[2])
                    {
                        acertos++;
                    }

                    if (txt4.Text.ToUpper() == gab[3])
                    {
                        acertos++;

                    }
                    if (txt5.Text.ToUpper() == gab[4])
                    {
                        acertos++;

                    }
                    if (txt6.Text.ToUpper() == gab[5])
                    {
                        acertos++;

                    }
                    if (txt7.Text.ToUpper() == gab[6])
                    {
                        acertos++;

                    }
                    if (txt8.Text.ToUpper() == gab[7])
                    {
                        acertos++;

                    }
                    if (txt9.Text.ToUpper() == gab[8])
                    {
                        acertos++;

                    }
                    if (txt10.Text.ToUpper() == gab[9])
                    {
                        acertos++;

                        break;
                    }


                }

                rt.Text = Convert.ToString(acertos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!!");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Novo();
           
        }
    }
}
