using System.Data;
using System.Windows.Forms;

namespace WF_ADONet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas where nome = '" + txbNome.Text + "'";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txbNomeNew.Text;
            p.profissao = txbProfissao.Text;

            if (p.gravarPessoa())
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                Pessoa p = new Pessoa();
                if (p.consultaPessoa(id) != null)
                {
                    if (p.excluir())
                    {
                        MessageBox.Show("Excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir!");
                    }
                }
                else
                {
                    MessageBox.Show("Pessoa não encontrada!");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa para excluir!");
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}