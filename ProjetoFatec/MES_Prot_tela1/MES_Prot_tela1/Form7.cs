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
    public partial class Form7 : Form
    {
        MySqlConnection conexao = new MySqlConnection("DataSource=localhost;username=root;password=;database=semfa_bd");

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
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                String insertQuery = "INSERT INTO cadastros(nome_funcionario, cpf_funcionario, senha_funcionario, img_funcionario) VALUES(@nome, @cpf, @senha, @img)";
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(insertQuery, conexao);

                comando.Parameters.Add("@nome", MySqlDbType.VarChar,70);
                comando.Parameters.Add("@cpf", MySqlDbType.Int64);
                comando.Parameters.Add("@senha", MySqlDbType.VarChar, 50);
                comando.Parameters.Add("@img", MySqlDbType.Blob);

                comando.Parameters["@nome"].Value = tbxNome.Text;
                comando.Parameters["@cpf"].Value = tbxUsuario.Text;
                comando.Parameters["@senha"].Value = tbxSenha.Text;
                comando.Parameters["@img"].Value = img;

                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA INSERTED!");
                }

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

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
