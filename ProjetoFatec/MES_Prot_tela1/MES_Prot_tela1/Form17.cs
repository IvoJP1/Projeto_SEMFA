using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_Prot_tela1
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        string nomeProcesso;
        int qtdEtapas;

        string nomeEtapa;
        int tempoEtapa;
        string cpf;
        //bool 

        private void btnAddProcesso_Click(object sender, EventArgs e)
        {
            nomeProcesso = txtNomeProcesso.Text;
            qtdEtapas = Convert.ToInt16(nudQtdEtapas.Value);

            grbEtapas.Enabled = true;
            grbProcessos.Enabled = false;

            lblNomeEtapa.Text = "Nome da etapa 1";
            lblTempoEtapa.Text = "Tempo da etapa 1";

            // bd
        }

        private void btnAddEtapa_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= qtdEtapas; i++)
            {
                lblNomeEtapa.Text = "Nome da etapa ";
                lblTempoEtapa.Text = "Tempo da etapa ";

                nomeEtapa = txtNomeEtapa.Text;
                tempoEtapa = 1; ///////
                cpf = txtCpfColaborador.Text;

                txtNomeEtapa.Clear();
                txtTempoEtapa.Clear();
                txtCpfColaborador.Clear();

                
            }
            MessageBox.Show("foi");

            // bd
        }
    }
}
