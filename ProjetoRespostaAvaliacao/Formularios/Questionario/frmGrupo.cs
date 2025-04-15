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
    public partial class frmGrupo : Form
    {
        public int IdPesquisa;
        public string Cpf;
        bool Indentificada;

        public frmGrupo(string cpf, int idPesquisa)
        {
            InitializeComponent();
            this.IdPesquisa = idPesquisa;
            this.Cpf = cpf;
            int setor = InformacaoDAO.SetorDoUsuario(cpf);
            dataGridView2.DataSource = RespostaDAO.Grupos(IdPesquisa, setor);
            Indentificada = true;
        }
        
        public frmGrupo(int idPesquisa)
        {
            InitializeComponent();
            this.IdPesquisa = idPesquisa;
            dataGridView2.DataSource = RespostaDAO.Grupos(IdPesquisa, 0);
            Indentificada = false;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                int grupo = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["CODGRUPO"].Value);

                if (Indentificada)
                {
                    frmRespostaQuestionario respostaQuestionario = new frmRespostaQuestionario(Cpf, IdPesquisa, grupo);
                    respostaQuestionario.ShowDialog();
                }
                else if (!Indentificada)
                {
                    frmRespostaQuestionario respostaQuestionario = new frmRespostaQuestionario(IdPesquisa, grupo);
                    respostaQuestionario.ShowDialog();
                }
            }
        }
    }
}
