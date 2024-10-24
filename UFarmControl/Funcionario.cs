using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFarmControl
{
    public partial class Funcionario : Usuario
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
        private String cargo;
        public string getCargo()
        {
            return nome;
        }
        public void setCargo(String cargo)
        {
            this.cargo = cargo;
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
        public void setSenha(String senha)
        {
            this.senha = senha;
        }
        public Funcionario(Usuario usuario)
        {
            this.id = usuario.getId();
            this.nome = usuario.getNome();
            this.cargo = usuario.getCargo();
            this.cep = usuario.getCep();
            this.email = usuario.getEmail();
            this.senha = usuario.getSenha();
        }
    }
}
