using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFarmControl
{
    public partial class Ctr_Usuario
    {
        public void AdicionarDadosBD(Funcionario funcionario)
        {
            Dao_Usuario Dao_Usuario = new Dao_Usuario("conexao");
            Dao_Usuario.AdicionarDadosBd(funcionario);
        }
        public void AdicionarDadosBD(Gerente gerente)
        {
            Dao_Usuario Dao_Usuario = new Dao_Usuario("conexao");
            Dao_Usuario.AdicionarDadosBd(gerente);
        }
        public void AdicionarDadosBD(Proprietario proprietario)
        {
            Dao_Usuario Dao_Usuario = new Dao_Usuario("conexao");
            Dao_Usuario.AdicionarDadosBd(proprietario);
        }
    }
}
