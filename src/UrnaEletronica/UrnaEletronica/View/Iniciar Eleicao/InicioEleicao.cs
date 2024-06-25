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
using UrnaEletronica.View.Votacao;

namespace UrnaEletronica.View.Iniciar_Eleicao
{
    public partial class InicioEleicao : Form
    {
        private EleicaoModel ele = new EleicaoModel();

        public InicioEleicao()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int idEleicao = Convert.ToInt32(textBoxID.Text);
            ele = EleicaoDAO.BuscarEleicao(idEleicao);

            if (ele != null)
            {
                lblId.Text = Convert.ToString(ele.id_eleicao);
                lblAno.Text = Convert.ToString(ele.ano);
                lblTipo.Text = ele.tipo;
                if (ele.total_votos == 0)
                {
                    lblStatus.Text = "Não inicada";
                    btnInicia.Enabled = true;
                }
                else
                {
                    lblStatus.Text = "Já aconteceu";
                    btnInicia.Enabled = false;
                }
            }
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            Urna u = new Urna(ele);
            u.Show();
            this.Close();
        }
    }
}
