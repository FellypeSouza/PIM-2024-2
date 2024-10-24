using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFarmControl
{
    public partial class Dao_Usuario
    {
        private string connectionString = "sua_string_de_conexão_aqui";
        public void AdicionarDadosBd(Funcionario funcionario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Funcionarios (Id, Nome, Cargo, Email, Senha, Cep, Telefone) VALUES (@Id, @Nome, @Cargo, @Email, @Senha, @Cep, @Telefone)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", funcionario.getId());
                cmd.Parameters.AddWithValue("@Nome", funcionario.getNome());
                cmd.Parameters.AddWithValue("@Cargo", funcionario.getCargo());
                cmd.Parameters.AddWithValue("@Email", funcionario.getEmail());
                cmd.Parameters.AddWithValue("@Senha", funcionario.getSenha());
                cmd.Parameters.AddWithValue("@Cep", funcionario.getCep());
                cmd.Parameters.AddWithValue("@Telefone", funcionario.getTelefone());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void AdicionarDadosBd(Gerente gerente)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Gerentes (Id, Nome, Cargo, Email, Senha, Cep, Telefone) VALUES (@Id, @Nome, @Cargo, @Email, @Senha, @Cep, @Telefone)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", gerente.getId());
                cmd.Parameters.AddWithValue("@Nome", gerente.getNome());
                cmd.Parameters.AddWithValue("@Cargo", gerente.getCargo());
                cmd.Parameters.AddWithValue("@Email", gerente.getEmail());
                cmd.Parameters.AddWithValue("@Senha", gerente.getSenha());
                cmd.Parameters.AddWithValue("@Cep", gerente.getCep());
                cmd.Parameters.AddWithValue("@Telefone", gerente.getTelefone());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void AdicionarDadosBd(Proprietario proprietario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Proprietarios (Id, Nome, Cargo, Email, Senha, Cep, Telefone) VALUES (@Id, @Nome, @Cargo, @Email, @Senha, @Cep, @Telefone)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", proprietario.getId());
                cmd.Parameters.AddWithValue("@Nome", proprietario.getNome());
                cmd.Parameters.AddWithValue("@Cargo", proprietario.getCargo());
                cmd.Parameters.AddWithValue("@Email", proprietario.getEmail());
                cmd.Parameters.AddWithValue("@Senha", proprietario.getSenha());
                cmd.Parameters.AddWithValue("@Cep", proprietario.getCep());
                cmd.Parameters.AddWithValue("@Telefone", proprietario.getTelefone());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }




    }
}
