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
            //Instancia o objeto Funcionario a partir dos dados coletados do primeiro Formulário
            Funcionario funcionario = new Funcionario(usuario);
            SensorTemperatura SensorTemperatura = new SensorTemperatura();
            SensorUmidade SensorUmidade = new SensorUmidade();
            SensorLuminosidade SensorLuminosidade = new SensorLuminosidade();
            SensorCo2 SensorCo2 = new SensorCo2();

            labelNome.Text = "Bem vindo(a) " + funcionario.getNome();

            viewFuncNome.Text = "Nome: " + funcionario.getNome();
            viewFuncCep.Text = "CEP: " + funcionario.getCep();
            viewFuncTelefone.Text = "Telefone: " + funcionario.getTelefone();
            viewFuncCargo.Text = "Cargo: " + funcionario.getCargo();
            viewFuncEmail.Text = "Email: " + funcionario.getEmail();

            dataTemperatura.Text = "Colocado em: " + Convert.ToString(SensorTemperatura.getDataColocado());
            dataUmidade.Text = "Colocado em: " + Convert.ToString(SensorUmidade.getDataColocado());
            dataLuminosidade.Text = "Colocado em: " + Convert.ToString(SensorLuminosidade.getDataColocado());
            dataCo2.Text = "Colocado em: " + Convert.ToString(SensorCo2.getDataColocado());

            if (SensorTemperatura.getStatus() == false)
            {
                statusTemperatura.Text = "Status: Desativado";
            }
            else
            {
                statusTemperatura.Text = "Status: Ativado";
            }
            if (SensorUmidade.getStatus() == false)
            {
                statusUmidade.Text = "Status: Desativado";
            }
            else
            {
                statusUmidade.Text = "Status: Ativado";
            }
            if (SensorLuminosidade.getStatus() == false)
            {
                statusLuminosidade.Text = "Status: Desativado";
            }
            else
            {
                statusLuminosidade.Text = "Status: Ativado";
            }
            if (SensorCo2.getStatus() == false)
            {
                statusCo2.Text = "Status: Desativado";
            }
            else
            {
                statusCo2.Text = "Status: Ativado";
            }



            
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

        private void button16_Click(object sender, EventArgs e)
        {

            
        }
    }
}
