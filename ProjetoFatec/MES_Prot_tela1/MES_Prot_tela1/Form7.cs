using MySql.Data.MySqlClient;
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
    public partial class Form7 : Form
    {
        MySqlConnection conexao;
        public Form7()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Enabled = false;

            try
            {
                //CONEXÃO FEITA!
                string DataSource = "DataSource=localhost;username=root;password=;database=semfa_bd";
                //Criar Conexão com MySql
                conexao = new MySqlConnection(DataSource);
                //Inserir os dados
                string sql = "INSERT INTO cadastros(nome_funcionario,cpf_funcionario,senha_funcionario)Values('" + tbxNome.Text + "','" + tbxUsuario.Text + "','" + tbxSenha.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cadastrado com sucesso!");

                tbxNome.Clear();
                tbxSenha.Clear();
                tbxUsuario.Clear();
            }
            catch(Exception Ex)
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
