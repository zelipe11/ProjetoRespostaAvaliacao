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
    public partial class frmLoginQuestionario : Form
    {
        public frmLoginQuestionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = textBox1.Text;
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (InformacaoDAO.ExisteCPF(cpf))
            {
                frmQuestionario questionario = new frmQuestionario(cpf);
                questionario.Show();
            }
        }
    }
}
