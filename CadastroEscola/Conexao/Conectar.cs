using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEscola.Conexao
{
    public class Conectar
    {
        public static MySqlConnection Getconexao()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("DataSource=localHost; port=3306; database = escola; username = root; password = ; Convert Zero DateTime = True");
                return con;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
