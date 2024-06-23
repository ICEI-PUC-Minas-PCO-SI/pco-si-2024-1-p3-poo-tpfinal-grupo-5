using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using UrnaEletronica.Model;
using UrnaEletronica.Data.DAO.Candidato;
using UrnaEletronica.Data.DAO.Partido;
using UrnaEletronica.Data.DAO.Eleicao;
using UrnaEletronica.Data.DTO.Candidato;

namespace UrnaEletronica.View.Votacao
{
    public partial class Urna : Form
    {
        private System.Windows.Forms.Timer relogio;
        private string voto = "";
        private bool mantemEleicao = true;
        private EleicaoModel eleicao;

        public Urna(EleicaoModel ele)
        {
            InitializeComponent();
            eleicao = ele;
            lblAno.Text = Convert.ToString(ele.ano);
            Tipo.Text = ele.tipo;
            RodaEleicao();

            relogio = new System.Windows.Forms.Timer();
        }

        private void RodaEleicao()
        {
            if(tipoCandidato.Text == "Executivo")
            {
                tipoCandidato.Text = "Vereador";
            } else
            {
                tipoCandidato.Text = "Deputado Federal";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            Limpar();

            //SoundPlayer s = new SoundPlayer(Properties.Resources.urna);
            //s.Play();

            relogio.Tick -= AcaoFinal;

            relogio.Tick += new EventHandler(AcaoFinal);
            relogio.Interval = 300;
            relogio.Enabled = true;
            relogio.Start();
        }

        private void Limpar()
        {
            txtVoto.Text = "";
            lblNomeCandidato.Text = String.Empty;
            lblPartidoCandidato.Text = String.Empty;
            picFotoCandidato.Image = null;
        }


        private void AcaoFinal(Object? myObject, EventArgs myEventArgs)
        {
            relogio.Stop();
            relogio.Enabled = false;

            panelPrincipal.Visible = true;
        }

        private void ContaVoto(string v)
        {
            if(Tipo.Text == "Legislativo")
            {
                
            }
            txtVoto.Text += v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaVoto("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContaVoto("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContaVoto("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ContaVoto("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContaVoto("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContaVoto("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ContaVoto("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ContaVoto("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ContaVoto("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ContaVoto("0");
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            Limpar();
            relogio.Stop();
            relogio.Enabled = false;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            //test.Text = voto;
            string Voto = txtVoto.Text;
            if (string.IsNullOrEmpty(Voto))
            {
                MessageBox.Show("Favor informar o candidato.");
            }
            else
            {
                string Tipo = tipoCandidato.Text;
                if(Tipo == "Prefeito")
                {
                    if(Voto.Length == 2)
                    {
                        CandidatoModel c = CandidatoDAO.BuscarCandidatoNumero(Convert.ToInt32(txtVoto.Text));
                        lblNomeCandidato.Text = c.nome;
                        PartidoModel p = PartidoDAO.BuscarPartido(c.id_partido);
                        lblPartidoCandidato.Text = p.sigla;

                        EleicaoDAO.ContaVotoCandidato(c.IdCandidato, eleicao.id_eleicao);
                    }
                    else
                    {
                        MessageBox.Show("Tá fazendo merda, presta atenção");
                    }
                }
            }

            panelPrincipal.Visible = false;
            Limpar();
            //SoundPlayer s = new SoundPlayer(Properties.Resources.urna);
            //s.Play();

            // Remova o EventHandler existente para evitar múltiplas associações
            relogio.Tick -= AcaoFinal;

            relogio.Tick += new EventHandler(AcaoFinal);
            relogio.Interval = 3000;
            relogio.Enabled = true;
            relogio.Start();
        }

        private void btn_terminarVotacao_Click(object sender, EventArgs e)
        {
            mantemEleicao = false;
        }

        private void txtVoto_TextChanged(object sender, EventArgs e)
        {
            if(tipoCandidato.Text == "Presidente" && txtVoto.Text.Length == 2)
            {
                CandidatoModel c = CandidatoDAO.BuscarCandidatoNumero(Convert.ToInt32(txtVoto.Text));
                PartidoModel p = PartidoDAO.BuscarPartido(c.id_partido);
                lblNomeCandidato.Text = c.apelido;
                lblPartidoCandidato.Text = p.sigla;


            }
        }


    }
}
