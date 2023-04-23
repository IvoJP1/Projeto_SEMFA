namespace MES_Prot_tela1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbxCapInst = new System.Windows.Forms.GroupBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.nudProd = new System.Windows.Forms.NumericUpDown();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxCapDisp = new System.Windows.Forms.GroupBox();
            this.nudQDS = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.nudDias2 = new System.Windows.Forms.NumericUpDown();
            this.nudHoras2 = new System.Windows.Forms.NumericUpDown();
            this.nudTurnos = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxGrau = new System.Windows.Forms.GroupBox();
            this.lblGrau = new System.Windows.Forms.Label();
            this.lblCapDisp = new System.Windows.Forms.Label();
            this.lblCapInst = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxCapEf = new System.Windows.Forms.GroupBox();
            this.btnCalcular3 = new System.Windows.Forms.Button();
            this.lblGrauUt = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCapEf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPaPla = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gbxCapRe = new System.Windows.Forms.GroupBox();
            this.btnCalcular4 = new System.Windows.Forms.Button();
            this.lblInEf = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCapRe = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxPaNa = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxCapInst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.gbxCapDisp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnos)).BeginInit();
            this.gbxGrau.SuspendLayout();
            this.gbxCapEf.SuspendLayout();
            this.gbxCapRe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADICIONAR";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Capacidade Instalada",
            "Capacidade Disponível",
            "Grau de Disponibilidade",
            "C.E. e G.U.",
            "C.R. e I.E."});
            this.comboBox1.Location = new System.Drawing.Point(128, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbxCapInst
            // 
            this.gbxCapInst.Controls.Add(this.lblRes);
            this.gbxCapInst.Controls.Add(this.nudProd);
            this.gbxCapInst.Controls.Add(this.nudHoras);
            this.gbxCapInst.Controls.Add(this.nudDias);
            this.gbxCapInst.Controls.Add(this.btnCalcular1);
            this.gbxCapInst.Controls.Add(this.lblResultado);
            this.gbxCapInst.Controls.Add(this.label5);
            this.gbxCapInst.Controls.Add(this.label4);
            this.gbxCapInst.Controls.Add(this.label2);
            this.gbxCapInst.Location = new System.Drawing.Point(56, 39);
            this.gbxCapInst.Name = "gbxCapInst";
            this.gbxCapInst.Size = new System.Drawing.Size(363, 189);
            this.gbxCapInst.TabIndex = 2;
            this.gbxCapInst.TabStop = false;
            this.gbxCapInst.Visible = false;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(84, 140);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(14, 16);
            this.lblRes.TabIndex = 11;
            this.lblRes.Text = "0";
            // 
            // nudProd
            // 
            this.nudProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudProd.Location = new System.Drawing.Point(159, 89);
            this.nudProd.Name = "nudProd";
            this.nudProd.Size = new System.Drawing.Size(178, 20);
            this.nudProd.TabIndex = 10;
            // 
            // nudHoras
            // 
            this.nudHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHoras.Location = new System.Drawing.Point(101, 53);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(236, 20);
            this.nudHoras.TabIndex = 9;
            // 
            // nudDias
            // 
            this.nudDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDias.Location = new System.Drawing.Point(217, 16);
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(120, 20);
            this.nudDias.TabIndex = 8;
            // 
            // btnCalcular1
            // 
            this.btnCalcular1.Location = new System.Drawing.Point(262, 127);
            this.btnCalcular1.Name = "btnCalcular1";
            this.btnCalcular1.Size = new System.Drawing.Size(75, 29);
            this.btnCalcular1.TabIndex = 7;
            this.btnCalcular1.Text = "Calcular";
            this.btnCalcular1.UseVisualStyleBackColor = true;
            this.btnCalcular1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(9, 140);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 16);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Produtividade por hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Horas por dia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dias Trabalhados (mensalmente):";
            // 
            // gbxCapDisp
            // 
            this.gbxCapDisp.Controls.Add(this.nudQDS);
            this.gbxCapDisp.Controls.Add(this.label10);
            this.gbxCapDisp.Controls.Add(this.lblRes2);
            this.gbxCapDisp.Controls.Add(this.nudDias2);
            this.gbxCapDisp.Controls.Add(this.nudHoras2);
            this.gbxCapDisp.Controls.Add(this.nudTurnos);
            this.gbxCapDisp.Controls.Add(this.btnCalcular2);
            this.gbxCapDisp.Controls.Add(this.label6);
            this.gbxCapDisp.Controls.Add(this.label7);
            this.gbxCapDisp.Controls.Add(this.label8);
            this.gbxCapDisp.Controls.Add(this.label9);
            this.gbxCapDisp.Location = new System.Drawing.Point(56, 39);
            this.gbxCapDisp.Name = "gbxCapDisp";
            this.gbxCapDisp.Size = new System.Drawing.Size(363, 189);
            this.gbxCapDisp.TabIndex = 12;
            this.gbxCapDisp.TabStop = false;
            this.gbxCapDisp.Visible = false;
            // 
            // nudQDS
            // 
            this.nudQDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQDS.Location = new System.Drawing.Point(126, 94);
            this.nudQDS.Name = "nudQDS";
            this.nudQDS.Size = new System.Drawing.Size(212, 20);
            this.nudQDS.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Qtd de Semanas:";
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes2.Location = new System.Drawing.Point(84, 140);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(14, 16);
            this.lblRes2.TabIndex = 11;
            this.lblRes2.Text = "0";
            // 
            // nudDias2
            // 
            this.nudDias2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDias2.Location = new System.Drawing.Point(126, 68);
            this.nudDias2.Name = "nudDias2";
            this.nudDias2.Size = new System.Drawing.Size(212, 20);
            this.nudDias2.TabIndex = 10;
            // 
            // nudHoras2
            // 
            this.nudHoras2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHoras2.Location = new System.Drawing.Point(114, 42);
            this.nudHoras2.Name = "nudHoras2";
            this.nudHoras2.Size = new System.Drawing.Size(223, 20);
            this.nudHoras2.TabIndex = 9;
            // 
            // nudTurnos
            // 
            this.nudTurnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTurnos.Location = new System.Drawing.Point(114, 16);
            this.nudTurnos.Name = "nudTurnos";
            this.nudTurnos.Size = new System.Drawing.Size(223, 20);
            this.nudTurnos.TabIndex = 8;
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Location = new System.Drawing.Point(263, 127);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(75, 29);
            this.btnCalcular2.TabIndex = 7;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Resultado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Dias por semana:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Horas por turno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Turnos Diários:";
            // 
            // gbxGrau
            // 
            this.gbxGrau.Controls.Add(this.lblGrau);
            this.gbxGrau.Controls.Add(this.lblCapDisp);
            this.gbxGrau.Controls.Add(this.lblCapInst);
            this.gbxGrau.Controls.Add(this.label11);
            this.gbxGrau.Controls.Add(this.label12);
            this.gbxGrau.Controls.Add(this.label13);
            this.gbxGrau.Location = new System.Drawing.Point(56, 39);
            this.gbxGrau.Name = "gbxGrau";
            this.gbxGrau.Size = new System.Drawing.Size(363, 189);
            this.gbxGrau.TabIndex = 13;
            this.gbxGrau.TabStop = false;
            this.gbxGrau.Visible = false;
            // 
            // lblGrau
            // 
            this.lblGrau.AutoSize = true;
            this.lblGrau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrau.Location = new System.Drawing.Point(177, 105);
            this.lblGrau.Name = "lblGrau";
            this.lblGrau.Size = new System.Drawing.Size(27, 18);
            this.lblGrau.TabIndex = 7;
            this.lblGrau.Text = "sla";
            // 
            // lblCapDisp
            // 
            this.lblCapDisp.AutoSize = true;
            this.lblCapDisp.Location = new System.Drawing.Point(177, 55);
            this.lblCapDisp.Name = "lblCapDisp";
            this.lblCapDisp.Size = new System.Drawing.Size(20, 13);
            this.lblCapDisp.TabIndex = 6;
            this.lblCapDisp.Text = "sla";
            // 
            // lblCapInst
            // 
            this.lblCapInst.AutoSize = true;
            this.lblCapInst.Location = new System.Drawing.Point(177, 16);
            this.lblCapInst.Name = "lblCapInst";
            this.lblCapInst.Size = new System.Drawing.Size(20, 13);
            this.lblCapInst.TabIndex = 5;
            this.lblCapInst.Text = "sla";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Grau de Disponibilidade:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Capacidade Disponível:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Capacidade Instalada:";
            // 
            // gbxCapEf
            // 
            this.gbxCapEf.Controls.Add(this.btnCalcular3);
            this.gbxCapEf.Controls.Add(this.lblGrauUt);
            this.gbxCapEf.Controls.Add(this.label14);
            this.gbxCapEf.Controls.Add(this.lblCapEf);
            this.gbxCapEf.Controls.Add(this.label3);
            this.gbxCapEf.Controls.Add(this.tbxPaPla);
            this.gbxCapEf.Controls.Add(this.label17);
            this.gbxCapEf.Location = new System.Drawing.Point(56, 39);
            this.gbxCapEf.Name = "gbxCapEf";
            this.gbxCapEf.Size = new System.Drawing.Size(363, 189);
            this.gbxCapEf.TabIndex = 14;
            this.gbxCapEf.TabStop = false;
            this.gbxCapEf.Visible = false;
            // 
            // btnCalcular3
            // 
            this.btnCalcular3.Location = new System.Drawing.Point(210, 82);
            this.btnCalcular3.Name = "btnCalcular3";
            this.btnCalcular3.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular3.TabIndex = 6;
            this.btnCalcular3.Text = "Calcular";
            this.btnCalcular3.UseVisualStyleBackColor = true;
            this.btnCalcular3.Click += new System.EventHandler(this.btnCalcular3_Click);
            // 
            // lblGrauUt
            // 
            this.lblGrauUt.AutoSize = true;
            this.lblGrauUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrauUt.Location = new System.Drawing.Point(142, 107);
            this.lblGrauUt.Name = "lblGrauUt";
            this.lblGrauUt.Size = new System.Drawing.Size(14, 16);
            this.lblGrauUt.TabIndex = 5;
            this.lblGrauUt.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Grau de Utilização:";
            // 
            // lblCapEf
            // 
            this.lblCapEf.AutoSize = true;
            this.lblCapEf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapEf.Location = new System.Drawing.Point(142, 70);
            this.lblCapEf.Name = "lblCapEf";
            this.lblCapEf.Size = new System.Drawing.Size(14, 16);
            this.lblCapEf.TabIndex = 3;
            this.lblCapEf.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacidade Efetiva:";
            // 
            // tbxPaPla
            // 
            this.tbxPaPla.Location = new System.Drawing.Point(147, 16);
            this.tbxPaPla.Name = "tbxPaPla";
            this.tbxPaPla.Size = new System.Drawing.Size(152, 20);
            this.tbxPaPla.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Paradas Planejadas:";
            // 
            // gbxCapRe
            // 
            this.gbxCapRe.Controls.Add(this.btnCalcular4);
            this.gbxCapRe.Controls.Add(this.lblInEf);
            this.gbxCapRe.Controls.Add(this.label15);
            this.gbxCapRe.Controls.Add(this.lblCapRe);
            this.gbxCapRe.Controls.Add(this.label18);
            this.gbxCapRe.Controls.Add(this.tbxPaNa);
            this.gbxCapRe.Controls.Add(this.label19);
            this.gbxCapRe.Location = new System.Drawing.Point(56, 39);
            this.gbxCapRe.Name = "gbxCapRe";
            this.gbxCapRe.Size = new System.Drawing.Size(363, 189);
            this.gbxCapRe.TabIndex = 15;
            this.gbxCapRe.TabStop = false;
            this.gbxCapRe.Visible = false;
            // 
            // btnCalcular4
            // 
            this.btnCalcular4.Location = new System.Drawing.Point(236, 82);
            this.btnCalcular4.Name = "btnCalcular4";
            this.btnCalcular4.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular4.TabIndex = 6;
            this.btnCalcular4.Text = "Calcular";
            this.btnCalcular4.UseVisualStyleBackColor = true;
            this.btnCalcular4.Click += new System.EventHandler(this.btnCalcular4_Click);
            // 
            // lblInEf
            // 
            this.lblInEf.AutoSize = true;
            this.lblInEf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInEf.Location = new System.Drawing.Point(168, 107);
            this.lblInEf.Name = "lblInEf";
            this.lblInEf.Size = new System.Drawing.Size(14, 16);
            this.lblInEf.TabIndex = 5;
            this.lblInEf.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Índice de Eficiência:";
            // 
            // lblCapRe
            // 
            this.lblCapRe.AutoSize = true;
            this.lblCapRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapRe.Location = new System.Drawing.Point(168, 70);
            this.lblCapRe.Name = "lblCapRe";
            this.lblCapRe.Size = new System.Drawing.Size(14, 16);
            this.lblCapRe.TabIndex = 3;
            this.lblCapRe.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Capacidade Realizada:";
            // 
            // tbxPaNa
            // 
            this.tbxPaNa.Location = new System.Drawing.Point(171, 16);
            this.tbxPaNa.Name = "tbxPaNa";
            this.tbxPaNa.Size = new System.Drawing.Size(152, 20);
            this.tbxPaNa.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Paradas Não Planejadas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "Voltar";
            this.pictureBox1.AccessibleName = "Voltar";
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleDescription = "Salvar Dados";
            this.pictureBox2.AccessibleName = "Salvar Dados";
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(425, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 43);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 243);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxCapRe);
            this.Controls.Add(this.gbxCapEf);
            this.Controls.Add(this.gbxGrau);
            this.Controls.Add(this.gbxCapDisp);
            this.Controls.Add(this.gbxCapInst);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.gbxCapInst.ResumeLayout(false);
            this.gbxCapInst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.gbxCapDisp.ResumeLayout(false);
            this.gbxCapDisp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnos)).EndInit();
            this.gbxGrau.ResumeLayout(false);
            this.gbxGrau.PerformLayout();
            this.gbxCapEf.ResumeLayout(false);
            this.gbxCapEf.PerformLayout();
            this.gbxCapRe.ResumeLayout(false);
            this.gbxCapRe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbxCapInst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudProd;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.GroupBox gbxCapDisp;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.NumericUpDown nudDias2;
        private System.Windows.Forms.NumericUpDown nudHoras2;
        private System.Windows.Forms.NumericUpDown nudTurnos;
        private System.Windows.Forms.Button btnCalcular2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbxGrau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGrau;
        private System.Windows.Forms.Label lblCapDisp;
        private System.Windows.Forms.Label lblCapInst;
        private System.Windows.Forms.GroupBox gbxCapEf;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCalcular3;
        private System.Windows.Forms.Label lblGrauUt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCapEf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPaPla;
        private System.Windows.Forms.GroupBox gbxCapRe;
        private System.Windows.Forms.Button btnCalcular4;
        private System.Windows.Forms.Label lblInEf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCapRe;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxPaNa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nudQDS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}