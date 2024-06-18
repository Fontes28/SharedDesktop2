using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDesktop2
{
    class Administrador
    {
        private String nome, rg, cargo, telefone, email;
        private int nr;

        public Administrador()
        {

        }

        public Administrador(int nr)
        {
            Nr = nr;
        }

        public Administrador(string nome, string rg, string cargo, string telefone, string email, int nr)
        {
            Nome = nome;
            Rg = rg;
            Cargo = cargo;
            Telefone = telefone;
            Email = email;
            Nr = nr;
        }

        public bool cadastrarAdministrador()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Administrador (numRegistro,nome,emailInstitucional,cargo,rg,ramal) values (" + Nr + ",'" + Nome + "','" + Email + "','" + Cargo + "','" + Rg + "','" + Telefone + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public bool atualizarAdministrador()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Administrador set nome='" + Nome + "', emailInstitucional='" + Email + "', cargo='" + Cargo + "', rg='" + Rg + "', ramal='" + Telefone + "' where numRegistro =" + Nr + "", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }
        public bool consultarAdministrador()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Administrador where numRegistro ='" + Nr + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;
        }

        public MySqlDataReader consultarAdministrador01()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Administrador where numRegistro ='" + Nr + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public MySqlDataReader consultarAdministradorNr(int nr)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Administrador where numRegistro ='" + nr + "' and ativo = 0", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }


        public int verificaAtivo()
        {
            MySqlDataReader resultS = null;
            int resultI = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select ativo from Administrador where numRegistro = '" + Nr + "'", DAO_Conexao.con);
                resultS = consulta.ExecuteReader();
                if (resultS.Read())
                {
                    resultI = int.Parse(resultS["ativo"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return resultI;
        }

        public bool tornarAtivo()
        {
            bool result = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Administrador set ativo = 0 where numRegistro = '" + Nr + "'", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return result;
        }



        public bool excluirAdministrador(int nr)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Administrador set ativo = 1 where numRegistro = '" + nr + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public int Nr { get => nr; set => nr = value; }
    }
}
