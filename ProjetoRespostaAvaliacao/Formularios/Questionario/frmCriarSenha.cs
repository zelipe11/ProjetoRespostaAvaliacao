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
    public partial class frmCriarSenha : Form
    {
        string Cpf;
        public frmCriarSenha(string cpf)
        {
            InitializeComponent();

            this.Cpf = cpf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                string senha = textBox1.Text;
                InformacaoDAO.CriarSenha(Cpf, senha);
                this.Close();
            }
            else
                MessageBox.Show("Os dois campos estão diferentes");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox1.Text && textBox2.Text.Length > 0)
            {
                label3.Visible = true;
            }
            else
                label3.Visible = false;
        }
    }
}
