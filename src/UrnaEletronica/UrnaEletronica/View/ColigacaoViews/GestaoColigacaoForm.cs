using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEletronica.Data.DAO.Eleicao;
using UrnaEletronica.Model;
using UrnaEletronica.Data.DAO.Coligacao;
using UrnaEletronica.Data.DAO.Candidato;

namespace UrnaEletronica.View.Coligacao
{
    public partial class GestaoColigacaoForm : Form
    {
        public GestaoColigacaoForm()
        {
            InitializeComponent();
            dgvColigacao.DataSource = CarregaDados();
        }

        private List<ColigacaoModel> CarregaDados()
        {
            return ColigacaoDAO.BuscarListaColigacao();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColigacaoDAO.CadastrarColigacao(txtNome.Text);
            dgvColigacao.DataSource = CarregaDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColigacaoDAO.DeletarColigacao(txtNome.Text);
            dgvColigacao.DataSource = CarregaDados();
        }
    }
}
