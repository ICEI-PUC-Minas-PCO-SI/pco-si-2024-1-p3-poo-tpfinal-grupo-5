using UrnaEletronica.Model;

namespace UrnaEletronica
{
    public partial class UrnaView : Form
    {

        private Candidato candidatos;
        public UrnaView()
        {
            InitializeComponent();
        }

        private void UrnaView_Load(object sender, EventArgs e)
        {
            candidatos = new Candidato();
            candidatos.Carregar();
            dataGridView1.DataSource = candidatos.GetCandidatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Candidato candidato = new Candidato()
            {
                Nome = textBox1.Text,
                Numero = textBox2.Text,
                Partido = textBox3.Text
            };

            candidatos.Adicionar(candidato);
            candidatos.Salvar();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = candidatos.GetCandidatos();
            candidatos.Salvar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectdIndex = dataGridView1.SelectedRows[0].Index;

                if (selectdIndex >= 0 && selectdIndex < candidatos.GetCandidatos().Count)
                {
                    Candidato clienteSelecionado = dataGridView1.SelectedRows[0].DataBoundItem as Candidato;

                    candidatos.Remover(clienteSelecionado);
                    candidatos.Salvar();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = candidatos.GetCandidatos();
                }
                else
                {
                    MessageBox.Show("O indice selecionado é invalido");
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir");
            }
        }
    }
}
