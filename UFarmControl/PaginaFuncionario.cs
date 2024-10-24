using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UFarmControl
{
    public partial class PaginaFuncionario : Form
    {
        private Usuario usuario;

        public PaginaFuncionario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
       
        private void PaginaFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(usuario);
            labelNome.Text = "Bem vindo(a) " + funcionario.getNome();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }
    }
}
