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
        int Idgrupo = 0;
        public frmRespostaQuestionario(int idCampanha, int idGrupo)
        {
            InitializeComponent();
            this.IdCampanha = idCampanha;
            this.Idgrupo = idGrupo;

            label1.Text = "Anonimo";

            dataGridView1.DataSource = RespostaDAO.Perguntas(IdCampanha, Idgrupo);
        }
        
        public frmRespostaQuestionario(string cpf, int idCampanha, int idGrupo)
        {
            InitializeComponent();
            this.Cpf = cpf;
            this.IdCampanha = idCampanha;
            this.Idgrupo = idGrupo;

            CodUser = InformacaoDAO.CodigoUsuario(Cpf);
            DataTable dt = InformacaoDAO.InfoUsuario(Cpf);

            string nome = dt.Rows[0][0].ToString();
            string func = dt.Rows[0][1].ToString();

            label1.Text = nome + " - " + func;

            DataTable perguntas = RespostaDAO.Perguntas(IdCampanha, Idgrupo);

            perguntas.Columns.Add("RESPOSTA", typeof(string));
            perguntas.Columns.Add("OBSERVACAO", typeof(string));

            dataGridView1.DataSource = perguntas;

            foreach (DataRow row in perguntas.Rows)
            {
                if (row["ID"] != DBNull.Value)
                {
                    int id = Convert.ToInt32(row["ID"]);
                    int idPerg = Convert.ToInt32(row["IDPERGUNTA"]);

                    if (RespostaDAO.ExisteRespostaSalva(Idgrupo, CodUser, id, idPerg ))
                    {
                        DataTable resposta = RespostaDAO.RespostasSalvas(id, Idgrupo, CodUser, idPerg );

                        if (resposta.Rows.Count > 0)
                        {
                            row["RESPOSTA"] = resposta.Rows[0][0] != DBNull.Value ? resposta.Rows[0][0].ToString() : string.Empty;
                            row["OBSERVACAO"] = resposta.Rows[0][1] != DBNull.Value ? resposta.Rows[0][1].ToString() : string.Empty;
                        }
                        else
                        {
                            row["RESPOSTA"] = string.Empty;
                            row["OBSERVACAO"] = string.Empty;
                        }
                    }

                    if (RespostaDAO.ExisteRespostaFinalizada(Idgrupo, CodUser, id, idPerg))
                    {
                        button1.Enabled = false;
                        button2.Enabled = false;
                    }
                }
            }
            dataGridView1.Refresh();            

            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && (row.Cells["RESPOSTA"].Value == null || row.Cells["OBSERVACAO"].Value == null ||
                                      string.IsNullOrWhiteSpace(row.Cells["RESPOSTA"].Value.ToString()) ||
                                      string.IsNullOrWhiteSpace(row.Cells["OBSERVACAO"].Value.ToString())))
                {
                    MessageBox.Show("Todas as linhas devem ter as Respostas e Comentarios respondidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    int idperg = Convert.ToInt32(row.Cells["IDPERGUNTA"].Value);
                    int respostaFunc = Convert.ToInt32(row.Cells["RESPOSTA"].Value.ToString());
                    string comentarioFunc = row.Cells["OBSERVACAO"].Value.ToString();


                    RespostaDAO.FinalizarRespostas(Idgrupo, CodUser, id, respostaFunc, comentarioFunc, idperg);
                }
            }
            MessageBox.Show("Questionario respondido com sucesso");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    int idperg = Convert.ToInt32(row.Cells["IDPERGUNTA"].Value);
                    int respostaFunc = Convert.ToInt32(row.Cells["RESPOSTA"].Value.ToString());
                    string comentarioFunc = row.Cells["OBSERVACAO"].Value.ToString();

                    RespostaDAO.SalvarRespostas(Idgrupo, CodUser, id, respostaFunc, comentarioFunc, idperg);                    
                }
            }

            MessageBox.Show("Respostas salvas com sucesso!");
        }
    }
}
