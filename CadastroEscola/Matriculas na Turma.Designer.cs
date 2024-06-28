namespace CadastroEscola
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            cursoToolStripMenuItem = new ToolStripMenuItem();
            professorToolStripMenuItem = new ToolStripMenuItem();
            turmaToolStripMenuItem = new ToolStripMenuItem();
            label8 = new Label();
            label5 = new Label();
            cbAluno = new ComboBox();
            label1 = new Label();
            cbTurma = new ComboBox();
            btExcluir = new Button();
            btAlterar = new Button();
            btAdicionar = new Button();
            dgvMatricula = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatricula).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunoToolStripMenuItem, cursoToolStripMenuItem, professorToolStripMenuItem, turmaToolStripMenuItem });
            cadastroToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(84, 25);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(146, 26);
            alunoToolStripMenuItem.Text = "Aluno";
            alunoToolStripMenuItem.Click += alunoToolStripMenuItem_Click;
            // 
            // cursoToolStripMenuItem
            // 
            cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            cursoToolStripMenuItem.Size = new Size(146, 26);
            cursoToolStripMenuItem.Text = "Curso";
            cursoToolStripMenuItem.Click += cursoToolStripMenuItem_Click;
            // 
            // professorToolStripMenuItem
            // 
            professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            professorToolStripMenuItem.Size = new Size(146, 26);
            professorToolStripMenuItem.Text = "Professor";
            professorToolStripMenuItem.Click += professorToolStripMenuItem_Click;
            // 
            // turmaToolStripMenuItem
            // 
            turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            turmaToolStripMenuItem.Size = new Size(146, 26);
            turmaToolStripMenuItem.Text = "Turma";
            turmaToolStripMenuItem.Click += turmaToolStripMenuItem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(273, 38);
            label8.Name = "label8";
            label8.Size = new Size(216, 37);
            label8.TabIndex = 86;
            label8.Text = "Matriculas turma";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(90, 142);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 88;
            label5.Text = "Alunos";
            // 
            // cbAluno
            // 
            cbAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAluno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbAluno.FormattingEnabled = true;
            cbAluno.Location = new Point(90, 169);
            cbAluno.Name = "cbAluno";
            cbAluno.Size = new Size(215, 33);
            cbAluno.TabIndex = 87;
            cbAluno.Click += cbAluno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 274);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 90;
            label1.Text = "Turmas";
            // 
            // cbTurma
            // 
            cbTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTurma.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbTurma.FormattingEnabled = true;
            cbTurma.Location = new Point(90, 301);
            cbTurma.Name = "cbTurma";
            cbTurma.Size = new Size(215, 33);
            cbTurma.TabIndex = 89;
            cbTurma.Click += cbTurma_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = SystemColors.ButtonFace;
            btExcluir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btExcluir.Location = new Point(488, 395);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(114, 43);
            btExcluir.TabIndex = 93;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.BackColor = SystemColors.ButtonFace;
            btAlterar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterar.Location = new Point(338, 395);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(114, 43);
            btAlterar.TabIndex = 92;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click += btAlterar_Click;
            // 
            // btAdicionar
            // 
            btAdicionar.BackColor = SystemColors.ButtonFace;
            btAdicionar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btAdicionar.Location = new Point(90, 395);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(114, 43);
            btAdicionar.TabIndex = 91;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = false;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // dgvMatricula
            // 
            dgvMatricula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatricula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatricula.Location = new Point(338, 169);
            dgvMatricula.Name = "dgvMatricula";
            dgvMatricula.RowTemplate.Height = 25;
            dgvMatricula.Size = new Size(428, 165);
            dgvMatricula.TabIndex = 94;
            dgvMatricula.CellClick += dgvMatricula_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMatricula);
            Controls.Add(btExcluir);
            Controls.Add(btAlterar);
            Controls.Add(btAdicionar);
            Controls.Add(label1);
            Controls.Add(cbTurma);
            Controls.Add(label5);
            Controls.Add(cbAluno);
            Controls.Add(label8);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Matriculas na Turma";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatricula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem professorToolStripMenuItem;
        private ToolStripMenuItem turmaToolStripMenuItem;
        private ToolStripMenuItem cursoToolStripMenuItem;
        private Label label8;
        private Label label5;
        private ComboBox cbAluno;
        private Label label1;
        private ComboBox cbTurma;
        private Button btExcluir;
        private Button btAlterar;
        private Button btAdicionar;
        private DataGridView dgvMatricula;
    }
}