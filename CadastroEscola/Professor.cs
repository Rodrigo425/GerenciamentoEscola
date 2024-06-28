using CadastroEscola.Conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroEscola
{
    public partial class Professor : Form
    {
        public MySqlConnection conexao;
        string fotoEndereco = string.Empty;
        public Professor()
        {
            InitializeComponent();
            txtCod.Enabled = false;
        }

        private void Professor_Load(object sender, EventArgs e)
        {
            atualiza();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string endereco = txtEndereco.Text;
                string email = txtEmail.Text;
                string formacao = txtFormacao.Text;
                DateTime dataNasc = Convert.ToDateTime(mkDataNasc.Text);
                string telefone = mkTel.Text;

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO professor(nome, endereco, dataNasc, telefone, email, formacao, foto) " +
                                      "VALUES(@nome, @endereco, @dataNasc, @telefone, @email, @formacao, @foto )";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@endereco", endereco);
                comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@formacao", formacao);
                if (fotoEndereco == string.Empty)
                {
                    comando.Parameters.AddWithValue("@foto", null);
                }
                else
                {
                    comando.Parameters.AddWithValue("@foto", ConvertImagemToByte());
                }

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados gravados com sucesso");
                atualiza();
                limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar", ex.Message);
                limpar();
            }
            finally { conexao.Close(); }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt16(txtCod.Text);
                string nome = txtNome.Text;
                string endereco = txtEndereco.Text;
                string email = txtEmail.Text;
                string formacao = txtFormacao.Text;
                DateTime dataNasc = Convert.ToDateTime(mkDataNasc.Text);
                string telefone = mkTel.Text;

                conexao = Conectar.Getconexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE professor SET nome = @nome, endereco = @endereco, dataNasc = @dataNasc, telefone = @telefone, " +
                                      "email = @email, formacao = @formacao WHERE idProfessor = @codigo";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@endereco", endereco);
                comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@formacao", formacao);
                comando.Parameters.AddWithValue("@codigo", codigo);
                if (fotoEndereco == string.Empty)
                {
                    comando.Parameters.AddWithValue("@foto", null);
                }
                else
                {
                    comando.Parameters.AddWithValue("@foto", ConvertImagemToByte());
                }
                comando.Prepare();
                comando.ExecuteNonQuery();
                

                MessageBox.Show("Dados alterados com sucesso");
                atualiza();
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro não foi possivel alterar \n", ex.Message);
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

                comando.CommandText = "SELECT * FROM professor WHERE idProfessor = @codigo";
                comando.Parameters.AddWithValue("@codigo", codigo);

                comando.Prepare();
                MySqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    txtCod.Text = dados["idProfessor"].ToString();
                    txtNome.Text = dados["nome"].ToString();
                    txtEndereco.Text = dados["endereco"].ToString();
                    txtEmail.Text = dados["email"].ToString();
                    txtFormacao.Text = dados["formacao"].ToString();
                    mkDataNasc.Text = dados["dataNasc"].ToString();
                    mkTel.Text = dados["telefone"].ToString();


                    if (dados["foto"] == DBNull.Value)
                    {
                        pictureBox.Image = null;
                    }
                    else
                    {
                        pictureBox.Image = ConvertByteToImage((byte[])dados["foto"]);
                    }
                }
                else
                {
                    MessageBox.Show("Código não localizado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar \n", ex.Message);
            }
            finally { conexao.Close(); }
        }
        private Image ConvertByteToImage(byte[] imgBytes)
        {
            MemoryStream ms = new MemoryStream(imgBytes);
            return Image.FromStream(ms);
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

                comando.CommandText = "DELETE FROM professor WHERE idProfessor = @codigo";
                comando.Parameters.AddWithValue("@codigo", codigo);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados excluidos com sucesso");
                atualiza();
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro não foi possivel excluir \n", ex.Message);
                limpar();
            }
            finally { conexao.Close(); }
        }

        private void dgvProf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecao = dgvProf.Rows[index];

            int codigo = Convert.ToInt16(selecao.Cells["idProfessor"].Value);
            ConsultaCodigo(codigo);
        }

        private void atualiza()
        {
            try
            {
                conexao = Conectar.Getconexao();

                string sql = "SELECT idProfessor, nome as Nome, dataNasc as Nascimento, endereco as Endereço, telefone as Telefone, email as Email, formacao as Formação FROM professor";
                DataTable datatable = new DataTable();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, conexao);

                dataadapter.Fill(datatable);
                dgvProf.DataSource = datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void limpar()
        {
            txtCod.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtFormacao.Text = string.Empty;
            mkDataNasc.Text = string.Empty;
            mkTel.Text = string.Empty;
            pictureBox.Image = null;
            fotoEndereco = string.Empty;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private Byte[] ConvertImagemToByte()
        {
            byte[] imagembyte = null;
            FileStream fs = new FileStream(fotoEndereco, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            imagembyte = br.ReadBytes((int)fs.Length);

            return imagembyte;
        }

        private void btBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.Filter = "Imagens(*.jpg; *.png) | *.jpg; *.png";
            if (janela.ShowDialog() == DialogResult.OK) ;
            {
                fotoEndereco = janela.FileName;
                pictureBox.ImageLocation = fotoEndereco;
            }
        }
    }
}
