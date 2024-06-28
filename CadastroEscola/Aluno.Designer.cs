namespace CadastroEscola
{
    partial class Aluno
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNomeAluno = new TextBox();
            mkRgAluno = new MaskedTextBox();
            mkCpfAluno = new MaskedTextBox();
            mkTelAluno = new MaskedTextBox();
            mkTelResposavel = new MaskedTextBox();
            mkDataNascAluno = new MaskedTextBox();
            txtEnderecoAluno = new TextBox();
            txtEmailAluno = new TextBox();
            txtNomeResponsavel = new TextBox();
            pictureBox = new PictureBox();
            dgvAlunos = new DataGridView();
            btAdicionar = new Button();
            btAlterar = new Button();
            btExcluir = new Button();
            btBuscarFoto = new Button();
            txtCod = new TextBox();
            label12 = new Label();
            btConsulta = new Button();
            btLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(350, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 218);
            label3.Name = "label3";
            label3.Size = new Size(36, 25);
            label3.TabIndex = 2;
            label3.Text = "RG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 290);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 3;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(350, 152);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 4;
            label5.Text = "Data de nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(350, 222);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 5;
            label6.Text = "Endereço";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 361);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 6;
            label7.Text = "Telefone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(350, 82);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 7;
            label8.Text = "E-mail";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(350, 290);
            label9.Name = "label9";
            label9.Size = new Size(187, 25);
            label9.TabIndex = 8;
            label9.Text = "Nome do reponsável";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(350, 361);
            label10.Name = "label10";
            label10.Size = new Size(218, 25);
            label10.TabIndex = 9;
            label10.Text = "Telefone do Responsável";
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeAluno.Location = new Point(12, 179);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(241, 32);
            txtNomeAluno.TabIndex = 10;
            // 
            // mkRgAluno
            // 
            mkRgAluno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mkRgAluno.Location = new Point(12, 249);
            mkRgAluno.Mask = "00-000-000-0";
            mkRgAluno.Name = "mkRgAluno";
            mkRgAluno.Size = new Size(156, 32);
            mkRgAluno.TabIndex = 11;
            // 
            // mkCpfAluno
            // 
            mkCpfAluno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mkCpfAluno.Location = new Point(12, 318);
            mkCpfAluno.Mask = "000000000-00";
            mkCpfAluno.Name = "mkCpfAluno";
            mkCpfAluno.Size = new Size(156, 32);
            mkCpfAluno.TabIndex = 12;
            // 
            // mkTelAluno
            // 
            mkTelAluno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mkTelAluno.Location = new Point(12, 389);
            mkTelAluno.Mask = "(00)00000-0000";
            mkTelAluno.Name = "mkTelAluno";
            mkTelAluno.Size = new Size(156, 32);
            mkTelAluno.TabIndex = 13;
            // 
            // mkTelResposavel
            // 
            mkTelResposavel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mkTelResposavel.Location = new Point(350, 389);
            mkTelResposavel.Mask = "(00)00000-0000";
            mkTelResposavel.Name = "mkTelResposavel";
            mkTelResposavel.Size = new Size(160, 32);
            mkTelResposavel.TabIndex = 14;
            // 
            // mkDataNascAluno
            // 
            mkDataNascAluno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mkDataNascAluno.Location = new Point(350, 180);
            mkDataNascAluno.Mask = "00/00/0000";
            mkDataNascAluno.Name = "mkDataNascAluno";
            mkDataNascAluno.Size = new Size(179, 32);
            mkDataNascAluno.TabIndex = 15;
            mkDataNascAluno.ValidatingType = typeof(DateTime);
            // 
            // txtEnderecoAluno
            // 
            txtEnderecoAluno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnderecoAluno.Location = new Point(350, 249);
            txtEnderecoAluno.Name = "txtEnderecoAluno";
            txtEnderecoAluno.Size = new Size(241, 32);
            txtEnderecoAluno.TabIndex = 16;
            // 
            // txtEmailAluno
            // 
            txtEmailAluno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailAluno.Location = new Point(350, 110);
            txtEmailAluno.Name = "txtEmailAluno";
            txtEmailAluno.Size = new Size(241, 32);
            txtEmailAluno.TabIndex = 17;
            // 
            // txtNomeResponsavel
            // 
            txtNomeResponsavel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeResponsavel.Location = new Point(350, 318);
            txtNomeResponsavel.Name = "txtNomeResponsavel";
            txtNomeResponsavel.Size = new Size(241, 32);
            txtNomeResponsavel.TabIndex = 18;
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(674, 110);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(200, 242);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 19;
            pictureBox.TabStop = false;
            // 
            // dgvAlunos
            // 
            dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(12, 445);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.RowTemplate.Height = 25;
            dgvAlunos.Size = new Size(861, 151);
            dgvAlunos.TabIndex = 20;
            dgvAlunos.CellClick += dgvAlunos_CellClick;
            // 
            // btAdicionar
            // 
            btAdicionar.BackColor = SystemColors.ButtonFace;
            btAdicionar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btAdicionar.Location = new Point(12, 611);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(114, 43);
            btAdicionar.TabIndex = 21;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = false;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btAlterar
            // 
            btAlterar.BackColor = SystemColors.ButtonFace;
            btAlterar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterar.Location = new Point(350, 611);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(114, 43);
            btAlterar.TabIndex = 22;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click += btAlterar_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = SystemColors.ButtonFace;
            btExcluir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btExcluir.Location = new Point(500, 611);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(114, 43);
            btExcluir.TabIndex = 23;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // btBuscarFoto
            // 
            btBuscarFoto.BackColor = SystemColors.ButtonFace;
            btBuscarFoto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarFoto.Location = new Point(674, 361);
            btBuscarFoto.Name = "btBuscarFoto";
            btBuscarFoto.Size = new Size(200, 43);
            btBuscarFoto.TabIndex = 24;
            btBuscarFoto.Text = "Buscar Foto";
            btBuscarFoto.UseVisualStyleBackColor = false;
            btBuscarFoto.Click += btBuscarFoto_Click;
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCod.Location = new Point(12, 110);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(241, 32);
            txtCod.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(12, 82);
            label12.Name = "label12";
            label12.Size = new Size(73, 25);
            label12.TabIndex = 25;
            label12.Text = "Código";
            // 
            // btConsulta
            // 
            btConsulta.BackColor = SystemColors.ButtonFace;
            btConsulta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btConsulta.Location = new Point(164, 611);
            btConsulta.Name = "btConsulta";
            btConsulta.Size = new Size(114, 43);
            btConsulta.TabIndex = 28;
            btConsulta.Text = "Consultar";
            btConsulta.UseVisualStyleBackColor = false;
            btConsulta.Click += btConsulta_Click;
            // 
            // btLimpar
            // 
            btLimpar.BackColor = SystemColors.ButtonFace;
            btLimpar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btLimpar.Location = new Point(674, 611);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(114, 43);
            btLimpar.TabIndex = 63;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = false;
            btLimpar.Click += btLimpar_Click;
            // 
            // Aluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 663);
            Controls.Add(btLimpar);
            Controls.Add(btConsulta);
            Controls.Add(txtCod);
            Controls.Add(label12);
            Controls.Add(btBuscarFoto);
            Controls.Add(btExcluir);
            Controls.Add(btAlterar);
            Controls.Add(btAdicionar);
            Controls.Add(dgvAlunos);
            Controls.Add(pictureBox);
            Controls.Add(txtNomeResponsavel);
            Controls.Add(txtEmailAluno);
            Controls.Add(txtEnderecoAluno);
            Controls.Add(mkDataNascAluno);
            Controls.Add(mkTelResposavel);
            Controls.Add(mkTelAluno);
            Controls.Add(mkCpfAluno);
            Controls.Add(mkRgAluno);
            Controls.Add(txtNomeAluno);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Aluno";
            Text = "Aluno";
            Load += Aluno_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtNomeAluno;
        private MaskedTextBox mkRgAluno;
        private MaskedTextBox mkCpfAluno;
        private MaskedTextBox mkTelAluno;
        private MaskedTextBox mkTelResposavel;
        private MaskedTextBox mkDataNascAluno;
        private TextBox txtEnderecoAluno;
        private TextBox txtEmailAluno;
        private TextBox txtNomeResponsavel;
        private PictureBox pictureBox;
        private DataGridView dgvAlunos;
        private Button btAdicionar;
        private Button btAlterar;
        private Button btExcluir;
        private Button btBuscarFoto;
        private TextBox txtCod;
        private Label label12;
        private Button btConsulta;
        private Button btLimpar;
    }
}