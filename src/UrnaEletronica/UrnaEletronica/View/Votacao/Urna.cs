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

namespace UrnaEletronica.View.Votacao
{
    public partial class Urna : Form
    {
        private Dictionary<string, Candidato> _dicCandidato;
        private System.Windows.Forms.Timer relogio; // Declarando o Timer
        private string voto = "";
        private bool mantemEleicao = true;
        public Urna(EleicaoModel ele)
        {
            InitializeComponent();
            lblAno.Text = Convert.ToString(ele.ano);
            Tipo.Text = ele.tipo;
            ComecaEleicao();
            //_dicCandidato = new Dictionary<string, Candidato>();
            //_dicCandidato.Add("51", new Candidato() { Id = 51, Nome = "Darth Vader", Partido = "Império", Foto = null });
            //_dicCandidato.Add("52", new Candidato() { Id = 52, Nome = "Chapolin", Partido = "Quase Nada", Foto = null});
            //_dicCandidato.Add("91", new Candidato() { Id = 91, Nome = "Goku", Partido = "Saijin", Foto = null});
            //_dicCandidato.Add("92", new Candidato() { Id = 92, Nome = "Homem de Ferro", Partido = "Vingadores", Foto = null });
            //_dicCandidato.Add("99", new Candidato() { Id = 99, Nome = "Batman", Partido = "Liga da Justiça", Foto = null });

            relogio = new System.Windows.Forms.Timer();// Inicializando o Timer
        }

        private void ComecaEleicao()
        {
            while (mantemEleicao)
            {

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
            txtDecimal.Text = "";
            txtUnidade.Text = "";
            lblNomeCandidato.Text = String.Empty;
            lblPartidoCandidato.Text = String.Empty;
            picFotoCandidato.Image = null;
        }

        private void RegistrarDigito(string digito)
        {
            if (string.IsNullOrEmpty(txtDecimal.Text))
                txtDecimal.Text = digito;
            else
            {
                txtUnidade.Text = digito;
                PreencherCandidato(txtDecimal.Text, txtUnidade.Text);
            }

            //SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            // s.Play();
        }

        private void PreencherCandidato(string d1, string d2)
        {

        }

        private void AcaoFinal(Object? myObject, EventArgs myEventArgs)
        {
            relogio.Stop();
            relogio.Enabled = false;

            panelPrincipal.Visible = true;
        }

        public class Candidato
        {
            public int Id { get; set; }
            public string? Nome { get; set; }
            public string? Partido { get; set; }
            public Image? Foto { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            voto += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            voto += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            voto += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            voto += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            voto += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            voto += "6";
            RegistrarDigito("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            voto += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            voto += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            voto += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            voto += "0";
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            Limpar();
            relogio.Stop();
            relogio.Enabled = false;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            test.Text = voto;
            if (string.IsNullOrEmpty(txtDecimal.Text))
            {
                MessageBox.Show("Favor informar o candidato.");
                return;
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
            //InitializeComponent();
        }

        private void btn_terminarVotacao_Click(object sender, EventArgs e)
        {
            mantemEleicao = false;
        }
    }
}
