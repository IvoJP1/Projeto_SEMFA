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
    public partial class Form13 : Form
    {
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
        int segp = 0;
        int min = 0;
        int minp = 0;
        int horas = 0;
        int horasp = 0;
        int total = 0;
        int totalp = 0;

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
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Finalizar o Processo?", "FINALIZAR PROCESSO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                timer1.Enabled = false;
                lblTemptotal.Text += horas + " : " + min + " : " + seg;
                lblPartotal.Text += horasp + " : " + minp + " : " + segp;

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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
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
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            lblSeg.Text = Convert.ToString(seg);
            lblSegP.Text = Convert.ToString(segp);
            lblMin.Text = Convert.ToString(min);
            lblMinP.Text = Convert.ToString(minp);
            lblHoras.Text = Convert.ToString(horas);
            lblHorasP.Text = Convert.ToString(horasp);
        }
    }
}
