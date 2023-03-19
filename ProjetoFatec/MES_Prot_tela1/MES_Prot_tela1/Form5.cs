using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_Prot_tela1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        double x;
        double y;
        double z;
        double j;
        double k;
        double r;
        double t;
        double s;

        public void Clear()
        {
            gbxCapDisp.Visible = false;
            gbxCapEf.Visible = false;
            gbxCapInst.Visible = false;
            gbxGrau.Visible = false;
            gbxCapRe.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
            {
                Clear();
                gbxCapInst.Visible = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Clear();
                gbxCapDisp.Visible = true;
            }
            if(comboBox1.SelectedIndex == 2)
            {
                Clear();
                gbxGrau.Visible = true;

                //GRAU DE DISPONIBILIDADE
                lblCapInst.Text = Convert.ToString(x);
                lblCapDisp.Text = Convert.ToString(y);

                double grau = (y / x) * 100;
                grau = (double)System.Math.Round(grau, 1);
                lblGrau.Text = Convert.ToString(grau) + "%";

                k = grau;
            }
            if(comboBox1.SelectedIndex == 3)
            {
                Clear();
                gbxCapEf.Visible = true;
            }
            if(comboBox1.SelectedIndex == 4)
            {
                Clear();
                gbxCapRe.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CAPACIDADE INSTALADA
            if (nudDias.Text == "" || nudHoras.Text == "" || nudProd.Text == "")
            {
                Erro();
            }
            else
            {
                double dias = Convert.ToDouble(nudDias.Text);
                double horas = Convert.ToDouble(nudHoras.Text);
                double prod = Convert.ToDouble(nudProd.Text);
                double res = dias * horas * prod;
                lblRes.Text = Convert.ToString(res);
                x = res;

                nudDias.Text = "0";
                nudHoras.Text = "0";
                nudProd.Text = "0";
            }
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            //CAPACIDADE DISPONÍVEL
            if (nudDias2.Text == "" || nudHoras2.Text == "" || nudTurnos.Text == "")
            {
                Erro();
            }
            else
            {
                double dias2 = Convert.ToDouble(nudDias2.Text);
                double horas2 = Convert.ToDouble(nudHoras2.Text);
                double turno = Convert.ToDouble(nudTurnos.Text);
                double semana = Convert.ToDouble(nudQDS.Text);
                double res2 = (dias2 * horas2 * semana) * turno;
                lblRes2.Text = Convert.ToString(res2);
                y = res2;

                nudDias2.Text = "0";
                nudHoras2.Text = "0";
                nudTurnos.Text = "0";
                nudQDS.Text = "0";
            }
        }

        private void btnCalcular3_Click(object sender, EventArgs e)
        {
            //CAPACIDADE EFETIVA E GRAU DE UTILIZAÇÃO
            if(tbxPaPla.Text == "")
            {
                Erro();
            }
            else
            {
                double capef = y - Convert.ToDouble(tbxPaPla.Text);
                double capef2 = (capef / x) * 100;
                capef2 = (double)System.Math.Round(capef2, 1);
                lblCapEf.Text = Convert.ToString(capef2) + "%";
                j = capef;
                z = capef2;

                double graut = (capef / y) * 100;
                graut = (double)System.Math.Round(graut, 1);
                lblGrauUt.Text = Convert.ToString(graut) + "%";
                r = graut;

                tbxPaPla.Text = "0";
            }
        }

        private void btnCalcular4_Click(object sender, EventArgs e)
        {
            //CAPACIDADE REALIZADA E ÍNDICE DE EFICIÊNCIA!
            double pana = Convert.ToDouble(tbxPaNa.Text);
            double pana2 = Convert.ToDouble(((j - pana)/x) * 100);
            pana2 = (double)System.Math.Round(pana2, 1);
            lblCapRe.Text = Convert.ToString(pana2) + "%";
            t = pana2; 

            double capre = (pana2 / z) * 100;   
            capre = (double)System.Math.Round(capre, 1);
            lblInEf.Text = Convert.ToString(capre) + "%";
            s = capre;

            tbxPaNa.Text = "0";
        }

        public void Erro()
        {
            MessageBox.Show("Selecione um valor válido!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double capacidadeinstalada = x * (k / 100);
            double capacidadeefetiva = capacidadeinstalada * (z / 100);
            double graudeutilizacao = capacidadeefetiva * (r / 100);
            double capacidaderealizada = graudeutilizacao * (t / 100);
            double oee = capacidaderealizada * (s / 100); 

            Form4 form4 = new Form4(x, capacidadeinstalada, capacidadeefetiva, graudeutilizacao, capacidaderealizada, oee);
            form4.ShowDialog();
            this.Close();
        }
    }
}
