﻿using ProjetoRespostaAvaliacao.DAO;
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
    public partial class frmResultadosUser : Form
    {
        public frmResultadosUser(int codfunc, int codperg, int codgrupo)
        {
            InitializeComponent();

            dataGridView1.DataSource = ResultadosDAO.RespostaPergUsuario(codfunc, codperg, codgrupo);
        }
    }
}
