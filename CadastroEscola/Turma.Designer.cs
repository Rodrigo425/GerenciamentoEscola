namespace CadastroEscola
{
    partial class Turma
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
            btLimpar = new Button();
            btConsulta = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btAdicionar = new Button();
            txtNome = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtQtd = new TextBox();
            label3 = new Label();
            txtLocal = new TextBox();
            label4 = new Label();
            cbCurso = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            cbProfessor = new ComboBox();
            label8 = new Label();
            mkDataInicio = new MaskedTextBox();
            mkDataTermino = new MaskedTextBox();
            txtCod = new TextBox();
            label9 = new Label();
            dgvTurma = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTurma).BeginInit();
            SuspendLayout();
            // 
            // btLimpar
            // 
            btLimpar.BackColor = SystemColors.ButtonFace;
            btLimpar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btLimpar.Location = new Point(808, 467);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(163, 43);
            btLimpar.TabIndex = 67;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = false;
            btLimpar.Click += btLimpar_Click;
            // 
            // btConsulta
            // 
            btConsulta.BackColor = SystemColors.ButtonFace;
            btConsulta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btConsulta.Location = new Point(174, 467);
            btConsulta.Name = "btConsulta";
            btConsulta.Size = new Size(114, 43);
            btConsulta.TabIndex = 66;
            btConsulta.Text = "Consultar";
            btConsulta.UseVisualStyleBackColor = false;
            btConsulta.Click += btConsulta_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = SystemColors.ButtonFace;
            btExcluir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btExcluir.Location = new Point(528, 467);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(114, 43);
            btExcluir.TabIndex = 65;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.BackColor = SystemColors.ButtonFace;
            btAlterar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterar.Location = new Point(378, 467);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(114, 43);
            btAlterar.TabIndex = 64;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click += btAlterar_Click;
            // 
            // btAdicionar
            // 
            btAdicionar.BackColor = SystemColors.ButtonFace;
            btAdicionar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btAdicionar.Location = new Point(22, 467);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(114, 43);
            btAdicionar.TabIndex = 63;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = false;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(22, 248);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(241, 32);
            txtNome.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 220);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 68;
            label6.Text = "Nome da Turma";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 372);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 70;
            label1.Text = "Data de Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(378, 140);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 75;
            label2.Text = "Data de Término";
            // 
            // txtQtd
            // 
            txtQtd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtQtd.Location = new Point(22, 322);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(241, 32);
            txtQtd.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 294);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 77;
            label3.Text = "Quantidade Alunos";
            // 
            // txtLocal
            // 
            txtLocal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLocal.Location = new Point(378, 248);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(241, 32);
            txtLocal.TabIndex = 80;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(378, 220);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 79;
            label4.Text = "Local";
            // 
            // cbCurso
            // 
            cbCurso.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbCurso.FormattingEnabled = true;
            cbCurso.Location = new Point(378, 322);
            cbCurso.Name = "cbCurso";
            cbCurso.Size = new Size(215, 33);
            cbCurso.TabIndex = 81;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(378, 295);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 82;
            label5.Text = "Curso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(378, 373);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 84;
            label7.Text = "Professor";
            // 
            // cbProfessor
            // 
            cbProfessor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbProfessor.FormattingEnabled = true;
            cbProfessor.Location = new Point(378, 400);
            cbProfessor.Name = "cbProfessor";
            cbProfessor.Size = new Size(215, 33);
            cbProfessor.TabIndex = 83;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(376, 9);
            label8.Name = "label8";
            label8.Size = new Size(205, 37);
            label8.TabIndex = 85;
            label8.Text = "Cadastro Turma";
            // 
            // mkDataInicio
            // 
            mkDataInicio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mkDataInicio.Location = new Point(22, 400);
            mkDataInicio.Mask = "00/00/0000";
            mkDataInicio.Name = "mkDataInicio";
            mkDataInicio.Size = new Size(179, 32);
            mkDataInicio.TabIndex = 86;
            mkDataInicio.ValidatingType = typeof(DateTime);
            // 
            // mkDataTermino
            // 
            mkDataTermino.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mkDataTermino.Location = new Point(378, 168);
            mkDataTermino.Mask = "00/00/0000";
            mkDataTermino.Name = "mkDataTermino";
            mkDataTermino.Size = new Size(179, 32);
            mkDataTermino.TabIndex = 87;
            mkDataTermino.ValidatingType = typeof(DateTime);
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCod.Location = new Point(22, 168);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(241, 32);
            txtCod.TabIndex = 89;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(22, 140);
            label9.Name = "label9";
            label9.Size = new Size(73, 25);
            label9.TabIndex = 88;
            label9.Text = "Código";
            // 
            // dgvTurma
            // 
            dgvTurma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurma.Location = new Point(656, 140);
            dgvTurma.Name = "dgvTurma";
            dgvTurma.RowTemplate.Height = 25;
            dgvTurma.Size = new Size(452, 293);
            dgvTurma.TabIndex = 90;
            dgvTurma.CellClick += dgvTurma_CellClick;
            // 
            // Turma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 522);
            Controls.Add(dgvTurma);
            Controls.Add(txtCod);
            Controls.Add(label9);
            Controls.Add(mkDataTermino);
            Controls.Add(mkDataInicio);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbProfessor);
            Controls.Add(label5);
            Controls.Add(cbCurso);
            Controls.Add(txtLocal);
            Controls.Add(label4);
            Controls.Add(txtQtd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(btLimpar);
            Controls.Add(btConsulta);
            Controls.Add(btExcluir);
            Controls.Add(btAlterar);
            Controls.Add(btAdicionar);
            Name = "Turma";
            Text = "Turma";
            Load += Turma_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLimpar;
        private Button btConsulta;
        private Button btExcluir;
        private Button btAlterar;
        private Button btAdicionar;
        private TextBox txtNome;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox txtQtd;
        private Label label3;
        private TextBox txtLocal;
        private Label label4;
        private ComboBox cbCurso;
        private Label label5;
        private Label label7;
        private ComboBox cbProfessor;
        private Label label8;
        private MaskedTextBox mkDataInicio;
        private MaskedTextBox mkDataTermino;
        private TextBox txtCod;
        private Label label9;
        private DataGridView dgvTurma;
    }
}