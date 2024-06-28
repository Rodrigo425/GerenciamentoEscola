using CadastroEscola.Conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroEscola
{
    public partial class Turma : Form
    {
        public MySqlConnection conexao;
        public Turma()
        {
            InitializeComponent();
            ConsultarCursos();
            ConsultarProfessores();
            txtCod.Enabled = false;
        }

        private void Turma_Load(object sender, EventArgs e)
        {
            atualiza();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string quantidade = txtQtd.Text;
            string local = txtLocal.Text;
            DateTime datainicio = Convert.ToDateTime(mkDataInicio.Text);
            DateTime datatermino = Convert.ToDateTime(mkDataTermino.Text);
            int curso = Convert.ToInt32(cbCurso.SelectedValue);
            int professor = Convert.ToInt32(cbProfessor.SelectedValue);
            try
            {
                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO turma(nomeTurma, maximoAlunosTurma, localidade, dataInicio, dataFim, idcurso, idprofessor) " +
                                      "VALUES(@nome, @quantidade, @local, @datainicio, @datatermino, @curso, @professor)";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@quantidade", quantidade);
                comando.Parameters.AddWithValue("@local", local);
                comando.Parameters.AddWithValue("@datainicio", datainicio);
                comando.Parameters.AddWithValue("@datatermino", datatermino);
                comando.Parameters.AddWithValue("@curso", curso);
                comando.Parameters.AddWithValue("@professor", professor);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados gravados com sucesso");
                atualiza();
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar \n", ex.Message);
            }
            finally { conexao.Close(); }
        }
        private void ConsultarCursos()
        {
            try
            {
                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                string Sql = "SELECT * FROM curso";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(Sql, conexao);

                da.Fill(dt);


                cbCurso.DataSource = dt;
                cbCurso.DisplayMember = "curso";
                cbCurso.ValueMember = "idCurso";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar os dados \n" + ex.Message);
            }
            finally { conexao.Close(); }
        }
        private void ConsultarProfessores()
        {
            try
            {
                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                string Sql = "SELECT * FROM professor";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(Sql, conexao);

                da.Fill(dt);


                cbProfessor.DataSource = dt;
                cbProfessor.DisplayMember = "nome";
                cbProfessor.ValueMember = "idProfessor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar os dados \n" + ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            if (txtCod.Enabled == false)
            {
                txtCod.Enabled = true;
            }
            else
            {
                int codigo = Convert.ToInt16(txtCod.Text);
                ConsultaCodigo(codigo);
            }
        }
        private void ConsultaCodigo(int codigo)
        {
            try
            {

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "SELECT turma.idTurma, turma.nomeTurma AS Turma , professor.nome AS Professor, curso.curso AS Curso, turma.localidade AS Local, turma.maximoAlunosTurma AS Qtd_Alunos, turma.dataInicio AS Inicio, turma.dataFim AS Termino FROM turma " +
                                      "JOIN professor ON turma.idProfessor = professor.idProfessor JOIN curso ON turma.idCurso = curso.idCurso WHERE idTurma = @codigo";

                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Prepare();

                MySqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    txtCod.Text = dados["idTurma"].ToString();
                    txtNome.Text = dados["Turma"].ToString();
                    mkDataInicio.Text = dados["Inicio"].ToString();
                    mkDataTermino.Text = dados["Termino"].ToString();
                    txtQtd.Text = dados["Qtd_Alunos"].ToString();
                    txtLocal.Text = dados["Local"].ToString();
                    cbProfessor.Text = dados["Professor"].ToString();
                    cbCurso.Text = dados["Curso"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar \n", ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCod.Text;
                string nome = txtNome.Text;
                string quantidade = txtQtd.Text;
                string local = txtLocal.Text;
                DateTime datainicio = Convert.ToDateTime(mkDataInicio.Text);
                DateTime datatermino = Convert.ToDateTime(mkDataTermino.Text);
                int curso = Convert.ToInt32(cbCurso.SelectedValue);
                int professor = Convert.ToInt32(cbProfessor.SelectedValue);

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE turma SET nomeTurma = @nome, dataInicio = @datainicio, dataFim = @datatermino," +
                                      "maximoAlunosTurma = @quantidade, idCurso = @curso, idProfessor = @professor," +
                                      "localidade = @local WHERE idTurma = @codigo";
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@quantidade", quantidade);
                comando.Parameters.AddWithValue("@local", local);
                comando.Parameters.AddWithValue("@datainicio", datainicio);
                comando.Parameters.AddWithValue("@datatermino", datatermino);
                comando.Parameters.AddWithValue("@curso", curso);
                comando.Parameters.AddWithValue("@professor", professor);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso");
                atualiza();
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel alterar \n", ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt16(txtCod.Text);

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM turma WHERE `turma`.`idTurma` = @codigo";
                comando.Parameters.AddWithValue("@codigo", codigo);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados excluidos com sucesso");
                atualiza();
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro não foi possivel excluir os dados \n", ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void limpar()
        {
            txtCod.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtQtd.Text = string.Empty;
            txtLocal.Text = string.Empty;
            mkDataInicio.Text = string.Empty;
            mkDataTermino.Text = string.Empty;
            cbCurso.Text = string.Empty;
            cbProfessor.Text = string.Empty;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void atualiza()
        {
            try
            {
                conexao = Conectar.Getconexao();

                string sql = "SELECT idTurma, nomeTurma AS Turma, professor.nome AS Professor, curso.curso, dataInicio AS Inicio, dataFim AS Termino, maximoAlunosTurma AS Qtd_Aluno, localidade AS Local FROM turma JOIN professor ON turma.idProfessor = professor.idProfessor JOIN curso ON turma.idCurso = curso.idCurso";
                DataTable datatable = new DataTable();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, conexao);

                dataadapter.Fill(datatable);
                dgvTurma.DataSource = datatable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecao = dgvTurma.Rows[index];

            int codigo = Convert.ToInt16(selecao.Cells["idTurma"].Value);
            ConsultaCodigo(codigo);
        }
    }
}
