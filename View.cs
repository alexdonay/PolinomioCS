using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio
{
    public class View
    {
        Leitor leitor = new Leitor();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Adicionar Polinomio");
            Console.WriteLine("2 - Listar todos Polinomios");
            Console.WriteLine("3 - Listar um polinomio específico");
            Console.WriteLine("4 - Somar Dois Polinomios");
            Console.WriteLine("5 - Avaliar um polinomio para um valor de X");
            Console.WriteLine("0 - Para Sair");
        }
        public Polinomio AdicionarPolinomio()
        {
            
            Polinomio polinomio = new Polinomio();
            while (true)
             {
                Console.Clear();
                int expoente;
                int coeficiente = leitor.Inteiro("Digite o valor do Coeficiente para o termo ou 0 para sair");
                if (coeficiente == 0)
                {
                    break;
                }
                else
                {
                     expoente = leitor.Inteiro("Digite o valor para o Expoente ou 0 se não houver");
                }

                
                polinomio.AdicionarTermo(coeficiente, expoente);
                
            }
            
            return polinomio;
        }
        public void ListarPolinomio(List<Polinomio> polinomios)
        {
            Console.Clear();
            for (int i = 0; i < polinomios.Count; i++)
            {
                
                Console.WriteLine($"Polinômio {i}: {polinomios[i].ToString()}");
            }
            Console.Read();
        }

        public void ListarUmPolinomio(List<Polinomio> polinomios)
        {
            Console.Clear();
            int i = leitor.Inteiro("Digite o indice de um polinomio");
            int totalPolinomios = polinomios.Count();
            if(i>=0&& i < totalPolinomios)
            {
                Console.WriteLine($"Polinômio {i}: {polinomios[i].ToString()}");
            }
            else
            {
                Console.WriteLine("Polinomio não encontrado");
            }
            Console.Read();
        } 
        public Polinomio Soma(List<Polinomio> polinomios)
        {
            Console.Clear();
            int indice1 = leitor.Inteiro("Digite o indice do primeiro polinomio");
            int indice2 = leitor.Inteiro("Digite o indice do segundo polinomio");
            Polinomio p1 = polinomios[indice1];
            Polinomio p2 = polinomios[indice2];
            Console.WriteLine(p1.SomarPolinomios(p2).ToString());
            Console.Read();
            return p1.SomarPolinomios(p2);
            
        }
        public void AvaliaPolinomio(List<Polinomio> polinomios)
        {
            Console.Clear();
            int indice = leitor.Inteiro("Digite o indice do polinomio a ser avaliado");
            int totalPolinomios = polinomios.Count();
            
            if (indice >= 0 && indice < totalPolinomios)
            {
                Polinomio polinomio = polinomios[indice];
                double x = leitor.PontoFlutuante("Digite o valor para testar a função");
                double resultado = polinomio.AvaliarPolinomio(polinomio, x);
                Console.WriteLine(resultado.ToString());
            }
            else
            {
                Console.WriteLine("Polinomio não encontrado");
            }
            
        }
    }

}
