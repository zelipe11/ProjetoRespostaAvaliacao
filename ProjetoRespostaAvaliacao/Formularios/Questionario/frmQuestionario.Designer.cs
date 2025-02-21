namespace ProjetoRespostaAvaliacao.Formularios.Questionario
{
    partial class frmQuestionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IDCAMPANHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAMPANHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTINICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTFIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORMATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPAVALIACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCAMPANHA,
            this.CAMPANHA,
            this.DTINICIO,
            this.DTFIM,
            this.FORMATO,
            this.TPAVALIACAO,
            this.IDPERGUNTA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(551, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Apenas camapanhas indentificadas terão que fazer login*";
            // 
            // IDCAMPANHA
            // 
            this.IDCAMPANHA.DataPropertyName = "CODPESQ";
            this.IDCAMPANHA.HeaderText = "Id";
            this.IDCAMPANHA.Name = "IDCAMPANHA";
            this.IDCAMPANHA.ReadOnly = true;
            this.IDCAMPANHA.Width = 30;
            // 
            // CAMPANHA
            // 
            this.CAMPANHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CAMPANHA.DataPropertyName = "DESCRICAOPESQ";
            this.CAMPANHA.HeaderText = "Campanha";
            this.CAMPANHA.Name = "CAMPANHA";
            this.CAMPANHA.ReadOnly = true;
            // 
            // DTINICIO
            // 
            this.DTINICIO.DataPropertyName = "DTINICIO";
            this.DTINICIO.HeaderText = "Data Inicio";
            this.DTINICIO.Name = "DTINICIO";
            this.DTINICIO.ReadOnly = true;
            // 
            // DTFIM
            // 
            this.DTFIM.DataPropertyName = "DTFIM";
            this.DTFIM.HeaderText = "Data Fim";
            this.DTFIM.Name = "DTFIM";
            this.DTFIM.ReadOnly = true;
            // 
            // FORMATO
            // 
            this.FORMATO.DataPropertyName = "FORMATOPESQ";
            this.FORMATO.HeaderText = "Formato";
            this.FORMATO.Name = "FORMATO";
            this.FORMATO.ReadOnly = true;
            // 
            // TPAVALIACAO
            // 
            this.TPAVALIACAO.DataPropertyName = "TIPOAVALIA";
            this.TPAVALIACAO.HeaderText = "Tipo Avaliação";
            this.TPAVALIACAO.Name = "TPAVALIACAO";
            this.TPAVALIACAO.ReadOnly = true;
            // 
            // IDPERGUNTA
            // 
            this.IDPERGUNTA.DataPropertyName = "IDPERGUNTA";
            this.IDPERGUNTA.HeaderText = "Id Pergunta";
            this.IDPERGUNTA.Name = "IDPERGUNTA";
            this.IDPERGUNTA.ReadOnly = true;
            this.IDPERGUNTA.Visible = false;
            // 
            // frmQuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmQuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCAMPANHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAMPANHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTINICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTFIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORMATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TPAVALIACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERGUNTA;
    }
}