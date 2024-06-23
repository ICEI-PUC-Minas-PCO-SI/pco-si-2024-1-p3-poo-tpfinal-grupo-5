using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEletronica.View.Coligacao;
using UrnaEletronica.View.Eleicao;
using UrnaEletronica.View.Iniciar_Eleicao;

namespace UrnaEletronica.View.Menu_Inicial
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarEleicao_Click(object sender, EventArgs e)
        {
            GestaoEleicaoForm gestaoEleicaoForm = new GestaoEleicaoForm();
            gestaoEleicaoForm.Show();
        }

        private void cadastrarColigacao_Click(object sender, EventArgs e)
        {
            GestaoColigacaoForm gestaoEleicaoForm = new GestaoColigacaoForm();
            gestaoEleicaoForm.Show();
        }

        private void cadastrarPartido_Click(object sender, EventArgs e)
        {
            GestaoPartidoForm gestaoEleicaoForm = new GestaoPartidoForm();
            gestaoEleicaoForm.Show();
        }

        private void cadastrarCandidato_Click(object sender, EventArgs e)
        {
            GestaoPartidoForm g = new GestaoPartidoForm();
            g.Show();
        }

        private void iniciaEleicao_Click(object sender, EventArgs e)
        {
            InicioEleicao i = new InicioEleicao();
            i.Show();
        }
    }
}
