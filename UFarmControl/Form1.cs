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
    public partial class Form1 : Form
    {
        Usuario usuario = new Usuario();
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void limpar_Click(object sender, EventArgs e)
        {
            nome.Text = "";
            cep.Text = "";
            telefone.Text = "";
            email.Text = "";
            senha.Text = "";
        }
        private void senhaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (senhaCheckBox.CheckState == CheckState.Unchecked)
            {
                senha.UseSystemPasswordChar = true;
            }
            else 
            {
                senha.UseSystemPasswordChar = false;
            }
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            //Cliente cl = new Cliente(gerarID(), Convert.ToString(nome.Text), Convert.ToString(cep.Text), Convert.ToString(email.Text), Convert.ToString(senha.Text));
            if (nome.Text == "" || cep.Text == "" || comboBox1.Text == "" || telefone.Text == "" || email.Text == "" || senha.Text == "")
            {
                labelCampoVazio.Text = "Insira todos os campos para registrar";
            }
            else
            {
                gerarID();
                usuario.setNome(nome.Text);
                usuario.setCep(cep.Text);
                usuario.setTelefone(telefone.Text);
                usuario.setEmail(email.Text);
                usuario.setSenha(senha.Text);
                labelCampoVazio.Text = "";

                if (comboBox1.Text == "Funcionário")
                {
                    PaginaFuncionario PaginaFuncionario = new PaginaFuncionario(usuario);
                    PaginaFuncionario.ShowDialog();
                }
                else if (comboBox1.Text == "Gerente")
                {
                    PaginaGerente PaginaGerente = new PaginaGerente();
                    PaginaGerente.ShowDialog();
                }
                else
                {
                    PaginaProprietario PaginaProprietario = new PaginaProprietario();
                    PaginaProprietario.ShowDialog();
                }
            }
        }
        public void gerarID()
        {
            //Cria um objeto Random para gerar números aleatórios.
            Random random = new Random();
            // Gera um número aleatório de 5 dígitos
            string id = Convert.ToString(random.Next(10000, 99999));
            usuario.setId(id);
        }
    }
}
