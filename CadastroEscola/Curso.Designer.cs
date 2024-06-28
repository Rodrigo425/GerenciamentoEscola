namespace CadastroEscola
{
    partial class Curso
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
            btConsulta = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btAdicionar = new Button();
            label12 = new Label();
            txtCod = new TextBox();
            txtNomeCurso = new TextBox();
            label1 = new Label();
            dgvCurso = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCurso).BeginInit();
            SuspendLayout();
            // 
            // btConsulta
            // 
            btConsulta.BackColor = SystemColors.ButtonFace;
            btConsulta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btConsulta.Location = new Point(166, 382);
            btConsulta.Name = "btConsulta";
            btConsulta.Size = new Size(114, 43);
            btConsulta.TabIndex = 32;
            btConsulta.Text = "Consultar";
            btConsulta.UseVisualStyleBackColor = false;
            btConsulta.Click += btConsulta_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = SystemColors.ButtonFace;
            btExcluir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btExcluir.Location = new Point(522, 382);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(114, 43);
            btExcluir.TabIndex = 31;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.BackColor = SystemColors.ButtonFace;
            btAlterar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterar.Location = new Point(372, 382);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(114, 43);
            btAlterar.TabIndex = 30;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click += btAlterar_Click;
            // 
            // btAdicionar
            // 
            btAdicionar.BackColor = SystemColors.ButtonFace;
            btAdicionar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btAdicionar.Location = new Point(14, 382);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(114, 43);
            btAdicionar.TabIndex = 29;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = false;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(15, 85);
            label12.Name = "label12";
            label12.Size = new Size(73, 25);
            label12.TabIndex = 33;
            label12.Text = "Código";
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCod.Location = new Point(15, 113);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(241, 32);
            txtCod.TabIndex = 34;
            // 
            // txtNomeCurso
            // 
            txtNomeCurso.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCurso.Location = new Point(15, 192);
            txtNomeCurso.Name = "txtNomeCurso";
            txtNomeCurso.Size = new Size(241, 32);
            txtNomeCurso.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 164);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 35;
            label1.Text = "Nome do curso";
            // 
            // dgvCurso
            // 
            dgvCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurso.Location = new Point(368, 113);
            dgvCurso.Name = "dgvCurso";
            dgvCurso.RowTemplate.Height = 25;
            dgvCurso.Size = new Size(398, 194);
            dgvCurso.TabIndex = 39;
            dgvCurso.CellClick += dgvCurso_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(331, 9);
            label4.Name = "label4";
            label4.Size = new Size(96, 37);
            label4.TabIndex = 41;
            label4.Text = "Cursos";
            // 
            // Curso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 435);
            Controls.Add(label4);
            Controls.Add(dgvCurso);
            Controls.Add(txtNomeCurso);
            Controls.Add(label1);
            Controls.Add(txtCod);
            Controls.Add(label12);
            Controls.Add(btConsulta);
            Controls.Add(btExcluir);
            Controls.Add(btAlterar);
            Controls.Add(btAdicionar);
            Name = "Curso";
            Text = "Curso";
            ((System.ComponentModel.ISupportInitialize)dgvCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btConsulta;
        private Button btExcluir;
        private Button btAlterar;
        private Button btAdicionar;
        private Label label12;
        private TextBox txtCod;
        private TextBox txtNomeCurso;
        private Label label1;
        private DataGridView dgvCurso;
        private Label label4;
    }
}