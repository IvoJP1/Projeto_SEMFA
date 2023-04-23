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
using MySql.Data.MySqlClient;

namespace MES_Prot_tela1
{
    public partial class Form5 : Form
    {

        MySqlConnection conexao = new MySqlConnection("DataSource=localhost;username=root;password=;database=semfa_bd");

        public Form5()
        {
            InitializeComponent();
        }

        double x; //CAPACIDADE INSTALADA
        double y; //CAPACIDADE DISPONÍVEL
        double z; //CAPACIDADE EFETIVA
        double k; //GRAU DE DISPONIBILIDADE
        double r; //GRAU DE UTILIZAÇÃO
        double t; //CAPACIDADE REALIZADA
        double s; //ÍNDICE DE EFICIÊNCIA

        double diasf;
        double horasf;
        double prodf;

        double diasf2;
        double horasf2;
        double turnof;
        double semanaf;

        double PaPlaf;

        double PaNaPlaf;

        double j;

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
            pictureBox2.Visible = true;
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM valores_grafico", conexao);
            MySqlDataReader myreader = cmd.ExecuteReader();

            if (myreader.Read())
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Clear();
                    nudDias.Text = myreader["dias_trabalhados"].ToString();
                    nudHoras.Text = myreader["horas_dia"].ToString();
                    nudProd.Text = myreader["produtividade_hora"].ToString();
                    lblRes.Text = myreader["capacidade_instalada"].ToString();
                    gbxCapInst.Visible = true;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Clear();
                    nudDias2.Text = myreader["dias_semana"].ToString();
                    nudHoras2.Text = myreader["horas_turno"].ToString();
                    nudTurnos.Text = myreader["turnos_diarios"].ToString();
                    nudQDS.Text = myreader["qtd_semanas"].ToString();
                    lblRes2.Text = myreader["capacidade_disponivel"].ToString();
                    gbxCapDisp.Visible = true;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    //GRAU DE DISPONIBILIDADE
                    lblCapInst.Text = Convert.ToString(x);
                    lblCapDisp.Text = Convert.ToString(y);

                    double grau = (y / x) * 100; //PRIMEIRO
                    grau = (double)System.Math.Round(grau, 1);
                    lblGrau.Text = Convert.ToString(grau) + "%";

                    k = grau;

                    Clear();
                    lblGrau.Text = myreader["grau_de_disponibilidade"].ToString();
                    lblGrau.Text += "%";
                    lblCapInst.Text = myreader["capacidade_instalada"].ToString();
                    lblCapDisp.Text = myreader["capacidade_disponivel"].ToString();
                    gbxGrau.Visible = true;
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    Clear();
                    tbxPaPla.Text = myreader["paradas_planejadas"].ToString();
                    lblCapEf.Text = myreader["capacidade_efetiva"].ToString();
                    lblCapEf.Text += "%";
                    lblGrauUt.Text = myreader["grau_utilizacao"].ToString();
                    lblGrauUt.Text += "%"; 
                    gbxCapEf.Visible = true;
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    Clear();
                    tbxPaNa.Text = myreader["paradas_nao_planejadas"].ToString();
                    lblCapRe.Text = myreader["capacidade_realizada"].ToString();
                    lblCapRe.Text += "%";
                    lblInEf.Text = myreader["indice_de_eficiencia"].ToString();
                    lblInEf.Text += "%";
                    gbxCapRe.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Dados não encontrados!");
            }
            conexao.Close();

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
                double dias = Convert.ToDouble(nudDias.Text); //SEGUNDO
                diasf = dias;
                double horas = Convert.ToDouble(nudHoras.Text); //TERCEIRO
                horasf = horas;
                double prod = Convert.ToDouble(nudProd.Text); //QUARTO
                prodf = prod;
                double res = dias * horas * prod; //QUINTO
                lblRes.Text = Convert.ToString(res);
                x = res;

                nudDias.Text = Convert.ToString(diasf);
                nudHoras.Text = Convert.ToString(horasf);
                nudProd.Text = Convert.ToString(prodf);
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
                double dias2 = Convert.ToDouble(nudDias2.Text); //SEXTO
                diasf2 = dias2;
                double horas2 = Convert.ToDouble(nudHoras2.Text); //SÉTIMO
                horasf2 = horas2;
                double turno = Convert.ToDouble(nudTurnos.Text); //OITAVO
                turnof = turno;
                double semana = Convert.ToDouble(nudQDS.Text); //NONO
                semanaf = semana;
                double res2 = (dias2 * horas2 * semana) * turno; //DÉCIMO
                lblRes2.Text = Convert.ToString(res2);
                y = res2;
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
                PaPlaf = Convert.ToDouble(tbxPaPla.Text);
                double capef = y - Convert.ToDouble(tbxPaPla.Text); //DÉCIMO-1
                double capef2 = (capef / x) * 100; //DÉCIMO-2
                capef2 = (double)System.Math.Round(capef2, 1);
                lblCapEf.Text = Convert.ToString(capef2) + "%";
                j = capef;
                z = capef2;

                double graut = (capef / y) * 100; //DÉCIMO-3
                graut = (double)System.Math.Round(graut, 1);
                lblGrauUt.Text = Convert.ToString(graut) + "%";
                r = graut;
            }
        }

        private void btnCalcular4_Click(object sender, EventArgs e)
        {
            //CAPACIDADE REALIZADA E ÍNDICE DE EFICIÊNCIA!
            double pana = Convert.ToDouble(tbxPaNa.Text); //DÉCIMO-4
            PaNaPlaf = pana;
            double pana2 = Convert.ToDouble(((j - pana)/x) * 100);
            pana2 = (double)System.Math.Round(pana2, 1); //DÉCIMO-5
            lblCapRe.Text = Convert.ToString(pana2) + "%";
            t = pana2; 

            double capre = (pana2 / z) * 100;   //DÉCIMO-6
            capre = (double)System.Math.Round(capre, 1);
            lblInEf.Text = Convert.ToString(capre) + "%";
            s = capre;
        }

        public void Erro()
        {
            MessageBox.Show("Selecione um valor válido!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //TEM QUE MEXER NISSO AQUI AAAAAAA MEXE NO BD AAAAAAAAAAAAA
            double capacidadeinstalada = x * (k / 100);
            double capacidadeefetiva = capacidadeinstalada * (z / 100);
            double graudeutilizacao = capacidadeefetiva * (r / 100);
            double capacidaderealizada = graudeutilizacao * (t / 100);
            double oee = capacidaderealizada * (s / 100);

            try
            {
                //BD
                string sql = "INSERT INTO valores_grafico Values('" + 0 + "','" + x + "','" + diasf + "','" + horasf + "','" + prodf + "','" + y + "','" + turnof + "','" + horasf2 + "','" + diasf2 + "','" + semanaf + "','" + k + "','" + PaPlaf + "','" + z + "','" + r + "','" + PaNaPlaf + "','" + t + "','" + s + "','" + capacidadeinstalada + "','" + capacidadeefetiva + "','" + graudeutilizacao + "','" + capacidaderealizada + "','" + oee + "')";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Dados Salvos!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
