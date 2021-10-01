using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FormularioWeb.Classes
{
    class Arquivo
    {

        string caminhoAbsoluto;
        string texto;
        StreamReader sr;

        public Arquivo(string caminhoAbsoluto)
        {
            this.caminhoAbsoluto = caminhoAbsoluto;
            tratarStreamReader();
        }

        public string getCaminhoAbsoluto()
        {
            return caminhoAbsoluto;
        }

        private void tratarStreamReader()
        {
            try
            {
                sr = new StreamReader(caminhoAbsoluto);
            }
            catch(Exception e)
            {
                sr = new StreamReader(e.Message);
            }
        }

        public List<string> preencherLista()
        {

            List<string> l = new List<string>();

            try
            {
                texto = sr.ReadLine();

                while (texto != null)
                {

                    l.Add(texto);

                    texto = sr.ReadLine();

                }
                sr.Close();

                return l;
            }
            catch(Exception e)
            {
                List<string> x = new List<string>();
                x.Add(e.Message);
                return x;
            }

        }
    }
}
