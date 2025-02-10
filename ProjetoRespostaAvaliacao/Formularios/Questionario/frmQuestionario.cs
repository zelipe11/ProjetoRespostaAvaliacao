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
        public frmQuestionario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["FORMATO"].Value?.ToString() == "IDENTIFICADA")
                {
                    //login

                    frmRespostaQuestionario respostaQuestionario = new frmRespostaQuestionario();
                    respostaQuestionario.ShowDialog();
                }
                else
                {
                    frmRespostaQuestionario respostaQuestionario = new frmRespostaQuestionario();
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
