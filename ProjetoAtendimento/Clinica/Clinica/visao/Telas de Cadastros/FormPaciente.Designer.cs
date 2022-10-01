namespace Clinica.visao
{
    partial class FormPaciente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaciente));
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.gbSangue = new System.Windows.Forms.GroupBox();
            this.rbTipoOmenos = new System.Windows.Forms.RadioButton();
            this.rbTipoABmenos = new System.Windows.Forms.RadioButton();
            this.rbTipoBmenos = new System.Windows.Forms.RadioButton();
            this.rbTipoAmenos = new System.Windows.Forms.RadioButton();
            this.rbTipoOmais = new System.Windows.Forms.RadioButton();
            this.rbTipoABmais = new System.Windows.Forms.RadioButton();
            this.rbTipoBmais = new System.Windows.Forms.RadioButton();
            this.rbTipoAmais = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbConvenio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calendarioPaciente = new System.Windows.Forms.MonthCalendar();
            this.cbProfissao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.timerLogin = new System.Windows.Forms.Timer(this.components);
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbSexo.SuspendLayout();
            this.gbSangue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtId.Location = new System.Drawing.Point(74, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 20);
            this.txtId.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(74, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelefone.Location = new System.Drawing.Point(74, 72);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(256, 20);
            this.txtTelefone.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(18, 26);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(94, 23);
            this.rbMasculino.TabIndex = 13;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeminino.Location = new System.Drawing.Point(18, 56);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(86, 23);
            this.rbFeminino.TabIndex = 14;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(87, 159);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(118, 83);
            this.gbSexo.TabIndex = 15;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // gbSangue
            // 
            this.gbSangue.Controls.Add(this.rbTipoOmenos);
            this.gbSangue.Controls.Add(this.rbTipoABmenos);
            this.gbSangue.Controls.Add(this.rbTipoBmenos);
            this.gbSangue.Controls.Add(this.rbTipoAmenos);
            this.gbSangue.Controls.Add(this.rbTipoOmais);
            this.gbSangue.Controls.Add(this.rbTipoABmais);
            this.gbSangue.Controls.Add(this.rbTipoBmais);
            this.gbSangue.Controls.Add(this.rbTipoAmais);
            this.gbSangue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSangue.Location = new System.Drawing.Point(227, 105);
            this.gbSangue.Name = "gbSangue";
            this.gbSangue.Size = new System.Drawing.Size(158, 166);
            this.gbSangue.TabIndex = 16;
            this.gbSangue.TabStop = false;
            this.gbSangue.Text = "Tipo Sanguineo";
            // 
            // rbTipoOmenos
            // 
            this.rbTipoOmenos.AutoSize = true;
            this.rbTipoOmenos.Location = new System.Drawing.Point(91, 97);
            this.rbTipoOmenos.Name = "rbTipoOmenos";
            this.rbTipoOmenos.Size = new System.Drawing.Size(43, 23);
            this.rbTipoOmenos.TabIndex = 20;
            this.rbTipoOmenos.TabStop = true;
            this.rbTipoOmenos.Text = "O-";
            this.rbTipoOmenos.UseVisualStyleBackColor = true;
            // 
            // rbTipoABmenos
            // 
            this.rbTipoABmenos.AutoSize = true;
            this.rbTipoABmenos.Location = new System.Drawing.Point(91, 39);
            this.rbTipoABmenos.Name = "rbTipoABmenos";
            this.rbTipoABmenos.Size = new System.Drawing.Size(50, 23);
            this.rbTipoABmenos.TabIndex = 19;
            this.rbTipoABmenos.TabStop = true;
            this.rbTipoABmenos.Text = "AB-";
            this.rbTipoABmenos.UseVisualStyleBackColor = true;
            // 
            // rbTipoBmenos
            // 
            this.rbTipoBmenos.AutoSize = true;
            this.rbTipoBmenos.Location = new System.Drawing.Point(13, 126);
            this.rbTipoBmenos.Name = "rbTipoBmenos";
            this.rbTipoBmenos.Size = new System.Drawing.Size(41, 23);
            this.rbTipoBmenos.TabIndex = 18;
            this.rbTipoBmenos.TabStop = true;
            this.rbTipoBmenos.Text = "B-";
            this.rbTipoBmenos.UseVisualStyleBackColor = true;
            // 
            // rbTipoAmenos
            // 
            this.rbTipoAmenos.AutoSize = true;
            this.rbTipoAmenos.Location = new System.Drawing.Point(13, 68);
            this.rbTipoAmenos.Name = "rbTipoAmenos";
            this.rbTipoAmenos.Size = new System.Drawing.Size(41, 23);
            this.rbTipoAmenos.TabIndex = 17;
            this.rbTipoAmenos.TabStop = true;
            this.rbTipoAmenos.Text = "A-";
            this.rbTipoAmenos.UseVisualStyleBackColor = true;
            // 
            // rbTipoOmais
            // 
            this.rbTipoOmais.AutoSize = true;
            this.rbTipoOmais.Location = new System.Drawing.Point(91, 126);
            this.rbTipoOmais.Name = "rbTipoOmais";
            this.rbTipoOmais.Size = new System.Drawing.Size(46, 23);
            this.rbTipoOmais.TabIndex = 16;
            this.rbTipoOmais.TabStop = true;
            this.rbTipoOmais.Text = "O+";
            this.rbTipoOmais.UseVisualStyleBackColor = true;
            // 
            // rbTipoABmais
            // 
            this.rbTipoABmais.AutoSize = true;
            this.rbTipoABmais.Location = new System.Drawing.Point(91, 68);
            this.rbTipoABmais.Name = "rbTipoABmais";
            this.rbTipoABmais.Size = new System.Drawing.Size(53, 23);
            this.rbTipoABmais.TabIndex = 15;
            this.rbTipoABmais.TabStop = true;
            this.rbTipoABmais.Text = "AB+";
            this.rbTipoABmais.UseVisualStyleBackColor = true;
            // 
            // rbTipoBmais
            // 
            this.rbTipoBmais.AutoSize = true;
            this.rbTipoBmais.Location = new System.Drawing.Point(13, 97);
            this.rbTipoBmais.Name = "rbTipoBmais";
            this.rbTipoBmais.Size = new System.Drawing.Size(44, 23);
            this.rbTipoBmais.TabIndex = 14;
            this.rbTipoBmais.TabStop = true;
            this.rbTipoBmais.Text = "B+";
            this.rbTipoBmais.UseVisualStyleBackColor = true;
            // 
            // rbTipoAmais
            // 
            this.rbTipoAmais.AutoSize = true;
            this.rbTipoAmais.Location = new System.Drawing.Point(13, 39);
            this.rbTipoAmais.Name = "rbTipoAmais";
            this.rbTipoAmais.Size = new System.Drawing.Size(44, 23);
            this.rbTipoAmais.TabIndex = 13;
            this.rbTipoAmais.TabStop = true;
            this.rbTipoAmais.Text = "A+";
            this.rbTipoAmais.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Convenio";
            // 
            // cbConvenio
            // 
            this.cbConvenio.BackColor = System.Drawing.SystemColors.Window;
            this.cbConvenio.DisplayMember = "Convenios";
            this.cbConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConvenio.FormattingEnabled = true;
            this.cbConvenio.Items.AddRange(new object[] {
            "Unimed",
            "Sao lucas",
            "Fusex",
            "Saude Bradesco"});
            this.cbConvenio.Location = new System.Drawing.Point(87, 105);
            this.cbConvenio.Name = "cbConvenio";
            this.cbConvenio.Size = new System.Drawing.Size(134, 21);
            this.cbConvenio.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data de Nascimento";
            // 
            // calendarioPaciente
            // 
            this.calendarioPaciente.Location = new System.Drawing.Point(406, 48);
            this.calendarioPaciente.Name = "calendarioPaciente";
            this.calendarioPaciente.TabIndex = 22;
            this.calendarioPaciente.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarioPaciente_DateChanged);
            // 
            // cbProfissao
            // 
            this.cbProfissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfissao.FormattingEnabled = true;
            this.cbProfissao.Items.AddRange(new object[] {
            "Advogado ",
            "Analista de Sistema, ",
            "Biólogo",
            "Comerciante",
            "Engenheiro Civil",
            "Jornalista",
            "Outros"});
            this.cbProfissao.Location = new System.Drawing.Point(87, 132);
            this.cbProfissao.Name = "cbProfissao";
            this.cbProfissao.Size = new System.Drawing.Size(134, 21);
            this.cbProfissao.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Profissao";
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridPacientes.Location = new System.Drawing.Point(17, 279);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPacientes.Size = new System.Drawing.Size(633, 131);
            this.gridPacientes.TabIndex = 25;
            this.gridPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPacientes_CellContentClick);
            this.gridPacientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPacientes_CellMouseClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(34, 428);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 31);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // timerLogin
            // 
            this.timerLogin.Enabled = true;
            this.timerLogin.Interval = 1000;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(161, 428);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(116, 31);
            this.btnSelecionar.TabIndex = 27;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(294, 428);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(106, 31);
            this.btnAtualizar.TabIndex = 28;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(420, 428);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 31);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(544, 428);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 31);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 459);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(664, 26);
            this.statusBar.TabIndex = 31;
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
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 485);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gridPacientes);
            this.Controls.Add(this.cbProfissao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calendarioPaciente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbConvenio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbSangue);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbSangue.ResumeLayout(false);
            this.gbSangue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.GroupBox gbSangue;
        private System.Windows.Forms.RadioButton rbTipoOmais;
        private System.Windows.Forms.RadioButton rbTipoABmais;
        private System.Windows.Forms.RadioButton rbTipoBmais;
        private System.Windows.Forms.RadioButton rbTipoAmais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbConvenio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar calendarioPaciente;
        private System.Windows.Forms.ComboBox cbProfissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Timer timerLogin;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton rbTipoOmenos;
        private System.Windows.Forms.RadioButton rbTipoABmenos;
        private System.Windows.Forms.RadioButton rbTipoBmenos;
        private System.Windows.Forms.RadioButton rbTipoAmenos;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}