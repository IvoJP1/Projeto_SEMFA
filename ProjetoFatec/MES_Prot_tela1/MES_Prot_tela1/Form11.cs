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
    public partial class Form11 : Form
    {
        public Form11()
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
    }
}
