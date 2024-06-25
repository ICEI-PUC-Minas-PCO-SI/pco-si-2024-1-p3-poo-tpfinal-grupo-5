using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEletronica.Data.DAO.Coligacao;
using UrnaEletronica.Data.DAO.Partido;
using UrnaEletronica.Model;

namespace UrnaEletronica.View.Coligacao
{
    public partial class GestaoPartidoForm : Form
    {


        public GestaoPartidoForm()
        {
            InitializeComponent();
            CarregarComboBox();
            dgListaPartidos.DataSource = CarregaGrid();
        }
        private void GestaoEleicaoForm_Load(object sender, EventArgs e)
        {

        }

        private List<PartidoModel> CarregaGrid()
        {
            return PartidoDAO.BuscarPartidoLista();
        }

        private void CarregarComboBox()
        {
            List<ColigacaoModel> lista = ColigacaoDAO.BuscarListaColigacao();

            foreach (var coligacao in lista)
            {
                comboBoxColigacao.Items.Add(new KeyValuePair<int, string>(coligacao.IdColigacao, coligacao.Nome.ToString()));
            }

            // Defina o DisplayMember e o ValueMember
            comboBoxColigacao.DisplayMember = "Value";
            comboBoxColigacao.ValueMember = "Key";

            //comboBoxColigacao.DataSource = coligacao.Nome;

        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            int coligacaoId = ((KeyValuePair<int, string>)comboBoxColigacao.SelectedItem).Key;
            PartidoModel partido = new PartidoModel(Convert.ToInt32(numeroPartido.Text), nomePartido.Text, siglaPartido.Text, coligacaoId);

            PartidoDAO.CadastrarPartido(partido);
            dgListaPartidos.DataSource = CarregaGrid();
        }

        private void dgListaPartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
