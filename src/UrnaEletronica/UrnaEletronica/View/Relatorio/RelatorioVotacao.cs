using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEletronica.Data.DAO.RelatorioVotacao;
using UrnaEletronica.Model;

namespace UrnaEletronica.View.Relatorio
{
    public partial class RelatorioVotacao : Form
    {
        public RelatorioVotacao()
        {
            InitializeComponent();
            CarregarComboBox();
        }

        private void CarregarComboBox()
        {
            // Adiciona as opções "Prefeito" e "Vereador" ao ComboBox
            comboCargo.Items.Add("Prefeito");
            comboCargo.Items.Add("Vereador");
            comboCargo.Items.Add("Presidente");
            comboCargo.Items.Add("Governador");
            comboCargo.Items.Add("Dep Federal");
            comboCargo.Items.Add("Dep Estadual");
            comboCargo.Items.Add("Senador");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            // Use o texto selecionado no comboBoxCargo para a consulta
            string cargoSelecionado = comboCargo.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(cargoSelecionado))
            {
                List<VotosCandidatoModel> listaVotos = RelatorioVotacaoDAO.VotosCandidato(cargoSelecionado);
                dataGridResultado.DataSource = listaVotos;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cargo no ComboBox.");
            }

        }

        private void RelatorioVotacao_Load(object sender, EventArgs e)
        {

        }
    }
}
