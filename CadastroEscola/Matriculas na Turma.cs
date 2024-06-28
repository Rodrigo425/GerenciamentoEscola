using CadastroEscola.Conexao;
using MySql.Data.MySqlClient;
using System.Data;

namespace CadastroEscola
{
    public partial class Form1 : Form
    {
        public MySqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
            ConsultarAlunos();
            ConsultarTurma();
            atualiza();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form janela2 = new Aluno();//Instancia 
            janela2.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form janela3 = new Curso();
            janela3.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form janela4 = new Professor();
            janela4.Show();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form janela5 = new Turma();
            janela5.Show();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int alunos = Convert.ToInt32(cbAluno.SelectedValue);
                int turma = Convert.ToInt32(cbTurma.SelectedValue);

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO alunos_matriculados_turma(idAluno, idTurma) VALUES(@aluno, @turma)";

                comando.Parameters.AddWithValue("@turma", turma);
                comando.Parameters.AddWithValue("@aluno", alunos);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados adicionados com sucesso");
                atualiza();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar \n", ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void ConsultarAlunos()
        {
            try
            {
                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                string Sql = "SELECT * FROM aluno";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(Sql, conexao);

                da.Fill(dt);


                cbAluno.DataSource = dt;
                cbAluno.DisplayMember = "nomeAluno";
                cbAluno.ValueMember = "idAluno";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar os dados \n" + ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void ConsultarTurma()
        {
            try
            {
                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                string Sql = "SELECT * FROM turma";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(Sql, conexao);

                da.Fill(dt);


                cbTurma.DataSource = dt;
                cbTurma.DisplayMember = "nomeTurma";
                cbTurma.ValueMember = "idTurma";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar os dados \n" + ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                int alunos = Convert.ToInt32(cbAluno.SelectedValue);
                int turma = Convert.ToInt32(cbTurma.SelectedValue);

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "UPDATE alunos_matriculados_turma SET idTurma = @turma WHERE idAluno = @aluno";
                comando.Parameters.AddWithValue("@turma", turma);
                comando.Parameters.AddWithValue("@aluno", alunos);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso");
                atualiza();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar \n", ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int alunos = Convert.ToInt32(cbAluno.SelectedValue);
                int turma = Convert.ToInt32(cbTurma.SelectedValue);

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM alunos_matriculados_turma WHERE idAluno = @alunos AND idTurma = @turma";

                comando.Parameters.AddWithValue("@alunos", alunos);
                comando.Parameters.AddWithValue("@turma", turma);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados excluidos com sucesso");
                atualiza();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir \n", ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void atualiza()
        {
            try
            {
                conexao = Conectar.Getconexao();

                string sql = "SELECT alunos_matriculados_turma.idMatricula, turma.nomeTurma as Turma, aluno.nomeAluno as Nome_Aluno FROM turma " +
                             "JOIN alunos_matriculados_turma ON turma.idTurma = alunos_matriculados_turma.idTurma  " +
                             "JOIN aluno ON aluno.idAluno = alunos_matriculados_turma.idAluno";

                DataTable datatable = new DataTable();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, conexao);

                dataadapter.Fill(datatable);
                dgvMatricula.DataSource = datatable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void cbAluno_Click(object sender, EventArgs e)
        {
            ConsultarAlunos();
        }

        private void cbTurma_Click(object sender, EventArgs e)
        {
            ConsultarTurma();
        }

        private void dgvMatricula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecao = dgvMatricula.Rows[index];

            int codigo = Convert.ToInt16(selecao.Cells["idMatricula"].Value);
            ConsultaCodigo(codigo);
        }
        private void ConsultaCodigo(int codigo)
        {
            try
            {

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "SELECT aluno.nomeAluno, turma.nomeTurma FROM alunos_matriculados_turma " +
                                      "JOIN aluno ON alunos_matriculados_turma.idAluno = aluno.idAluno " +
                                      "JOIN turma ON alunos_matriculados_turma.idTurma = turma.IdTurma WHERE alunos_matriculados_turma.idMatricula = @codigo";


                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Prepare();

                MySqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    cbAluno.Text = dados["nomeAluno"].ToString();
                    cbTurma.Text = dados["nomeTurma"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar \n", ex.Message);
            }
            finally { conexao.Close(); }
        }
    }
}