using MySql.Data.MySqlClient;
using System;

namespace SharedDesktop2
{
    internal class DAO_Conexao
    {
        public static MySqlConnection con;

        public static Boolean getConexao(String local, String db, String user, String password)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("Server =" + local + ";User ID=" + user + ";" + "Database=" + db + "; Password=" + password + "; SslMode = none");

                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }

        public static Boolean CadLogin(string usuario, string senha, int tipo)
        {
            bool cad = false;
            try
            {
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into SharEd_Login (usuario, senha, tipo)" + "values('" + usuario + "','" + senha + "'," + tipo + ")", con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return cad;
        }

        public static int verLogin(string usuario, string senha)
        {
            int tipo = 0;
            try
            {
                con.Open();
                MySqlCommand verifica = new MySqlCommand("select * from SharEd_Login where usuario='" + usuario + "' and senha='" + senha + "'", con);
                MySqlDataReader resultado = verifica.ExecuteReader();
                if (resultado.Read())
                    tipo = Convert.ToInt32(resultado["tipo"].ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return tipo;
        }
    }
}