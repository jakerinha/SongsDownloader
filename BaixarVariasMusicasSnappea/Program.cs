using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Net;

namespace BaixarVariasMusicasSnappea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varíaveis

            Program x = new Program();
            List<string> l = new List<string>();


            l = x.preencherLista();



            

            
        }

        List<string> preencherLista()
        {

            List<string> x = new List<string>();

            int aux = 0;
            char op;
            string item;

            while (aux != 1)
            {
                item = Console.ReadLine();

                x.Add(item);

                Console.WriteLine("Deseja continuar?\n");

                op = Convert.ToChar(Console.ReadLine());

                if (op != 'N')
                {
                    break;
                }

            }

            return x;
        }
    
        void alimentarHTML(List<string> x)
        {
            WebClient web = new WebClient();

            web.BaseAddress = "https://www.snappea.com/pt1/";

        }
    
    }
}
