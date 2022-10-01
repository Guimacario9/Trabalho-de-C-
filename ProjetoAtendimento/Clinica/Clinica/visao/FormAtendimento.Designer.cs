namespace Clinica.visao
{
    partial class FormAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtendimento));
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpPaciente = new System.Windows.Forms.GroupBox();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.txtIdadePaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.gbAlergia = new System.Windows.Forms.GroupBox();
            this.rbAlergicoNao = new System.Windows.Forms.RadioButton();
            this.rbAlergicoSim = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.ckMedicamentos = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ckExames = new System.Windows.Forms.CheckedListBox();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calendarioConsulta = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtConsultas = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.gbConsulta.SuspendLayout();
            this.gbAlergia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdPaciente.Location = new System.Drawing.Point(35, 193);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(57, 27);
            this.txtIdPaciente.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Selecionar paciente";
            // 
            // gpPaciente
            // 
            this.gpPaciente.Controls.Add(this.gridPacientes);
            this.gpPaciente.Controls.Add(this.txtIdadePaciente);
            this.gpPaciente.Controls.Add(this.label4);
            this.gpPaciente.Controls.Add(this.txtNomePaciente);
            this.gpPaciente.Controls.Add(this.label3);
            this.gpPaciente.Controls.Add(this.txtIdPaciente);
            this.gpPaciente.Controls.Add(this.label1);
            this.gpPaciente.Controls.Add(this.label2);
            this.gpPaciente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPaciente.Location = new System.Drawing.Point(12, 36);
            this.gpPaciente.Name = "gpPaciente";
            this.gpPaciente.Size = new System.Drawing.Size(405, 301);
            this.gpPaciente.TabIndex = 27;
            this.gpPaciente.TabStop = false;
            this.gpPaciente.Text = "Paciente";
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridPacientes.Location = new System.Drawing.Point(35, 48);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPacientes.Size = new System.Drawing.Size(333, 112);
            this.gridPacientes.TabIndex = 31;
            this.gridPacientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPacientes_CellMouseClick);
            // 
            // txtIdadePaciente
            // 
            this.txtIdadePaciente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdadePaciente.Location = new System.Drawing.Point(111, 193);
            this.txtIdadePaciente.Name = "txtIdadePaciente";
            this.txtIdadePaciente.Size = new System.Drawing.Size(71, 27);
            this.txtIdadePaciente.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Idade";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomePaciente.Location = new System.Drawing.Point(210, 193);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(158, 27);
            this.txtNomePaciente.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nome";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.gbAlergia);
            this.gbConsulta.Controls.Add(this.label10);
            this.gbConsulta.Controls.Add(this.ckMedicamentos);
            this.gbConsulta.Controls.Add(this.label9);
            this.gbConsulta.Controls.Add(this.ckExames);
            this.gbConsulta.Controls.Add(this.cbMedico);
            this.gbConsulta.Controls.Add(this.label8);
            this.gbConsulta.Controls.Add(this.txtHistorico);
            this.gbConsulta.Controls.Add(this.label7);
            this.gbConsulta.Controls.Add(this.calendarioConsulta);
            this.gbConsulta.Controls.Add(this.label6);
            this.gbConsulta.Controls.Add(this.txtIdConsulta);
            this.gbConsulta.Controls.Add(this.label5);
            this.gbConsulta.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(438, 36);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(850, 301);
            this.gbConsulta.TabIndex = 28;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta";
            // 
            // gbAlergia
            // 
            this.gbAlergia.Controls.Add(this.rbAlergicoNao);
            this.gbAlergia.Controls.Add(this.rbAlergicoSim);
            this.gbAlergia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlergia.Location = new System.Drawing.Point(527, 213);
            this.gbAlergia.Name = "gbAlergia";
            this.gbAlergia.Size = new System.Drawing.Size(149, 66);
            this.gbAlergia.TabIndex = 42;
            this.gbAlergia.TabStop = false;
            this.gbAlergia.Text = "Alérgico";
            // 
            // rbAlergicoNao
            // 
            this.rbAlergicoNao.AutoSize = true;
            this.rbAlergicoNao.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlergicoNao.Location = new System.Drawing.Point(83, 28);
            this.rbAlergicoNao.Name = "rbAlergicoNao";
            this.rbAlergicoNao.Size = new System.Drawing.Size(46, 19);
            this.rbAlergicoNao.TabIndex = 1;
            this.rbAlergicoNao.TabStop = true;
            this.rbAlergicoNao.Text = "Nao";
            this.rbAlergicoNao.UseVisualStyleBackColor = true;
            // 
            // rbAlergicoSim
            // 
            this.rbAlergicoSim.AutoSize = true;
            this.rbAlergicoSim.Location = new System.Drawing.Point(15, 28);
            this.rbAlergicoSim.Name = "rbAlergicoSim";
            this.rbAlergicoSim.Size = new System.Drawing.Size(51, 22);
            this.rbAlergicoSim.TabIndex = 0;
            this.rbAlergicoSim.TabStop = true;
            this.rbAlergicoSim.Text = "Sim";
            this.rbAlergicoSim.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(701, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Medicamentos";
            // 
            // ckMedicamentos
            // 
            this.ckMedicamentos.FormattingEnabled = true;
            this.ckMedicamentos.Items.AddRange(new object[] {
            "Amoxicilina",
            "Aspirina",
            "Complexo B",
            "Diclofenaco Sódico",
            "Dipirona",
            "Insulina",
            "Ibuprofeno",
            "Nimesulida",
            "Paracetamol",
            "Polivitamínico"});
            this.ckMedicamentos.Location = new System.Drawing.Point(705, 53);
            this.ckMedicamentos.Name = "ckMedicamentos";
            this.ckMedicamentos.Size = new System.Drawing.Size(127, 144);
            this.ckMedicamentos.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(539, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Exames";
            // 
            // ckExames
            // 
            this.ckExames.FormattingEnabled = true;
            this.ckExames.Items.AddRange(new object[] {
            "Audiometria",
            "Ecografia Tridimensional",
            "Ecodopler",
            "Eletrocardiograma",
            "Exame",
            "Laboratorial Completo",
            "Raio X do Torax",
            "Raio X Abdômen",
            "Ultra-sonografia"});
            this.ckExames.Location = new System.Drawing.Point(542, 51);
            this.ckExames.Name = "ckExames";
            this.ckExames.Size = new System.Drawing.Size(149, 144);
            this.ckExames.TabIndex = 37;
            // 
            // cbMedico
            // 
            this.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Items.AddRange(new object[] {
            "Dr. Alexandre",
            "Dra. Cássia",
            "Dr. Braga",
            "Dr. Rubens"});
            this.cbMedico.Location = new System.Drawing.Point(332, 240);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(169, 22);
            this.cbMedico.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(261, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Médico";
            // 
            // txtHistorico
            // 
            this.txtHistorico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHistorico.Location = new System.Drawing.Point(265, 115);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(236, 98);
            this.txtHistorico.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Histórico";
            // 
            // calendarioConsulta
            // 
            this.calendarioConsulta.Location = new System.Drawing.Point(12, 51);
            this.calendarioConsulta.Name = "calendarioConsulta";
            this.calendarioConsulta.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Data da Consulta";
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdConsulta.Location = new System.Drawing.Point(298, 51);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(88, 19);
            this.txtIdConsulta.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID ";
            // 
            // dtConsultas
            // 
            this.dtConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConsultas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtConsultas.Location = new System.Drawing.Point(438, 354);
            this.dtConsultas.Name = "dtConsultas";
            this.dtConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtConsultas.Size = new System.Drawing.Size(850, 150);
            this.dtConsultas.TabIndex = 30;
            this.dtConsultas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtConsultas_CellMouseClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(222, 453);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 33);
            this.btnLimpar.TabIndex = 37;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(88, 455);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 31);
            this.btnExcluir.TabIndex = 36;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(222, 391);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(106, 34);
            this.btnAtualizar.TabIndex = 35;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(88, 391);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 34);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 537);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1305, 26);
            this.statusBar.TabIndex = 38;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 21);
            this.toolStripStatusLabel1.Text = "Barra de Status";
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1305, 563);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtConsultas);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.gpPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.gpPaciente.ResumeLayout(false);
            this.gpPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.gbAlergia.ResumeLayout(false);
            this.gbAlergia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpPaciente;
        private System.Windows.Forms.TextBox txtIdadePaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.TextBox txtIdConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar calendarioConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.GroupBox gbAlergia;
        private System.Windows.Forms.RadioButton rbAlergicoNao;
        private System.Windows.Forms.RadioButton rbAlergicoSim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox ckMedicamentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox ckExames;
        private System.Windows.Forms.DataGridView dtConsultas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}