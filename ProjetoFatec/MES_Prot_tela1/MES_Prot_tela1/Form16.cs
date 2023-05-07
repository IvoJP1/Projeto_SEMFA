using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace MES_Prot_tela1
{
    public partial class Form16 : Form
    {
        

        public Form16(int segp, string val)
        {
            InitializeComponent();

            segp2 = segp;
            val2 = val;

            if (rdbOutros.Checked == true)
            {
                txtOutros.Enabled = true;
            }

        }

        string linha;
        MySqlConnection conexao;

        /*ELIMINAR O VAL, APOSENTAR ELE*/ 
        int segp2;
        string val2;

        private void Form16_Load(object sender, EventArgs e)
        {
            //bool imprevistoExterno = false;
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            

            if (rdbImprevistoExterno.Checked == false && rdbImprevistoInterno.Checked == false && rdbRazoesPessoais.Checked == false && rdbDefeitoAparelho.Checked == false)
            {
                MessageBox.Show("Selecione uma justificativa!");
            }
            else
            {
                if (rdbImprevistoExterno.Checked == true)
                {
                    linha = "INSERT INTO tbQtdParadas(tempo_parada, justificativa_parada) VALUES (" + segp2 + ", 'Imprevisto Externo')";
                }
                else if (rdbImprevistoInterno.Checked == true)
                {
                    linha = "INSERT INTO tbQtdParadas(tempo_parada, justificativa_parada) VALUES (" + segp2 + ", 'Imprevisto Interno')";
                }
                else if (rdbRazoesPessoais.Checked == true)
                {
                    linha = "INSERT INTO tbQtdParadas(tempo_parada, justificativa_parada) VALUES (" + segp2 + ", 'Razões Pessoais')";
                }
                else if (rdbDefeitoAparelho.Checked == true)
                {
                    linha = "INSERT INTO tbQtdParadas(tempo_parada, justificativa_parada) VALUES (" + segp2 + ", 'Defeito do Aparelho')";
                }
                else
                {
                    


                    /*comando.Parameters.Add("@outros", MySqlDbType.VarChar, 70);
                    comando.Parameters["@outros"].Value = txtOutros.Text;*/

                }

                /**/

                try
                {
                    string DataSource = "DataSource=localhost;username=root;password=;database=semfa_bd";
                    //Criar Conexão com MySql
                    conexao = new MySqlConnection(DataSource);
                    conexao.Open();

                    MySqlCommand cmd = new MySqlCommand(linha, conexao);
                    //String insertQuery = "INSERT INTO tbQtdParadas (justificativa_parada) VALUES (@tempo)";
                    //String insertQuery = linha;

                    
                    MySqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    conexao.Close();

                    /*Form13 form13 = new Form13(val2);
                    form13.ShowDialog();*/
                    this.Close();
                }

            }
        }
    }
}
