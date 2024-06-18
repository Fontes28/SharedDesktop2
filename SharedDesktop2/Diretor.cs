using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDesktop2
{
    class Diretor
    {
        private String nome, rg, email, cargo, telefone;
        private int nr;

        public Diretor(int nr)
        {
            Nr = nr;
        }

        public Diretor()
        {

        }

        public Diretor(string nome, string rg, string email, string cargo, string telefone, int nr)
        {
            Nome = nome;
            Rg = rg;
            Email = email;
            Cargo = cargo;
            Telefone = telefone;
            Nr = nr;
        }

        public bool cadastrarDiretor()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into MembroDirecao (numRegistro,nome,email,cargo,rg,ramal) values (" + Nr + ",'" + Nome + "','" + Email + "','" + Cargo + "','" + Rg + "','" + Telefone + "')", DAO_Conexao.con);
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

        public bool atualizarDiretor()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update MembroDirecao set nome='" + Nome + "', email='" + Email + "', cargo='" + Cargo + "', rg='" + Rg + "', ramal='" + Telefone + "' where numRegistro =" + Nr + "", DAO_Conexao.con);
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
        public bool consultarDiretor()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from MembroDirecao where numRegistro ='" + Nr + "'", DAO_Conexao.con);
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

        public MySqlDataReader consultarDiretorNr(int nr)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from MembroDirecao where numRegistro =" + nr + " and ativo = 0", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public MySqlDataReader consultarDiretor01()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from MembroDirecao where numRegistro =" + Nr + "", DAO_Conexao.con);
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
                MySqlCommand consulta = new MySqlCommand("select ativo from MembroDirecao where numRegistro = '" + Nr + "'", DAO_Conexao.con);
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
                MySqlCommand atualiza = new MySqlCommand("update MembroDirecao set ativo = 0 where numRegistro = '" + Nr + "'", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }

        public bool excluirDiretor(int nr)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update MembroDirecao set ativo = 1 where numRegistro = '" + nr + "'", DAO_Conexao.con);
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
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Nr { get => nr; set => nr = value; }
    }
}
