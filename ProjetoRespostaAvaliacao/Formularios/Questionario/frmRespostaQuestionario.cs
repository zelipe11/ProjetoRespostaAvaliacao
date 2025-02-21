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
    public partial class frmRespostaQuestionario : Form
    {
        string Cpf;
        int IdCampanha;
        int CodUser = 0;
        public frmRespostaQuestionario(int idCampanha)
        {
            InitializeComponent();
            this.IdCampanha = idCampanha;
        }
        
        public frmRespostaQuestionario(string cpf, int idCampanha)
        {
            InitializeComponent();
            this.Cpf = cpf;
            this.IdCampanha = idCampanha;

            CodUser = InformacaoDAO.CodigoUsuario(cpf);
            DataTable dt = InformacaoDAO.InfoUsuario(cpf);

            string nome = dt.Rows[0][0].ToString();
            string func = dt.Rows[0][1].ToString();

            label1.Text = nome + " - " + func;

            dataGridView1.DataSource = RespostaDAO.Perguntas(idCampanha);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
