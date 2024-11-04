using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UFarmControl
{
    public partial class Dao_Usuario
    {
        private OracleConnection conexao;
        public Dao_Usuario(string connectionString) 
        {
            // Conexão com o banco de dados Oracle
            conexao = new OracleConnection(connectionString);
        } 
        private string connectionString = "User Id=usuario;Password=senha;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=hostname)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=servicename)));";
        //CREATE
        public void AdicionarDadosBd(Funcionario funcionario)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "INSERT INTO Funcionarios (Id, Nome, Cargo, Email, Senha, Cep, Telefone) VALUES (:Id, :Nome, :Cargo, :Email, :Senha, :Cep, :Telefone)";
                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(new OracleParameter("Id", funcionario.getId()));
                cmd.Parameters.Add(new OracleParameter("Nome", funcionario.getNome()));
                cmd.Parameters.Add(new OracleParameter("Cargo", funcionario.getCargo()));
                cmd.Parameters.Add(new OracleParameter("Email", funcionario.getEmail()));
                cmd.Parameters.Add(new OracleParameter("Senha", funcionario.getSenha()));
                cmd.Parameters.Add(new OracleParameter("Cep", funcionario.getCep()));
                cmd.Parameters.Add(new OracleParameter("Telefone", funcionario.getTelefone()));

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch 
                {
                    //mensagem de erro
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        public void AdicionarDadosBd(Gerente gerente)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "INSERT INTO Gerentes (Id, Nome, Cargo, Email, Senha, Cep, Telefone) VALUES (:Id, :Nome, :Cargo, :Email, :Senha, :Cep, :Telefone)";
                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(new OracleParameter("Id", gerente.getId()));
                cmd.Parameters.Add(new OracleParameter("Nome", gerente.getNome()));
                cmd.Parameters.Add(new OracleParameter("Cargo", gerente.getCargo()));
                cmd.Parameters.Add(new OracleParameter("Email", gerente.getEmail()));
                cmd.Parameters.Add(new OracleParameter("Senha", gerente.getSenha()));
                cmd.Parameters.Add(new OracleParameter("Cep", gerente.getCep()));
                cmd.Parameters.Add(new OracleParameter("Telefone", gerente.getTelefone()));

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //mensagem de erro
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        public void AdicionarDadosBd(Proprietario proprietario)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "INSERT INTO Proprietarios (INSERT INTO Gerentes (Id, Nome, Cargo, Email, Senha, Cep, Telefone) VALUES (:Id, :Nome, :Cargo, :Email, :Senha, :Cep, :Telefone)";
                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(new OracleParameter("Id", proprietario.getId()));
                cmd.Parameters.Add(new OracleParameter("Nome", proprietario.getNome()));
                cmd.Parameters.Add(new OracleParameter("Cargo", proprietario.getCargo()));
                cmd.Parameters.Add(new OracleParameter("Email", proprietario.getEmail()));
                cmd.Parameters.Add(new OracleParameter("Senha", proprietario.getSenha()));
                cmd.Parameters.Add(new OracleParameter("Cep", proprietario.getCep()));
                cmd.Parameters.Add(new OracleParameter("Telefone", proprietario.getTelefone()));

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //mensagem de erro
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        //READ
        public Funcionario lerDadosBd(Funcionario funcionario) 
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "SELECT * FROM Funcionarios WHERE ID = :id";
                OracleCommand cmd = new OracleCommand(sql, conn);

                try
                {
                    conexao.Open();
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        funcionario.setNome(Convert.ToString(dr["NOME"]));
                        funcionario.setCargo(Convert.ToString(dr["CARGO"]));
                        funcionario.setCep(Convert.ToString(dr["CEP"]));
                        funcionario.setTelefone(Convert.ToString(dr["TELEFONE"]));
                        funcionario.setEmail(Convert.ToString(dr["EMAIL"]));
                    }
                    return funcionario;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        public Gerente lerDadosBd(Gerente gerente)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "SELECT * FROM Gerentes WHERE ID = :id";
                OracleCommand cmd = new OracleCommand(sql, conn);

                try
                {
                    conexao.Open();
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        gerente.setNome(Convert.ToString(dr["NOME"]));
                        gerente.setCargo(Convert.ToString(dr["CARGO"]));
                        gerente.setCep(Convert.ToString(dr["CEP"]));
                        gerente.setTelefone(Convert.ToString(dr["TELEFONE"]));
                        gerente.setEmail(Convert.ToString(dr["EMAIL"]));
                    }
                    return gerente;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        public Proprietario lerDadosBd(Proprietario proprietario)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "SELECT * FROM Proprietarios WHERE ID = :id";
                OracleCommand cmd = new OracleCommand(sql, conn);

                try
                {
                    conexao.Open();
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        proprietario.setNome(Convert.ToString(dr["NOME"]));
                        proprietario.setCargo(Convert.ToString(dr["CARGO"]));
                        proprietario.setCep(Convert.ToString(dr["CEP"]));
                        proprietario.setTelefone(Convert.ToString(dr["TELEFONE"]));
                        proprietario.setEmail(Convert.ToString(dr["EMAIL"]));
                    }
                    return proprietario;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        //UPDATE
        public void atualizarDadosBd(Funcionario funcionario)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "UPDATE Funcionarios SET NOME = :Nome, CEP = :Cep, TELEFONE = :Telefone, CARGO = :Cargo, EMAIL = :Email WHERE ID = :Id";
                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(new OracleParameter("NOME", OracleType.VarChar, 255)).Value = funcionario.getNome();
                cmd.Parameters.Add(new OracleParameter("CEP", OracleType.Int32)).Value = funcionario.getCep();
                cmd.Parameters.Add(new OracleParameter("CARGO", OracleType.VarChar, 255)).Value = funcionario.getCargo();
                cmd.Parameters.Add(new OracleParameter("TELEFONE", OracleType.VarChar, 255)).Value = funcionario.getTelefone();
                cmd.Parameters.Add(new OracleParameter("EMAIL", OracleType.Int32)).Value = funcionario.getEmail();
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //erro
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        public void atualizarDadosBd(Gerente gerente)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "UPDATE Gerentes SET NOME = :Nome, CEP = :Cep, TELEFONE = :Telefone, CARGO = :Cargo, EMAIL = :Email WHERE ID = :Id";
                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(new OracleParameter("NOME", OracleType.VarChar, 255)).Value = gerente.getNome();
                cmd.Parameters.Add(new OracleParameter("CEP", OracleType.Int32)).Value = gerente.getCep();
                cmd.Parameters.Add(new OracleParameter("CARGO", OracleType.VarChar, 255)).Value = gerente.getCargo();
                cmd.Parameters.Add(new OracleParameter("TELEFONE", OracleType.VarChar, 255)).Value = gerente.getTelefone();
                cmd.Parameters.Add(new OracleParameter("EMAIL", OracleType.Int32)).Value = gerente.getEmail();
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //erro
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        public void atualizarDadosBd(Proprietario proprietario)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "UPDATE Proprietarios SET NOME = :Nome, CEP = :Cep, TELEFONE = :Telefone, CARGO = :Cargo, EMAIL = :Email WHERE ID = :Id";
                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(new OracleParameter("NOME", OracleType.VarChar, 255)).Value = proprietario.getNome();
                cmd.Parameters.Add(new OracleParameter("CEP", OracleType.Int32)).Value = proprietario.getCep();
                cmd.Parameters.Add(new OracleParameter("CARGO", OracleType.VarChar, 255)).Value = proprietario.getCargo();
                cmd.Parameters.Add(new OracleParameter("TELEFONE", OracleType.VarChar, 255)).Value = proprietario.getTelefone();
                cmd.Parameters.Add(new OracleParameter("EMAIL", OracleType.Int32)).Value = proprietario.getEmail();
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //erro
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        //DELETE
        public void deletarDadosBd(Funcionario funcionario)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "DELETE FROM Funcionarios WHERE ID = :Id";
                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(new OracleParameter("ID", OracleType.VarChar)).Value = funcionario.getId();

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //mensagem de erro
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        public void deletarDadosBd(Gerente gerente)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "DELETE FROM Gerentes WHERE ID = :Id";
                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(new OracleParameter("ID", OracleType.VarChar)).Value = gerente.getId();

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //mensagem de erro
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        public void deletarDadosBd(Proprietario proprietario)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "DELETE FROM Proprietarios WHERE ID = :Id";
                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(new OracleParameter("ID", OracleType.VarChar)).Value = proprietario.getId();

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //mensagem de erro
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }
}
