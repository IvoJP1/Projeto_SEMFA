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
using System.IO;

namespace MES_Prot_tela1
{
    public partial class Form12 : Form
    {
        string val;
        MySqlConnection conexao;
        //MySqlDataAdapter da;

        public Form12(string cpfunc)
        {
            InitializeComponent();
            val = cpfunc;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(val);
            this.Close();
            form2.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(val);
            this.Close();
            form12.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13(val);
            this.Close();
            form13.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14(val);
            this.Close();
            form14.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15(val);
            this.Close();
            form15.ShowDialog();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //CONEXÃO FEITA!
            string DataSource = "DataSource=localhost;username=root;password=;database=semfa_bd";
            //Criar Conexão com MySql
            conexao = new MySqlConnection(DataSource);
            conexao.Open();
            //Inserir os dados
            MySqlCommand cmd = new MySqlCommand("SELECT id_funcionario, nome_funcionario FROM cadastros WHERE cpf_funcionario = '" + val + "'", conexao);
            MySqlDataReader myreader = cmd.ExecuteReader();
            if (myreader.Read())
            {
                lblNomeFunc.Text = myreader["nome_funcionario"].ToString();
                lblIdFunc.Text = "ID: ";
                lblIdFunc.Text += myreader["id_funcionario"].ToString();
            }
            else
            {
                lblNomeFunc.Text = "";
                lblIdFunc.Text = "";
                MessageBox.Show("Funcionário não encontrado!");
            }
            conexao.Close();


            /*string selectQuery = "SELECT id_funcionario, nome_funcionario FROM cadastros WHERE cpf_funcionario = '" + val + "'";
            MySqlCommand comando2 = new MySqlCommand(selectQuery, conexao);
            da = new MySqlDataAdapter(comando2);
            DataTable table = new DataTable();

            da.Fill(table);

            lblIdFunc.Text = table.Rows[0][0].ToString();
            lblNomeFunc.Text = table.Rows[0][1].ToString();
            byte[] img = (byte[])table.Rows[0][4];

            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            da.Dispose();*/

        }
    }
}
