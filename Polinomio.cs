using System;
using System.Collections.Generic;

namespace Polinomio
{
    public class Polinomio
    {
        List<Termo> termos = new List<Termo>();
        public Polinomio() { }
        public void AdicionarTermo(int coeficiente, int expoente)
        {
            Termo T = new Termo(coeficiente, expoente);
            bool encontrado = false;
            foreach (Termo termo in termos)
            {
                if (termo.Expoente == expoente)
                {
                    termo.Coeficiente += coeficiente;
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                termos.Add(T);
            }
        }
        public void OrdenarTermos()
        {
            termos.Sort((x, y) => y.Expoente.CompareTo(x.Expoente));
        }
        public Polinomio SomarPolinomios(Polinomio b)
        {
            Polinomio resultado = new Polinomio();
            Polinomio maior;
            Polinomio menor;
            if (this.termos.Count > b.termos.Count)
            {
                maior = this;
                menor = b;
            }
            else
            {
                maior = b;
                menor = this;
            }
            foreach (Termo T1 in maior.termos)
            {
                bool encontrado = false;
                foreach (Termo T2 in menor.termos)
                {
                    if (T1.Expoente == T2.Expoente)
                    {
                        resultado.AdicionarTermo(T1.Coeficiente + T2.Coeficiente, T1.Soma(T2).Expoente);
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    resultado.AdicionarTermo(T1.Coeficiente, T1.Expoente);
                }
            }
            foreach (Termo T2 in menor.termos)
            {
                bool encontrado = false;
                foreach (Termo T1 in maior.termos)
                {
                    if (T1.Expoente == T2.Expoente)
                    {
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    resultado.AdicionarTermo(T2.Coeficiente, T2.Expoente);
                }
            }
            return resultado;
        }
        public double AvaliarPolinomio(Polinomio polinomio, double x)
        {
            double resultado = 0;
            foreach (Termo termo in polinomio.termos)
            {
                if(termo.Expoente == 0)
                {
                    resultado += termo.Coeficiente;
                }
                else
                {
                resultado += termo.Coeficiente * Math.Pow(x, termo.Expoente);
                }
            }
            return resultado;
        }

        public override string ToString()
        {
            string resultado = "";
            this.OrdenarTermos();

            foreach (Termo termo in termos)
            {
                string st = termo.ToString();
                resultado = resultado == "" ? st.Replace("+", "") : resultado + st;

            }
            return resultado;
        }
        public Polinomio ObterPolinomioPorIndice(int indice)
        {
            if (indice < 0 || indice >= termos.Count)
            {
                throw new IndexOutOfRangeException("O índice fornecido está fora dos limites do polinômio.");
            }
            Polinomio resultado = new Polinomio();
            resultado.AdicionarTermo(termos[indice].Coeficiente, termos[indice].Expoente);

            return resultado;

        }
    }
}
