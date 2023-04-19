using System;
using System.Collections.Generic;

namespace Polinomio
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Polinomio> polinomios = new List<Polinomio>();
            Polinomio polinomio;
            Leitor leitor = new Leitor();
            View view = new View();
            int op = 19999;
            while (op != 0)
            {
                
                
                view.Menu();
                op = leitor.Inteiro("Digite Sua opção");
                switch (op)
                {
                    case 0:
                        Console.WriteLine("saindo do programa");
                        break;
                    case 1:
                        polinomio= new Polinomio();
                        polinomio = view.AdicionarPolinomio();
                        if(polinomio != null)
                        {
                            polinomios.Add(polinomio);
                        }
                        
                        break;
                    case 2:
                        view.ListarPolinomio(polinomios);
                        break;
                    case 3:
                        view.ListarUmPolinomio(polinomios);
                        break;
                    case 4:
                        Polinomio poli = new Polinomio();
                        poli = view.Soma(polinomios);
                        polinomios.Add(poli);
                        break;
                    case 5:
                        view.AvaliaPolinomio(polinomios);
                        break;

                }
            }
        }
    }
}
