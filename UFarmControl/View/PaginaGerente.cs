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
    public partial class PaginaGerente : Form
    {
        public PaginaGerente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            tabelaFuncionarios.Rows.Add();
            tabelaFuncionarios.Rows[0].Cells[0].Value = "Fellype Souza";
            tabelaFuncionarios.Rows[0].Cells[1].Value = "Mecanico";
            tabelaFuncionarios.Rows[0].Cells[2].Value = "Ativo";

            
        }
    }
}
