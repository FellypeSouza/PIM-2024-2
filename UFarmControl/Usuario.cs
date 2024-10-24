using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFarmControl
{
    public partial class Usuario
    {
        private String id;
        public string getId()
        {
            return id;
        }
        public void setId(String id)
        {
            this.id = id;
        }
        private String nome;
        public string getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        private String cargo;
        public string getCargo()
        {
            return cargo;
        }
        public void setCargo(String cargo)
        {
            this.cargo = cargo;
        }
        private String cep;
        public string getCep()
        {
            return cep;
        }
        public void setCep(String cep)
        {
            this.cep = cep;
        }
        private String telefone;
        public String getTelefone()
        {
            return telefone;
        }
        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }
        private String email;
        public string getEmail()
        {
            return email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        private String senha;
        public string getSenha()
        {
            return senha;
        }
        public void setSenha(String senha)
        {
            this.senha = senha;
        }
        public Usuario()
        {
            this.id = id;
            this.nome = nome;
            this.cep = cep;
            this.email = email;
            this.senha = senha;
        }

    }
}
