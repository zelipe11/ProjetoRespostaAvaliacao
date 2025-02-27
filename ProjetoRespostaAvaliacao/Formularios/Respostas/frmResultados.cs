using ProjetoRespostaAvaliacao.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRespostaAvaliacao.Formularios.Respostas
{
    public partial class frmResultados : Form
    {
        string Cpf;
        int CodSetor = 0;
        int CodFunc = 0;

        public frmResultados(string cpf)
        {
            InitializeComponent();
            this.Cpf = cpf;

            CodSetor = InformacaoDAO.SetorDoUsuario(Cpf);
            CodFunc = InformacaoDAO.CodigoUsuario(Cpf);

            DataTable info = InformacaoDAO.InfoUsuario(Cpf);
            string nome = info.Rows[0][0].ToString();
            string cargo = info.Rows[0][1].ToString();

            label1.Text = nome + " - " + cargo;

            dataGridView1.DataSource = ResultadosDAO.RespostasUsuario(CodFunc, CodSetor);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int idpergunta = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IDPERGUNTA"].Value);
                int codgrupo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CODGRUPO"].Value);

                frmResultadosUser result = new frmResultadosUser(CodFunc, idpergunta, codgrupo);
                result.ShowDialog();
            }
        }
    }
}
