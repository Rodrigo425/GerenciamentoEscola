using MySql.Data.MySqlClient;
using CadastroEscola.Conexao;
using System.Data;

namespace CadastroEscola
{
    public partial class Aluno : Form
    {
        public MySqlConnection conexao;
        string fotoEndereco = string.Empty;
        public Aluno()
        {
            InitializeComponent();
            txtCod.Enabled = false;
        }

        private void Aluno_Load(object sender, EventArgs e)
        {
            atualiza();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeAluno = txtNomeAluno.Text;
                string rg = mkRgAluno.Text;
                string cpf = mkCpfAluno.Text;
                string endereco = txtEnderecoAluno.Text;
                string telAluno = mkTelAluno.Text;
                string email = txtEmailAluno.Text;
                DateTime dataNasc = Convert.ToDateTime(mkDataNascAluno.Text);
                string nomeResp = txtNomeResponsavel.Text;
                string telResp = mkTelResposavel.Text;

                conexao = Conectar.Getconexao();
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO aluno(nomeAluno, rg, cpf, dataNasc, endereco, telefone, email, nomeResponsavel, telefoneResponsavel, foto)" +
                                      "VALUES(@nomeAluno, @rg, @cpf, @dataNasc, @endereco, @telefone, @email, @nomeResponsavel, @telefoneResponsavel, @foto)";
                comando.Parameters.AddWithValue("@nomeAluno", nomeAluno);
                comando.Parameters.AddWithValue("@rg", rg);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                comando.Parameters.AddWithValue("@endereco", endereco);
                comando.Parameters.AddWithValue("@telefone", telAluno);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@nomeResponsavel", nomeResp);
                comando.Parameters.AddWithValue("@telefoneResponsavel", telResp);
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

                MessageBox.Show("Dados gravados");
                limpar();
                atualiza();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao grava \n", ex.Message);
                limpar();
            }
            finally { conexao.Close(); }
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt16(txtCod.Text);
                string nomeAluno = txtNomeAluno.Text;
                string rg = mkRgAluno.Text;
                string cpf = mkCpfAluno.Text;
                string endereco = txtEnderecoAluno.Text;
                string telAluno = mkTelAluno.Text;
                string email = txtEmailAluno.Text;
                DateTime dataNasc = Convert.ToDateTime(mkDataNascAluno.Text);
                string nomeResp = txtNomeResponsavel.Text;
                string telResp = mkTelResposavel.Text;

                conexao = Conectar.Getconexao();
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "UPDATE aluno SET nomeAluno = @nomeAluno, rg = @rg, cpf = @cpf, dataNasc = @dataNasc," +
                                    " endereco = @endereco, telefone = @telefone, email = @email, nomeResponsavel = @nomeResponsavel," +
                                    "telefoneResponsavel = @telefoneResponsavel, foto = @foto WHERE idAluno = @codigo";


                comando.Parameters.AddWithValue("@nomeAluno", nomeAluno);
                comando.Parameters.AddWithValue("@rg", rg);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                comando.Parameters.AddWithValue("@endereco", endereco);
                comando.Parameters.AddWithValue("@telefone", telAluno);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@nomeResponsavel", nomeResp);
                comando.Parameters.AddWithValue("@telefoneResponsavel", telResp);
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

                MessageBox.Show("Dados alterados");
                limpar();
                atualiza();
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
                comando.CommandText = "SELECT * FROM aluno WHERE idAluno = @codigo";

                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Prepare();

                MySqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    txtCod.Text = dados["idAluno"].ToString();
                    txtNomeAluno.Text = dados["nomeAluno"].ToString();
                    mkRgAluno.Text = dados["rg"].ToString();
                    mkCpfAluno.Text = dados["cpf"].ToString();
                    mkDataNascAluno.Text = dados["dataNasc"].ToString();
                    mkTelAluno.Text = dados["telefone"].ToString();
                    txtEmailAluno.Text = dados["email"].ToString();
                    txtEnderecoAluno.Text = dados["endereco"].ToString();
                    txtNomeResponsavel.Text = dados["nomeResponsavel"].ToString();
                    mkTelResposavel.Text = dados["telefoneResponsavel"].ToString();
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
                    limpar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar \n", ex.Message);
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
                comando.CommandText = "DELETE FROM aluno WHERE idAluno = @codigo";

                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dado excluido com sucesso");
                limpar();
                atualiza();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel excluir", ex.Message);
                limpar();
            }
            finally { conexao.Close(); }
        }

        private Image ConvertByteToImage(byte[] imgBytes)
        {
            MemoryStream ms = new MemoryStream(imgBytes);
            return Image.FromStream(ms);
        }

        private void limpar()
        {
            txtCod.Text = string.Empty;
            txtNomeAluno.Text = string.Empty;
            txtEmailAluno.Text = string.Empty;
            txtEnderecoAluno.Text = string.Empty;
            txtNomeResponsavel.Text = string.Empty;
            mkCpfAluno.Text = string.Empty;
            mkDataNascAluno.Text = string.Empty;
            mkRgAluno.Text = string.Empty;
            mkTelAluno.Text = string.Empty;
            mkTelResposavel.Text = string.Empty;
            pictureBox.Image = null;
        }

        private void atualiza()
        {
            try
            {
                conexao = Conectar.Getconexao();

                string sql = "SELECT idAluno, nomeAluno as Nome_Aluno, rg as RG, cpf as CPF, dataNasc as Nascimento, endereco as Endereço, telefone as Telefone, email as Email, nomeResponsavel as Nome_Responsavel, telefoneResponsavel as Telefone_Responsavel FROM aluno";
                DataTable datatable = new DataTable();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, conexao);

                dataadapter.Fill(datatable);
                dgvAlunos.DataSource = datatable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecao = dgvAlunos.Rows[index];

            int codigo = Convert.ToInt16(selecao.Cells["idAluno"].Value);
            ConsultaCodigo(codigo);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
