
namespace FormularioWeb
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.wbNavegador = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUploadSite = new System.Windows.Forms.Button();
            this.txtCampoBusca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBtnDownload = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.dgvLinks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.fbdSelecionarArquivo = new System.Windows.Forms.FolderBrowserDialog();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fbdSelecionarPastaDownload = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelecionarPasta = new System.Windows.Forms.Button();
            this.lblPasta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnComecarDownload = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ofdSelecionarArquivo = new System.Windows.Forms.OpenFileDialog();
            this.txtBtnAcao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcaoBtnRetornar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sfdSalvarMusica = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbNavegador
            // 
            this.wbNavegador.Location = new System.Drawing.Point(12, 202);
            this.wbNavegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNavegador.Name = "wbNavegador";
            this.wbNavegador.Size = new System.Drawing.Size(618, 236);
            this.wbNavegador.TabIndex = 0;
            this.wbNavegador.FileDownload += new System.EventHandler(this.wbNavegador_FileDownload);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(18, 39);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(243, 20);
            this.txtURL.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAcaoBtnRetornar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBtnAcao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnUploadSite);
            this.groupBox1.Controls.Add(this.txtCampoBusca);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBtnDownload);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btnUploadSite
            // 
            this.btnUploadSite.Location = new System.Drawing.Point(460, 126);
            this.btnUploadSite.Name = "btnUploadSite";
            this.btnUploadSite.Size = new System.Drawing.Size(75, 41);
            this.btnUploadSite.TabIndex = 8;
            this.btnUploadSite.Text = "Carregar Site";
            this.btnUploadSite.UseVisualStyleBackColor = true;
            this.btnUploadSite.Click += new System.EventHandler(this.btnUploadSite_Click);
            // 
            // txtCampoBusca
            // 
            this.txtCampoBusca.Location = new System.Drawing.Point(18, 137);
            this.txtCampoBusca.Name = "txtCampoBusca";
            this.txtCampoBusca.Size = new System.Drawing.Size(110, 20);
            this.txtCampoBusca.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nome do campo \'Busca\'";
            // 
            // txtBtnDownload
            // 
            this.txtBtnDownload.Location = new System.Drawing.Point(18, 91);
            this.txtBtnDownload.Name = "txtBtnDownload";
            this.txtBtnDownload.Size = new System.Drawing.Size(110, 20);
            this.txtBtnDownload.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do botão \'Download\'";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCarregar);
            this.groupBox2.Controls.Add(this.lblArquivo);
            this.groupBox2.Controls.Add(this.btnSelecionarArquivo);
            this.groupBox2.Controls.Add(this.dgvLinks);
            this.groupBox2.Location = new System.Drawing.Point(541, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 160);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Músicas";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(6, 129);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 6;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(87, 105);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(43, 13);
            this.lblArquivo.TabIndex = 5;
            this.lblArquivo.Text = "Arquivo";
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(6, 100);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarArquivo.TabIndex = 4;
            this.btnSelecionarArquivo.Text = "Selecionar";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // dgvLinks
            // 
            this.dgvLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinks.Location = new System.Drawing.Point(6, 21);
            this.dgvLinks.Name = "dgvLinks";
            this.dgvLinks.Size = new System.Drawing.Size(219, 73);
            this.dgvLinks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço";
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(16, 98);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(100, 23);
            this.pbDownload.TabIndex = 3;
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.Location = new System.Drawing.Point(122, 101);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(21, 13);
            this.lblPercentual.TabIndex = 4;
            this.lblPercentual.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Download";
            // 
            // btnSelecionarPasta
            // 
            this.btnSelecionarPasta.Location = new System.Drawing.Point(11, 44);
            this.btnSelecionarPasta.Name = "btnSelecionarPasta";
            this.btnSelecionarPasta.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarPasta.TabIndex = 7;
            this.btnSelecionarPasta.Text = "Selecionar";
            this.btnSelecionarPasta.UseVisualStyleBackColor = true;
            this.btnSelecionarPasta.Click += new System.EventHandler(this.btnSelecionarPasta_Click);
            // 
            // lblPasta
            // 
            this.lblPasta.AutoSize = true;
            this.lblPasta.Location = new System.Drawing.Point(101, 49);
            this.lblPasta.Name = "lblPasta";
            this.lblPasta.Size = new System.Drawing.Size(34, 13);
            this.lblPasta.TabIndex = 7;
            this.lblPasta.Text = "Pasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Caminho p/ Download";
            // 
            // btnComecarDownload
            // 
            this.btnComecarDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComecarDownload.Location = new System.Drawing.Point(647, 341);
            this.btnComecarDownload.Name = "btnComecarDownload";
            this.btnComecarDownload.Size = new System.Drawing.Size(143, 97);
            this.btnComecarDownload.TabIndex = 8;
            this.btnComecarDownload.Text = "Começar";
            this.btnComecarDownload.UseVisualStyleBackColor = true;
            this.btnComecarDownload.Click += new System.EventHandler(this.btnComecarDownload_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbDownload);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblPasta);
            this.groupBox3.Controls.Add(this.lblPercentual);
            this.groupBox3.Controls.Add(this.btnSelecionarPasta);
            this.groupBox3.Location = new System.Drawing.Point(636, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 133);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Baixando...";
            // 
            // ofdSelecionarArquivo
            // 
            this.ofdSelecionarArquivo.FileName = "openFileDialog1";
            this.ofdSelecionarArquivo.Title = "Arquivo";
            // 
            // txtBtnAcao
            // 
            this.txtBtnAcao.Location = new System.Drawing.Point(159, 91);
            this.txtBtnAcao.Name = "txtBtnAcao";
            this.txtBtnAcao.Size = new System.Drawing.Size(110, 20);
            this.txtBtnAcao.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome da ação do Botão \r\n\'Download\'";
            // 
            // txtAcaoBtnRetornar
            // 
            this.txtAcaoBtnRetornar.Location = new System.Drawing.Point(159, 147);
            this.txtAcaoBtnRetornar.Name = "txtAcaoBtnRetornar";
            this.txtAcaoBtnRetornar.Size = new System.Drawing.Size(110, 20);
            this.txtAcaoBtnRetornar.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome da ação do Botão \r\n\'Retornar\'";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.btnComecarDownload);
            this.Controls.Add(this.wbNavegador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Songs Downloader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbNavegador;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCampoBusca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBtnDownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.DataGridView dgvLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbdSelecionarArquivo;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog fbdSelecionarPastaDownload;
        private System.Windows.Forms.Button btnSelecionarPasta;
        private System.Windows.Forms.Label lblPasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnComecarDownload;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.OpenFileDialog ofdSelecionarArquivo;
        private System.Windows.Forms.Button btnUploadSite;
        private System.Windows.Forms.TextBox txtBtnAcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcaoBtnRetornar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog sfdSalvarMusica;
    }
}

