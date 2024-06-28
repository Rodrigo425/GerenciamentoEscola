namespace CadastroEscola
{
    partial class Professor
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
            dgvProf = new DataGridView();
            txtNome = new TextBox();
            label12 = new Label();
            txtEndereco = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            mkDataNasc = new MaskedTextBox();
            mkTel = new MaskedTextBox();
            label7 = new Label();
            label5 = new Label();
            txtFormacao = new TextBox();
            label3 = new Label();
            btBuscarFoto = new Button();
            pictureBox = new PictureBox();
            btConsulta = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btAdicionar = new Button();
            label4 = new Label();
            txtCod = new TextBox();
            label6 = new Label();
            btLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // dgvProf
            // 
            dgvProf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProf.Location = new Point(12, 433);
            dgvProf.Name = "dgvProf";
            dgvProf.RowTemplate.Height = 25;
            dgvProf.Size = new Size(882, 194);
            dgvProf.TabIndex = 42;
            dgvProf.CellClick += dgvProf_CellClick;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(12, 187);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(241, 32);
            txtNome.TabIndex = 41;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(12, 159);
            label12.Name = "label12";
            label12.Size = new Size(68, 25);
            label12.TabIndex = 40;
            label12.Text = "Nome ";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(12, 262);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(241, 32);
            txtEndereco.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 234);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 43;
            label1.Text = "Endereço";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(12, 337);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 32);
            txtEmail.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 309);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 45;
            label2.Text = "E-mail";
            // 
            // mkDataNasc
            // 
            mkDataNasc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mkDataNasc.Location = new Point(350, 187);
            mkDataNasc.Mask = "00/00/0000";
            mkDataNasc.Name = "mkDataNasc";
            mkDataNasc.Size = new Size(179, 32);
            mkDataNasc.TabIndex = 50;
            mkDataNasc.ValidatingType = typeof(DateTime);
            // 
            // mkTel
            // 
            mkTel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mkTel.Location = new Point(350, 262);
            mkTel.Mask = "(00)00000-0000";
            mkTel.Name = "mkTel";
            mkTel.Size = new Size(156, 32);
            mkTel.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(350, 234);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 48;
            label7.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(350, 159);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 47;
            label5.Text = "Data de nascimento";
            // 
            // txtFormacao
            // 
            txtFormacao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtFormacao.Location = new Point(350, 112);
            txtFormacao.Name = "txtFormacao";
            txtFormacao.Size = new Size(241, 32);
            txtFormacao.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(350, 84);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 51;
            label3.Text = "Formação";
            // 
            // btBuscarFoto
            // 
            btBuscarFoto.BackColor = SystemColors.ButtonFace;
            btBuscarFoto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscarFoto.Location = new Point(694, 363);
            btBuscarFoto.Name = "btBuscarFoto";
            btBuscarFoto.Size = new Size(200, 43);
            btBuscarFoto.TabIndex = 54;
            btBuscarFoto.Text = "Buscar Foto";
            btBuscarFoto.UseVisualStyleBackColor = false;
            btBuscarFoto.Click += btBuscarFoto_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(694, 112);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(200, 242);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 53;
            pictureBox.TabStop = false;
            // 
            // btConsulta
            // 
            btConsulta.BackColor = SystemColors.ButtonFace;
            btConsulta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btConsulta.Location = new Point(164, 655);
            btConsulta.Name = "btConsulta";
            btConsulta.Size = new Size(114, 43);
            btConsulta.TabIndex = 58;
            btConsulta.Text = "Consultar";
            btConsulta.UseVisualStyleBackColor = false;
            btConsulta.Click += btConsulta_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = SystemColors.ButtonFace;
            btExcluir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btExcluir.Location = new Point(500, 655);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(114, 43);
            btExcluir.TabIndex = 57;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.BackColor = SystemColors.ButtonFace;
            btAlterar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterar.Location = new Point(350, 655);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(114, 43);
            btAlterar.TabIndex = 56;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click += btAlterar_Click;
            // 
            // btAdicionar
            // 
            btAdicionar.BackColor = SystemColors.ButtonFace;
            btAdicionar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btAdicionar.Location = new Point(12, 655);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(114, 43);
            btAdicionar.TabIndex = 55;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = false;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(364, 21);
            label4.Name = "label4";
            label4.Size = new Size(126, 37);
            label4.TabIndex = 59;
            label4.Text = "Professor";
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCod.Location = new Point(12, 112);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(241, 32);
            txtCod.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 84);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 60;
            label6.Text = "Código";
            // 
            // btLimpar
            // 
            btLimpar.BackColor = SystemColors.ButtonFace;
            btLimpar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btLimpar.Location = new Point(694, 655);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(114, 43);
            btLimpar.TabIndex = 62;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = false;
            btLimpar.Click += btLimpar_Click;
            // 
            // Professor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 708);
            Controls.Add(btLimpar);
            Controls.Add(txtCod);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btConsulta);
            Controls.Add(btExcluir);
            Controls.Add(btAlterar);
            Controls.Add(btAdicionar);
            Controls.Add(btBuscarFoto);
            Controls.Add(pictureBox);
            Controls.Add(txtFormacao);
            Controls.Add(label3);
            Controls.Add(mkDataNasc);
            Controls.Add(mkTel);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtEndereco);
            Controls.Add(label1);
            Controls.Add(dgvProf);
            Controls.Add(txtNome);
            Controls.Add(label12);
            Name = "Professor";
            Text = "Professor";
            Load += Professor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProf;
        private TextBox txtNome;
        private Label label12;
        private TextBox txtEndereco;
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private MaskedTextBox mkDataNasc;
        private MaskedTextBox mkTel;
        private Label label7;
        private Label label5;
        private TextBox txtFormacao;
        private Label label3;
        private Button btBuscarFoto;
        private PictureBox pictureBox;
        private Button btConsulta;
        private Button btExcluir;
        private Button btAlterar;
        private Button btAdicionar;
        private Label label4;
        private TextBox txtCod;
        private Label label6;
        private Button btLimpar;
    }
}