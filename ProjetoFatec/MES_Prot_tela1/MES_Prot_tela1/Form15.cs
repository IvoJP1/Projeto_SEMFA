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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            this.Close();
            form12.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            this.Close();
            form13.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            this.Close();
            form14.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            this.Close();
            form15.ShowDialog();
        }
    }
}
