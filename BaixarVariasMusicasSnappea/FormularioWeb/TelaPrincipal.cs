using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormularioWeb.Classes;

namespace FormularioWeb
{
    public partial class TelaPrincipal : Form
    {

        Arquivo arquivo;
        Navegador browser;

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            
            ofdSelecionarArquivo.ShowDialog();

            if (String.IsNullOrEmpty(ofdSelecionarArquivo.FileName) != true)
            {
                arquivo = new Arquivo(ofdSelecionarArquivo.FileName);

                lblArquivo.Text = arquivo.getCaminhoAbsoluto();
            }

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            construirTabela();

            preencherDGV();
            
        }

        private void preencherDGV()
        {
            List<string> l = new List<string>();

            l = arquivo.preencherLista();
            int aux = 0;

            foreach (string x in l)
            {
                dgvLinks.Rows[aux].Cells[0].Value = x;
                aux++;

                dgvLinks.Rows.Add(x);

            }
        }

        private void construirTabela()
        {
            dgvLinks.Columns.Add("linkYoutube", "Links");
        }

        private string selecionarPastaDownload()
        {
            fbdSelecionarPastaDownload.ShowDialog();

            
            if (!String.IsNullOrEmpty(fbdSelecionarPastaDownload.SelectedPath))
            {
                string pastaDownload = fbdSelecionarPastaDownload.SelectedPath;

                return pastaDownload;
            }
            else
            {
                return null;
            }


        }


        private void receberBrowser()
        {
            string endereco = txtURL.Text;

            browser = new Navegador(endereco);
            receberCampos();
            wbNavegador.ScriptErrorsSuppressed = true;
            wbNavegador.Navigate(endereco);
            
        }

        private void receberCampos()
        {
            string btnDownload = txtBtnDownload.Text;
            string campoBusca = txtCampoBusca.Text;
            string localArmazenamento = lblArquivo.Text;
            string acaoBtnDownload = txtBtnAcao.Text;
            string acaoBtnRetornar = txtAcaoBtnRetornar.Text;

            browser.setBotaoDownload(btnDownload);
            browser.setCampoBusca(campoBusca);
            browser.setLocalArmazenamento(localArmazenamento);
            browser.setAcaoBotaoDownload(acaoBtnDownload);
            browser.setAcaoBotaoRetornar(acaoBtnRetornar);
        }

        private void buscarMusicas()
        {
            for(int i = 0; i < dgvLinks.RowCount; i++)
            {
                browser.baixarArquivo(wbNavegador, Convert.ToString(dgvLinks.Rows[i].Cells[0].Value));

                int percentual = barraProgresso(i) * 100;

                pbDownload.Value = percentual;
                lblPercentual.Text = percentual + "%";
            }
        }

        private int barraProgresso(int indice)
        {
            int tamanhoGrid = dgvLinks.RowCount;

            return (indice / tamanhoGrid);

        }

        private void btnUploadSite_Click(object sender, EventArgs e)
        {
            receberBrowser();
        }

        private void wbNavegador_FileDownload(object sender, EventArgs e)
        {
            //sfdSalvarMusica.InitialDirectory = browser.getLocalArmazenamento();
            //sfdSalvarMusica.ShowDialog();
        }

        private void btnComecarDownload_Click(object sender, EventArgs e)
        {
            buscarMusicas();
        }

        private void btnSelecionarPasta_Click(object sender, EventArgs e)
        {
            selecionarPastaDownload();
        }
    }
}
