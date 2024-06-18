using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SharedDesktop2
{
    class Aluno
    {
        private String nome, rg, nascimento, telefone, email;

        public Aluno(string rg)
        {
            Rg = rg;
        }

        private int ra, serie;

        public Aluno(int ra)
        {
            Ra = ra;
        }

        public Aluno()
        {
        }

        public Aluno(string nome, string rg, string nascimento, string telefone, string email, int ra, int serie)
        {
            Nome = nome;
            Rg = rg;
            Nascimento = nascimento;
            Telefone = telefone;
            Email = email;
            Ra = ra;
            Serie = serie;
        }

        public Aluno(string nome, string rg, string nascimento, string telefone, string email, int ra)
        {
            Nome = nome;
            Rg = rg;
            Nascimento = nascimento;
            Telefone = telefone;
            Email = email;
            Ra = ra;
        }

        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Aluno (ra,nome,celular,rg,emailInstitucional,dataNascimento,classe) values (" + Ra + ",'" + Nome + "','" + Telefone + "','" + Rg + "','" + Email + "','" + Nascimento + "','" + Serie + "')", DAO_Conexao.con);
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

        public bool atualizarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Aluno set nome='" + Nome + "', celular='" + Telefone + "', rg='" + Rg + "', emailInstitucional='" + Email + "', dataNascimento='" + Nascimento + "' where ra =" + Ra + "", DAO_Conexao.con);
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

        public MySqlDataReader consultarAlunoRa(int ra)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Aluno where ra like " + ra + " and ativo = 0", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }
        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Aluno where ra ='" + Ra + "'", DAO_Conexao.con);
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

        public bool consultarAlunoAtivo()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Aluno where ra ='" + Ra + "' and ativo = 0", DAO_Conexao.con);
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

        public MySqlDataReader consultarAluno01()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select classe from Aluno where ra =" + Ra + "", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public MySqlDataReader consultarAluno02()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Aluno where ra =" + Ra + "", DAO_Conexao.con);
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
                MySqlCommand consulta = new MySqlCommand("select ativo from Aluno where ra = '" + Ra + "'", DAO_Conexao.con);
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
                MySqlCommand atualiza = new MySqlCommand("update Aluno set ativo = 0 where ra = '" + Ra + "'", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }

        public bool excluirAluno(int ra)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Aluno set ativo = 1 where ra = '" + ra + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                MySqlCommand exclui2 = new MySqlCommand("update Monitor set ativo = 1 where ra = '" + ra + "'", DAO_Conexao.con);
                exclui2.ExecuteNonQuery();
                MySqlCommand exclui3 = new MySqlCommand("delete from AlunoTurma where aluno_ra = " + ra + "", DAO_Conexao.con);
                exclui3.ExecuteNonQuery();
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
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public int Ra { get => ra; set => ra = value; }
        public int Serie { get => serie; set => serie = value; }
    }
}
