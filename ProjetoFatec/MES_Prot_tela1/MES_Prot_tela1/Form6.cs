using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MES_Prot_tela1
{
    public partial class Form6 : Form
    {
        MySqlConnection conexao;

        public Form6()
        {
            InitializeComponent();
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
            var form7 = new Form7();
            form7.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                DGVListaFunc.DataSource = GetList();
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

        private DataTable GetList()
        {
            DataTable dt = new DataTable();

            //BORA TESTAR ISSO AÍ, TEM VÍDEO PRA AJUDAR!
            //CONEXÃO FEITA!
            string DataSource = "DataSource=localhost;username=root;password=;database=semfa_bd";
            //Criar Conexão com MySql

            using (conexao = new MySqlConnection(DataSource))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT id_funcionario, nome_funcionario, cpf_funcionario FROM cadastros", conexao))
                {
                    conexao.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);
                }
            }
                return dt;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DGVListaFunc.DataSource = GetList();
        }

        private void DGVListaFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
