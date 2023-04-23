using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace MES_Prot_tela1
{
    public partial class Form4 : Form
    {
        MySqlConnection conexao = new MySqlConnection("DataSource=localhost;username=root;password=;database=semfa_bd");

        public Form4()
        {
            double valor1=0;
            double valor2=0;
            double valor3=0;
            double valor4=0;
            double valor5=0;
            double valor6=0;

            conexao.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT capacidade_instalada, coluna1, coluna2, coluna3, coluna4, coluna5 FROM valores_grafico", conexao);
            MySqlDataReader myreader = cmd.ExecuteReader();
            if (myreader.Read())
            {
                 valor1 = Convert.ToDouble(myreader["capacidade_instalada"].ToString());
                 valor2 = Convert.ToDouble(myreader["coluna1"].ToString());
                 valor3 = Convert.ToDouble(myreader["coluna2"].ToString());
                 valor4 = Convert.ToDouble(myreader["coluna3"].ToString());
                 valor5 = Convert.ToDouble(myreader["coluna4"].ToString());
                 valor6 = Convert.ToDouble(myreader["coluna5"].ToString());
            }
            else
            {
                MessageBox.Show("Dados não encontrados!");
            }
            conexao.Close();

            InitializeComponent();
            GerarGraficoColunas(valor1, valor2, valor3, valor4, valor5, valor6);
        }

        //BOTÕES
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            this.Close();
            form3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            this.Close();
            form4.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var form8 = new Form8();
            this.Close();
            form8.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var form6 = new Form6();
            this.Close();
            form6.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var form9 = new Form9();
            this.Close();
            form9.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var form10 = new Form10();
            this.Close();
            form10.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            var form11 = new Form11();
            this.Close();
            form11.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //GerarGraficoColunas();
        }

        private void GerarGraficoColunas(double v1, double v2, double v3, double v4, double v5, double v6)
        {
            lblteste.Visible = false;

            //TÍTULO
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Brown;
            title.Text = "Indicador OEE";
            chart1.Titles.Add(title);

            //INSERIR LEGENDAS
            /*Legend legend = new Legend();
            chart1.Legends.Add(legend);
            chart1.Legends[0].Title = "Legenda";*/

            //TÍTULO DOS EIXOS X E Y
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Produtividade";
            chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Horas";
            chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            //REMOVER GRADES
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

            //ESCALA DO EIXO Y
            chart1.ChartAreas[0].AxisY.Maximum = 160;
            chart1.ChartAreas[0].AxisY.Interval = 40;

            //COLUNAS
            chart1.Series.Add("vendas");
            chart1.Series["vendas"].LegendText = "Produtividade";

            chart1.Series["vendas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["vendas"].BorderWidth = 4;

            chart1.Series["vendas"].Points.AddXY("C.I.", v1);
            chart1.Series["vendas"].Points.AddXY("G.D.", v2);
            chart1.Series["vendas"].Points.AddXY("C.E.", v3);
            chart1.Series["vendas"].Points.AddXY("G.U.", v4);
            chart1.Series["vendas"].Points.AddXY("C.R.", v5);
            chart1.Series["vendas"].Points.AddXY("I.E.", v6);
        }
    }
}
