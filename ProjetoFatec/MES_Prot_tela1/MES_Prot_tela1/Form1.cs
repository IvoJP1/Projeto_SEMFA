using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace MES_Prot_tela1
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //CONEXÃO FEITA!
                string DataSource = "DataSource=localhost;username=root;password=;database=semfa_bd";
                //Criar Conexão com MySql
                conexao = new MySqlConnection(DataSource);
                MySqlCommand comando = conexao.CreateCommand();
                MySqlCommand query = new MySqlCommand("SELECT * FROM cadastros WHERE cpf_funcionario = '" + tbxUsuario.Text +"' AND senha_funcionario = '" + tbxSenhaL.Text + "'", conexao);
                conexao.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dataTable);

                foreach(DataRow list in dataTable.Rows)
                {
                    if (Convert.ToInt32(list.ItemArray[0]) > 0)
                    {
                        var form2 = new Form2(tbxUsuario.Text);
                        form2.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            try
            {
                //CONEXÃO FEITA!
                string DataSource = "DataSource=localhost;username=root;password=;database=semfa_bd";
                //Criar Conexão com MySql
                conexao = new MySqlConnection(DataSource);
                MySqlCommand comando = conexao.CreateCommand();
                MySqlCommand query = new MySqlCommand("SELECT * FROM login_gerente WHERE cpf_gerente = '" + tbxUsuario.Text + "' AND senha_gerente = '" + tbxSenhaL.Text + "'", conexao);
                conexao.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dataTable);

                foreach (DataRow list in dataTable.Rows)
                {
                    if (Convert.ToInt32(list.ItemArray[0]) > 0)
                    {
                        var form3 = new Form3();
                        form3.ShowDialog();
                        this.Close();
                    }
                }
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
