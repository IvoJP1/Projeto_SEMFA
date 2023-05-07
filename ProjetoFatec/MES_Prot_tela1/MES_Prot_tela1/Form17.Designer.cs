namespace MES_Prot_tela1
{
    partial class Form17
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
            this.lblNomeProcesso = new System.Windows.Forms.Label();
            this.txtNomeProcesso = new System.Windows.Forms.TextBox();
            this.lblQtdEtapas = new System.Windows.Forms.Label();
            this.nudQtdEtapas = new System.Windows.Forms.NumericUpDown();
            this.lblNomeEtapa = new System.Windows.Forms.Label();
            this.lblTempoEtapa = new System.Windows.Forms.Label();
            this.txtNomeEtapa = new System.Windows.Forms.TextBox();
            this.txtTempoEtapa = new System.Windows.Forms.TextBox();
            this.grbEtapas = new System.Windows.Forms.GroupBox();
            this.btnAddEtapa = new System.Windows.Forms.Button();
            this.txtCpfColaborador = new System.Windows.Forms.TextBox();
            this.lblCpfColaborador = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAddProcesso = new System.Windows.Forms.Button();
            this.grbProcessos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdEtapas)).BeginInit();
            this.grbEtapas.SuspendLayout();
            this.grbProcessos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeProcesso
            // 
            this.lblNomeProcesso.AutoSize = true;
            this.lblNomeProcesso.Location = new System.Drawing.Point(8, 28);
            this.lblNomeProcesso.Name = "lblNomeProcesso";
            this.lblNomeProcesso.Size = new System.Drawing.Size(96, 13);
            this.lblNomeProcesso.TabIndex = 0;
            this.lblNomeProcesso.Text = "Nome do processo";
            // 
            // txtNomeProcesso
            // 
            this.txtNomeProcesso.Location = new System.Drawing.Point(11, 44);
            this.txtNomeProcesso.Name = "txtNomeProcesso";
            this.txtNomeProcesso.Size = new System.Drawing.Size(254, 20);
            this.txtNomeProcesso.TabIndex = 1;
            // 
            // lblQtdEtapas
            // 
            this.lblQtdEtapas.AutoSize = true;
            this.lblQtdEtapas.Location = new System.Drawing.Point(8, 87);
            this.lblQtdEtapas.Name = "lblQtdEtapas";
            this.lblQtdEtapas.Size = new System.Drawing.Size(112, 13);
            this.lblQtdEtapas.TabIndex = 2;
            this.lblQtdEtapas.Text = "Quantidade de etapas";
            // 
            // nudQtdEtapas
            // 
            this.nudQtdEtapas.Location = new System.Drawing.Point(126, 85);
            this.nudQtdEtapas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtdEtapas.Name = "nudQtdEtapas";
            this.nudQtdEtapas.Size = new System.Drawing.Size(139, 20);
            this.nudQtdEtapas.TabIndex = 3;
            this.nudQtdEtapas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNomeEtapa
            // 
            this.lblNomeEtapa.AutoSize = true;
            this.lblNomeEtapa.Location = new System.Drawing.Point(3, 25);
            this.lblNomeEtapa.Name = "lblNomeEtapa";
            this.lblNomeEtapa.Size = new System.Drawing.Size(90, 13);
            this.lblNomeEtapa.TabIndex = 4;
            this.lblNomeEtapa.Text = "Nome da etapa X";
            // 
            // lblTempoEtapa
            // 
            this.lblTempoEtapa.AutoSize = true;
            this.lblTempoEtapa.Location = new System.Drawing.Point(3, 84);
            this.lblTempoEtapa.Name = "lblTempoEtapa";
            this.lblTempoEtapa.Size = new System.Drawing.Size(95, 13);
            this.lblTempoEtapa.TabIndex = 5;
            this.lblTempoEtapa.Text = "Tempo da etapa X";
            // 
            // txtNomeEtapa
            // 
            this.txtNomeEtapa.Location = new System.Drawing.Point(6, 41);
            this.txtNomeEtapa.Name = "txtNomeEtapa";
            this.txtNomeEtapa.Size = new System.Drawing.Size(211, 20);
            this.txtNomeEtapa.TabIndex = 6;
            // 
            // txtTempoEtapa
            // 
            this.txtTempoEtapa.Location = new System.Drawing.Point(6, 100);
            this.txtTempoEtapa.Name = "txtTempoEtapa";
            this.txtTempoEtapa.Size = new System.Drawing.Size(116, 20);
            this.txtTempoEtapa.TabIndex = 7;
            // 
            // grbEtapas
            // 
            this.grbEtapas.Controls.Add(this.btnAddEtapa);
            this.grbEtapas.Controls.Add(this.txtCpfColaborador);
            this.grbEtapas.Controls.Add(this.lblCpfColaborador);
            this.grbEtapas.Controls.Add(this.txtNomeEtapa);
            this.grbEtapas.Controls.Add(this.txtTempoEtapa);
            this.grbEtapas.Controls.Add(this.lblNomeEtapa);
            this.grbEtapas.Controls.Add(this.lblTempoEtapa);
            this.grbEtapas.Enabled = false;
            this.grbEtapas.Location = new System.Drawing.Point(23, 204);
            this.grbEtapas.Name = "grbEtapas";
            this.grbEtapas.Size = new System.Drawing.Size(276, 231);
            this.grbEtapas.TabIndex = 8;
            this.grbEtapas.TabStop = false;
            this.grbEtapas.Text = "Etapas";
            // 
            // btnAddEtapa
            // 
            this.btnAddEtapa.Location = new System.Drawing.Point(6, 191);
            this.btnAddEtapa.Name = "btnAddEtapa";
            this.btnAddEtapa.Size = new System.Drawing.Size(248, 34);
            this.btnAddEtapa.TabIndex = 10;
            this.btnAddEtapa.Text = "Adicionar Etapa";
            this.btnAddEtapa.UseVisualStyleBackColor = true;
            this.btnAddEtapa.Click += new System.EventHandler(this.btnAddEtapa_Click);
            // 
            // txtCpfColaborador
            // 
            this.txtCpfColaborador.Location = new System.Drawing.Point(6, 152);
            this.txtCpfColaborador.Name = "txtCpfColaborador";
            this.txtCpfColaborador.Size = new System.Drawing.Size(116, 20);
            this.txtCpfColaborador.TabIndex = 9;
            // 
            // lblCpfColaborador
            // 
            this.lblCpfColaborador.AutoSize = true;
            this.lblCpfColaborador.Location = new System.Drawing.Point(3, 136);
            this.lblCpfColaborador.Name = "lblCpfColaborador";
            this.lblCpfColaborador.Size = new System.Drawing.Size(101, 13);
            this.lblCpfColaborador.TabIndex = 8;
            this.lblCpfColaborador.Text = "CPF do colaborador";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(185, 449);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(92, 34);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnAddProcesso
            // 
            this.btnAddProcesso.Location = new System.Drawing.Point(11, 123);
            this.btnAddProcesso.Name = "btnAddProcesso";
            this.btnAddProcesso.Size = new System.Drawing.Size(254, 34);
            this.btnAddProcesso.TabIndex = 11;
            this.btnAddProcesso.Text = "Adicionar Processo";
            this.btnAddProcesso.UseVisualStyleBackColor = true;
            this.btnAddProcesso.Click += new System.EventHandler(this.btnAddProcesso_Click);
            // 
            // grbProcessos
            // 
            this.grbProcessos.Controls.Add(this.lblNomeProcesso);
            this.grbProcessos.Controls.Add(this.btnAddProcesso);
            this.grbProcessos.Controls.Add(this.txtNomeProcesso);
            this.grbProcessos.Controls.Add(this.lblQtdEtapas);
            this.grbProcessos.Controls.Add(this.nudQtdEtapas);
            this.grbProcessos.Location = new System.Drawing.Point(23, 12);
            this.grbProcessos.Name = "grbProcessos";
            this.grbProcessos.Size = new System.Drawing.Size(276, 175);
            this.grbProcessos.TabIndex = 12;
            this.grbProcessos.TabStop = false;
            this.grbProcessos.Text = "Processos";
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 496);
            this.Controls.Add(this.grbProcessos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.grbEtapas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdEtapas)).EndInit();
            this.grbEtapas.ResumeLayout(false);
            this.grbEtapas.PerformLayout();
            this.grbProcessos.ResumeLayout(false);
            this.grbProcessos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProcesso;
        private System.Windows.Forms.TextBox txtNomeProcesso;
        private System.Windows.Forms.Label lblQtdEtapas;
        private System.Windows.Forms.NumericUpDown nudQtdEtapas;
        private System.Windows.Forms.Label lblNomeEtapa;
        private System.Windows.Forms.Label lblTempoEtapa;
        private System.Windows.Forms.TextBox txtNomeEtapa;
        private System.Windows.Forms.TextBox txtTempoEtapa;
        private System.Windows.Forms.GroupBox grbEtapas;
        private System.Windows.Forms.TextBox txtCpfColaborador;
        private System.Windows.Forms.Label lblCpfColaborador;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAddEtapa;
        private System.Windows.Forms.Button btnAddProcesso;
        private System.Windows.Forms.GroupBox grbProcessos;
    }
}