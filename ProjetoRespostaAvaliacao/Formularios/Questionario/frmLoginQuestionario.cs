using ProjetoRespostaAvaliacao.DAO;
using ProjetoRespostaAvaliacao.Formularios.Respostas;
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
        public string Tipo;
        public frmLoginQuestionario(string tipo)
        {
            InitializeComponent();
            this.Tipo = tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = textBox1.Text;
            string senha = textBox2.Text;
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (InformacaoDAO.ExisteCPF(cpf, senha) && Tipo == "AVALIACAO")
            {
                frmQuestionario questionario = new frmQuestionario(cpf);
                questionario.ShowDialog();
            }

            else if (!InformacaoDAO.ExisteCPF(cpf, senha) && Tipo == "AVALIACAO")
            {
                if (InformacaoDAO.TemCpf(cpf))
                {
                    if (!InformacaoDAO.TemSenha(cpf))
                    {
                        frmCriarSenha criarSenha = new frmCriarSenha(cpf);
                        criarSenha.ShowDialog();
                    }
                    else
                        MessageBox.Show("Senha Invalida!");
                }
                else
                    MessageBox.Show("Esse CPF não está cadastrado, entre em contato com o RH");
            }

            else if (!InformacaoDAO.ExisteCPF(cpf, senha) && Tipo == "RESPOSTAS")
            {
                if (InformacaoDAO.TemCpf(cpf))
                {
                    if (!InformacaoDAO.TemSenha(cpf))
                    {
                        frmCriarSenha criarSenha = new frmCriarSenha(cpf);
                        criarSenha.ShowDialog();
                    }
                    else
                        MessageBox.Show("Senha Invalida!");
                }
                else
                    MessageBox.Show("Esse CPF não está cadastrado, entre em contato com o RH");
            }

            else if (InformacaoDAO.ExisteCPF(cpf, senha) && Tipo == "RESPOSTAS")
            {
                frmResultados resultados = new frmResultados(cpf);
                resultados.ShowDialog();
            }

            else
                MessageBox.Show("Esse CPF não está cadastrado, entre em contato com o RH");
        }
    }
}
