using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEletronica.Data.DAO.Candidato;
using UrnaEletronica.Data.DAO.Coligacao;
using UrnaEletronica.Data.DAO.Eleicao;
using UrnaEletronica.Data.DAO.Partido;
using UrnaEletronica.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UrnaEletronica.View.Candidato
{
    public partial class GestaoCandidatoForm : Form
    {
        public GestaoCandidatoForm()
        {
            InitializeComponent();
            CarregarComboBox();
            dgvCandidatos.DataSource = CarregaDados();
        }

        private List<CandidatoModel> CarregaDados()
        {
            return CandidatoDAO.BuscarListaCandidato();
        }

        private void GestaoCandidatoForm_Load(object sender, EventArgs e)
        {

        }

        private void CarregarComboBox()
        {
            List<PartidoModel> lista = PartidoDAO.BuscarPartidoLista();

            foreach (var partido in lista)
            {
                comboBoxCandidatos.Items.Add(new KeyValuePair<int, string>(partido.id_Partido, partido.sigla.ToString()));
            }

            // Defina o DisplayMember e o ValueMember
            comboBoxCandidatos.DisplayMember = "Value";
            comboBoxCandidatos.ValueMember = "Key";
            comboBoxCandidatos.SelectedIndexChanged += comboBoxCandidatos_SelectedIndexChanged;
            //comboBoxColigacao.DataSource = coligacao.Nome;

        }

        private void comboBoxCandidatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCandidatos.SelectedItem != null)
            {
                int partidoId = ((KeyValuePair<int, string>)comboBoxCandidatos.SelectedItem).Key;
                txtNumeroPartido.Text = partidoId.ToString();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int partidoId = ((KeyValuePair<int, string>)comboBoxCandidatos.SelectedItem).Key;
            CandidatoDAO.CadastrarCandidato(txtNome.Text, txtApelido.Text, Convert.ToInt32(txtNumeroPartido.Text+txtNumero.Text), partidoId);
            dgvCandidatos.DataSource = CarregaDados();
        }

        private void dgvCandidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CandidatoDAO.DeletarCandidato(Convert.ToInt32(txtNumeroPartido.Text+txtNumero.Text), txtNome.Text, txtApelido.Text);
            dgvCandidatos.DataSource = CarregaDados();
        }
    }
}
