namespace MES_Prot_tela1
{
    partial class Form16
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutros = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbDefeitoAparelho = new System.Windows.Forms.RadioButton();
            this.rdbRazoesPessoais = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbOutros = new System.Windows.Forms.RadioButton();
            this.rdbImprevistoInterno = new System.Windows.Forms.RadioButton();
            this.rdbImprevistoExterno = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutros
            // 
            this.txtOutros.Enabled = false;
            this.txtOutros.Location = new System.Drawing.Point(183, 48);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(203, 132);
            this.txtOutros.TabIndex = 6;
            this.txtOutros.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbDefeitoAparelho);
            this.groupBox1.Controls.Add(this.rdbRazoesPessoais);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtOutros);
            this.groupBox1.Controls.Add(this.rdbOutros);
            this.groupBox1.Controls.Add(this.rdbImprevistoInterno);
            this.groupBox1.Controls.Add(this.rdbImprevistoExterno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Justifique a parada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "-- / --";
            // 
            // rdbDefeitoAparelho
            // 
            this.rdbDefeitoAparelho.AutoSize = true;
            this.rdbDefeitoAparelho.Location = new System.Drawing.Point(50, 118);
            this.rdbDefeitoAparelho.Name = "rdbDefeitoAparelho";
            this.rdbDefeitoAparelho.Size = new System.Drawing.Size(118, 17);
            this.rdbDefeitoAparelho.TabIndex = 15;
            this.rdbDefeitoAparelho.TabStop = true;
            this.rdbDefeitoAparelho.Text = "Defeito do aparelho";
            this.rdbDefeitoAparelho.UseVisualStyleBackColor = true;
            // 
            // rdbRazoesPessoais
            // 
            this.rdbRazoesPessoais.AutoSize = true;
            this.rdbRazoesPessoais.Location = new System.Drawing.Point(50, 95);
            this.rdbRazoesPessoais.Name = "rdbRazoesPessoais";
            this.rdbRazoesPessoais.Size = new System.Drawing.Size(105, 17);
            this.rdbRazoesPessoais.TabIndex = 14;
            this.rdbRazoesPessoais.TabStop = true;
            this.rdbRazoesPessoais.Text = "Razões pessoais";
            this.rdbRazoesPessoais.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(311, 198);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Location = new System.Drawing.Point(41, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 130);
            this.panel1.TabIndex = 12;
            // 
            // rdbOutros
            // 
            this.rdbOutros.AutoSize = true;
            this.rdbOutros.Location = new System.Drawing.Point(50, 162);
            this.rdbOutros.Name = "rdbOutros";
            this.rdbOutros.Size = new System.Drawing.Size(56, 17);
            this.rdbOutros.TabIndex = 8;
            this.rdbOutros.TabStop = true;
            this.rdbOutros.Text = "Outros";
            this.rdbOutros.UseVisualStyleBackColor = true;
            // 
            // rdbImprevistoInterno
            // 
            this.rdbImprevistoInterno.AutoSize = true;
            this.rdbImprevistoInterno.Location = new System.Drawing.Point(50, 72);
            this.rdbImprevistoInterno.Name = "rdbImprevistoInterno";
            this.rdbImprevistoInterno.Size = new System.Drawing.Size(108, 17);
            this.rdbImprevistoInterno.TabIndex = 7;
            this.rdbImprevistoInterno.TabStop = true;
            this.rdbImprevistoInterno.Text = "Imprevisto interno";
            this.rdbImprevistoInterno.UseVisualStyleBackColor = true;
            // 
            // rdbImprevistoExterno
            // 
            this.rdbImprevistoExterno.AutoSize = true;
            this.rdbImprevistoExterno.Location = new System.Drawing.Point(50, 49);
            this.rdbImprevistoExterno.Name = "rdbImprevistoExterno";
            this.rdbImprevistoExterno.Size = new System.Drawing.Size(111, 17);
            this.rdbImprevistoExterno.TabIndex = 6;
            this.rdbImprevistoExterno.TabStop = true;
            this.rdbImprevistoExterno.Text = "Imprevisto externo";
            this.rdbImprevistoExterno.UseVisualStyleBackColor = true;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 263);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOutros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbDefeitoAparelho;
        private System.Windows.Forms.RadioButton rdbRazoesPessoais;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbOutros;
        private System.Windows.Forms.RadioButton rdbImprevistoInterno;
        private System.Windows.Forms.RadioButton rdbImprevistoExterno;
    }
}