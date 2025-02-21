using FuncoesWinthor;
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

namespace ProjetoRespostaAvaliacao.Formularios.Questionario
{
    public partial class frmQuestionario : Form
    {
        string Cpf;
        public frmQuestionario()
        {
            InitializeComponent();
        }

        public frmQuestionario(string cpf)
        {
            InitializeComponent();
            this.Cpf = cpf;
            int codsetor = InformacaoDAO.SetorDoUsuario(cpf);
            dataGridView1.DataSource = QuestionarioDAO.Questionarios(codsetor);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["FORMATO"].Value?.ToString() == "IDENTIFICADA")
                {
                    int idPergunta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDPERGUNTA"].Value);
                    frmRespostaQuestionario respostaQuestionario = new frmRespostaQuestionario(Cpf, idPergunta);
                    respostaQuestionario.ShowDialog();
                                 
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells["FORMATO"].Value?.ToString() == "ANONIMA")
                {
                    int idPergunta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDPERGUNTA"].Value);
                    frmRespostaQuestionario respostaQuestionario = new frmRespostaQuestionario(idPergunta);
                    respostaQuestionario.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha");
            }
        }
    }
}
