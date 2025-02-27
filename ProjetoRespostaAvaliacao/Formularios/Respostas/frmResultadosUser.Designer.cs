namespace ProjetoRespostaAvaliacao.Formularios.Respostas
{
    partial class frmResultadosUser
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
            this.IDPERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESPOSTAFUNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMENTARIOFUNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTFINALIZA = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.IDPERGUNTA,
            this.PERGUNTA,
            this.RESPOSTAFUNC,
            this.COMENTARIOFUNC,
            this.DTFINALIZA});
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 426);
            this.dataGridView1.TabIndex = 3;
            // 
            // IDPERGUNTA
            // 
            this.IDPERGUNTA.DataPropertyName = "IDPERGUNTA";
            this.IDPERGUNTA.HeaderText = "idpergunta";
            this.IDPERGUNTA.Name = "IDPERGUNTA";
            this.IDPERGUNTA.ReadOnly = true;
            this.IDPERGUNTA.Visible = false;
            // 
            // PERGUNTA
            // 
            this.PERGUNTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PERGUNTA.DataPropertyName = "PERGUNTA";
            this.PERGUNTA.HeaderText = "Pergunta";
            this.PERGUNTA.Name = "PERGUNTA";
            this.PERGUNTA.ReadOnly = true;
            // 
            // RESPOSTAFUNC
            // 
            this.RESPOSTAFUNC.DataPropertyName = "RESPOSTAFUNC";
            this.RESPOSTAFUNC.HeaderText = "Resposta";
            this.RESPOSTAFUNC.Name = "RESPOSTAFUNC";
            this.RESPOSTAFUNC.ReadOnly = true;
            // 
            // COMENTARIOFUNC
            // 
            this.COMENTARIOFUNC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COMENTARIOFUNC.DataPropertyName = "COMENTARIOFUNC";
            this.COMENTARIOFUNC.HeaderText = "Comentario";
            this.COMENTARIOFUNC.Name = "COMENTARIOFUNC";
            this.COMENTARIOFUNC.ReadOnly = true;
            // 
            // DTFINALIZA
            // 
            this.DTFINALIZA.DataPropertyName = "DTFINALIZA";
            this.DTFINALIZA.HeaderText = "Dt Resposta";
            this.DTFINALIZA.Name = "DTFINALIZA";
            this.DTFINALIZA.ReadOnly = true;
            // 
            // frmResultadosUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmResultadosUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resposta Questionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERGUNTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERGUNTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESPOSTAFUNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIOFUNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTFINALIZA;
    }
}