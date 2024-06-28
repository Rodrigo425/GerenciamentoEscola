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
    public partial class Curso : Form
    {
        public MySqlConnection conexao;
        public Curso()
        {
            InitializeComponent();
            atualiza();
            txtCod.Enabled = false;
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeCurso = txtNomeCurso.Text;

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO curso(curso) VALUES(@curso)";
                comando.Parameters.AddWithValue("@curso", nomeCurso);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados gravados com sucesso");
                limpar();
                atualiza();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel adicionar o curso \n", ex.Message);
                limpar();
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
                comando.CommandText = "SELECT * FROM curso WHERE idCurso = @codigo";

                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Prepare();
                MySqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    txtCod.Text = dados["idCurso"].ToString();
                    txtNomeCurso.Text = dados["curso"].ToString();
                }
                else
                {
                    MessageBox.Show("Código não localizado");
                    limpar();
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
                int codigo = Convert.ToInt16(txtCod.Text);
                string nomeCurso = txtNomeCurso.Text;

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "UPDATE `curso` SET curso = @nomeCurso WHERE idCurso = @codigo";

                comando.Parameters.AddWithValue("@nomeCurso", nomeCurso);
                comando.Parameters.AddWithValue("@codigo", codigo);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso");
                limpar();
                atualiza();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel alterar \n", ex.Message);
                limpar();
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
                comando.CommandText = "DELETE FROM curso WHERE idCurso = @codigo ";
                comando.Parameters.AddWithValue("@codigo", codigo);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados excluidos com sucesso");
                limpar();
                atualiza();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel excluir \n", ex.Message);
                limpar();
            }
            finally { conexao.Close(); }
        }

        private void limpar()
        {
            txtCod.Text = string.Empty;
            txtNomeCurso.Text = string.Empty;
            txtCod.Enabled = false;
        }

        private void atualiza()
        {
            try
            {
                conexao = Conectar.Getconexao();

                string sql = "SELECT idCurso, curso FROM curso";
                DataTable datatable = new DataTable();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, conexao);

                dataadapter.Fill(datatable);
                dgvCurso.DataSource = datatable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void dgvCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecao = dgvCurso.Rows[index];

            int codigo = Convert.ToInt16(selecao.Cells["idCurso"].Value);
            ConsultaCodigo(codigo);
        }
    }
}
