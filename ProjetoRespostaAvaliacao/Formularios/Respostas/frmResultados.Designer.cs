namespace ProjetoRespostaAvaliacao.Formularios.Respostas
{
    partial class frmResultados
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CODPESQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAOPESQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODGRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCGRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTRESPOSTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Func/Anonimo - Cargo Func";
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
            this.CODPESQ,
            this.DESCRICAOPESQ,
            this.CODGRUPO,
            this.DESCGRUPO,
            this.DTRESPOSTA,
            this.IDPERGUNTA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(601, 378);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // CODPESQ
            // 
            this.CODPESQ.DataPropertyName = "CODPESQ";
            this.CODPESQ.HeaderText = "Cod Pesq";
            this.CODPESQ.Name = "CODPESQ";
            this.CODPESQ.ReadOnly = true;
            this.CODPESQ.Visible = false;
            // 
            // DESCRICAOPESQ
            // 
            this.DESCRICAOPESQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRICAOPESQ.DataPropertyName = "DESCRICAOPESQ";
            this.DESCRICAOPESQ.HeaderText = "Descricao";
            this.DESCRICAOPESQ.Name = "DESCRICAOPESQ";
            this.DESCRICAOPESQ.ReadOnly = true;
            // 
            // CODGRUPO
            // 
            this.CODGRUPO.DataPropertyName = "CODGRUPO";
            this.CODGRUPO.HeaderText = "CodGrupo";
            this.CODGRUPO.Name = "CODGRUPO";
            this.CODGRUPO.ReadOnly = true;
            this.CODGRUPO.Visible = false;
            // 
            // DESCGRUPO
            // 
            this.DESCGRUPO.DataPropertyName = "DESCGRUPO";
            this.DESCGRUPO.HeaderText = "Grupo";
            this.DESCGRUPO.Name = "DESCGRUPO";
            this.DESCGRUPO.ReadOnly = true;
            // 
            // DTRESPOSTA
            // 
            this.DTRESPOSTA.DataPropertyName = "DTRESPOSTA";
            this.DTRESPOSTA.HeaderText = "Dt Resposta";
            this.DTRESPOSTA.Name = "DTRESPOSTA";
            this.DTRESPOSTA.ReadOnly = true;
            // 
            // IDPERGUNTA
            // 
            this.IDPERGUNTA.DataPropertyName = "IDPERGUNTA";
            this.IDPERGUNTA.HeaderText = "id pergunta";
            this.IDPERGUNTA.Name = "IDPERGUNTA";
            this.IDPERGUNTA.ReadOnly = true;
            this.IDPERGUNTA.Visible = false;
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPESQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAOPESQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODGRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCGRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTRESPOSTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERGUNTA;
    }
}