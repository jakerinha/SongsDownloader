using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;

namespace FormularioWeb.Classes
{
    class Navegador
    {

        private string url;
        private string botaoDownload;
        private string localArmazenamento;
        private string campoBusca;
        private string acaoBotaoDownload;
        private string acaoBotaoRetornar;
        private string arquivo;

        public Navegador(string url, string botaoDownload, string localArmazenamento, string campoBusca)
        {
            this.url = url;
            this.botaoDownload = botaoDownload;
            this.localArmazenamento = localArmazenamento;
            this.campoBusca = campoBusca;
        }

        public Navegador(string url)
        {
            this.url = url;
        }

        //Setters
        public void setURL(string url)
        {
            this.url = url;
        }

        public void setAcaoBotaoDownload(string acaoBotaoDownload)
        {
            this.acaoBotaoDownload = acaoBotaoDownload;
        }

        public void setAcaoBotaoRetornar(string acaoBotaoRetornar)
        {
            this.acaoBotaoRetornar = acaoBotaoRetornar;
        }


        public void setBotaoDownload(string botaoDownload)
        {
            this.botaoDownload = botaoDownload;
        }

        public void setLocalArmazenamento(string localArmazenamento)
        {
            this.localArmazenamento = localArmazenamento;
        }

        public void setCampoBusca(string campoBusca)
        {
            this.campoBusca = campoBusca;
        }

        //Getters

        public string getURL()
        {
            return url;
        }
        
        public string getBotaoDownload()
        {
            return botaoDownload;
        }

        public string getLocalArmazenamento()
        {
            return localArmazenamento;
        }

        public string getCampoBusca()
        {
            return campoBusca;
        }


        //Demais Métodos

        public WebBrowser baixarArquivo(WebBrowser browser, string link)
        {
            try
            {
                HtmlElement btnDownload = browser.Document.GetElementById(botaoDownload);
                HtmlElement buscador = browser.Document.GetElementById(campoBusca);
                
                buscador.InnerText = link;
                btnDownload.InnerHtml = "button";
                //browser.FileDownload = browser.Document.ExecCommand("onClick= " + acaoBotaoDownload, true, botaoDownload);
                
                return browser;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void BtnDownload_Click(object sender, HtmlElementEventArgs e)
        {
            
        }
    }
}
