namespace ProjetoRespostaAvaliacao.Formularios.Respostas
{
    partial class frmRespostas
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
            this.IDCAMPANHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAMPANHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTRESPOSTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCAMPANHA,
            this.CAMPANHA,
            this.DTRESPOSTA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(776, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // IDCAMPANHA
            // 
            this.IDCAMPANHA.HeaderText = "Id Campanha";
            this.IDCAMPANHA.Name = "IDCAMPANHA";
            this.IDCAMPANHA.ReadOnly = true;
            // 
            // CAMPANHA
            // 
            this.CAMPANHA.HeaderText = "Campanha";
            this.CAMPANHA.Name = "CAMPANHA";
            this.CAMPANHA.ReadOnly = true;
            // 
            // DTRESPOSTA
            // 
            this.DTRESPOSTA.HeaderText = "Data Resposta";
            this.DTRESPOSTA.Name = "DTRESPOSTA";
            this.DTRESPOSTA.ReadOnly = true;
            // 
            // frmRespostas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRespostas";
            this.Text = "Respostas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCAMPANHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAMPANHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTRESPOSTA;
    }
}