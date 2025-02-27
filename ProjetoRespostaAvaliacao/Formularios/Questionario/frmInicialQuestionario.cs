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
    public partial class frmInicialQuestionario : Form
    {
        public frmInicialQuestionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQuestionario frmQuestionario = new frmQuestionario();
            frmQuestionario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLoginQuestionario loginQuestionario = new frmLoginQuestionario("AVALIACAO");
            loginQuestionario.ShowDialog();
        }
    }
}
