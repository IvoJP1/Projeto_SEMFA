using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
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

namespace MES_Prot_tela1
{
    public partial class Form13 : Form
    {
        MySqlConnection conexao;
        string val;

        public Form13(string cpf)
        {
            InitializeComponent();
            val = cpf;
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        int seg = 0;
        public int segp = 0;
        int min = 0;
        int minp = 0;
        int horas = 0;
        int horasp = 0;
        int total = 0;
        int totalp = 0;
        //
        bool taPausado = false;

        int qtdParadas = 0;
        int tempoParado = 0;
        int[] tempoCadaParada = {0};
        int tamanhoArray;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            seg++;
            lblSeg.Text = Convert.ToString(seg);
            if(seg > 59)
            {
                min++;
                lblMin.Text = Convert.ToString(min);
                seg = 0;

                if (min > 59)
                {
                    horas++;
                    lblHoras.Text = Convert.ToString(horas);
                    min = 0;
                    lblMin.Text = Convert.ToString(min);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (taPausado == true)
            {
                /**/
                timer2.Enabled = false;
                Form16 form16 = new Form16(segp, val);
                form16.ShowDialog();
            }

            timer1.Enabled = true;

            if (segp == 0)
            {
                // iniciar normalmente e resetar o contador de tempo parado
                //lblSegP.Text = Convert.ToString(segp);
            }
            else
            {
                // registrar tempo parado e resetar o contador de tempo parado

                /*try
                {
                    MemoryStream ms = new MemoryStream();
                    byte[] img = ms.ToArray();

                    String insertQuery = "INSERT INTO tbQtdParadas (tempo_parada) VALUES (@tempo)";
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand(insertQuery, conexao);

                    comando.Parameters.Add("@tempo", MySqlDbType.Int64);

                    comando.Parameters["@tempo"].Value = segp;

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("DATA INSERTED!");
                    }
                    segp = 0;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    conexao.Close();
                }*/
                //lblSegP.Text = Convert.ToString(segp);
            }
            segp = 0;
            lblSegP.Text = Convert.ToString(segp);
            taPausado = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Finalizar o Processo?", "FINALIZAR PROCESSO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                timer1.Enabled = false;
                

                lblTemptotal.Text += horas + " :" + min + ":" + seg;

                /////////////////////////////////////
                if (segp != 0)
                {
                    if (segp != 1)
                    {
                        try
                        {


                            String insertQuery = "INSERT INTO tbQtdParadas (tempo_parada) VALUES (@tempo)";
                            conexao.Open();

                            MySqlCommand comando = new MySqlCommand(insertQuery, conexao);

                            comando.Parameters.Add("@tempo", MySqlDbType.Int64);

                            comando.Parameters["@tempo"].Value = segp;

                            if (comando.ExecuteNonQuery() == 1)
                            {
                                //MessageBox.Show("DATA INSERTED!");
                            }
                            segp = 0;
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

                seg = 0;
                segp = 0;
                min = 0;
                minp = 0;
                horas = 0;
                horasp = 0;

                lblSeg.Text = Convert.ToString(seg);
                lblSegP.Text = Convert.ToString(segp);
                lblMin.Text = Convert.ToString(min);
                lblMinP.Text = Convert.ToString(minp);
                lblHoras.Text = Convert.ToString(horas);
                lblHorasP.Text = Convert.ToString(horasp);

                timer2.Enabled = false;
                timer1.Enabled = false;
            }

            // registrar tempo parado e resetar o contador de tempo parado

            
        }

        //
        private void ShowArrayInfo(Array arr)
        {
            tamanhoArray = arr.Length;
        }
        //

        private void button2_Click(object sender, EventArgs e)
        {
            taPausado = true;

            if (timer1.Enabled == true)
            {
                qtdParadas++;
                lblQtdParadas.Text = "Quantidade de paradas: " + Convert.ToString(qtdParadas);
                //

                /*if (tempoCadaParada.Length == null)
                {
                    tamanhoArray = 0;
                }
                else
                {
                    tamanhoArray = tempoCadaParada.Length;
                }*/

                
                //
                timer1.Enabled = false;
                timer2.Enabled = true;
            }

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            segp++;
            lblSegP.Text = Convert.ToString(segp);
            if (segp > 59)
            {
                minp++;
                lblMinP.Text = Convert.ToString(minp);
                segp = 0;

                if (minp > 59)
                {
                    horasp++;
                    lblHorasP.Text = Convert.ToString(horasp);
                    minp = 0;
                    lblMinP.Text = Convert.ToString(minp);
                }
            }


            //
            tempoParado++;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            lblSeg.Text = Convert.ToString(seg);
            lblSegP.Text = Convert.ToString(segp);
            lblMin.Text = Convert.ToString(min);
            lblMinP.Text = Convert.ToString(minp);
            lblHoras.Text = Convert.ToString(horas);
            lblHorasP.Text = Convert.ToString(horasp);


            try
            {
                dgvInfoParadas.DataSource = GetList2();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            /**/
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            dgvInfoParadas.DataSource = GetList2();
        }

        private DataTable GetList2()
        {
            DataTable dt2 = new DataTable();

            
            //CONEXÃO FEITA!
            string DataSource = "DataSource=localhost;username=root;password=;database=semfa_bd";
            //Criar Conexão com MySql

            using (conexao = new MySqlConnection(DataSource))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT id_parada, tempo_parada FROM tbQtdParadas", conexao))
                {
                    conexao.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dt2.Load(reader);
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT SUM(tempo_parada) AS 'Tempo parado' FROM tbQtdParadas", conexao))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt2.Load(reader);
                }
            }
            return dt2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DataSource = "DataSource=localhost;username=root;password=;database=semfa_bd";
            using (conexao = new MySqlConnection(DataSource))
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tbQtdParadas;", conexao))
                {
                    conexao.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();
                }
            }
        }
    }
}
