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

namespace UrnaEletronica.View.Eleicao
{
    public partial class GestaoEleicaoForm : Form
    {
        public GestaoEleicaoForm()
        {
            InitializeComponent();
            dgvEleicao.DataSource = CarregaDados();
        }

        private List<EleicaoModel> CarregaDados()
        {
            return EleicaoDAO.BuscarListaEleicao();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EleicaoDAO.CadastrarEleicao(Convert.ToInt32(txtAno.Text), txtTipo.Text, 0);
            dgvEleicao.DataSource = CarregaDados();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEleicao.DataSource = EleicaoDAO.BuscarEleicao(Convert.ToInt32(txtAno.Text), txtTipo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GestaoEleicaoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
