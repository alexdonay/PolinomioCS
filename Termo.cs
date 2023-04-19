using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio
{
    public class Termo
    {
       public int Coeficiente { get; set; }
       public int Expoente { get; set; }

        public Termo()
        {
        }

        public Termo(int coeficiente, int expoente)
        {
            this.Coeficiente = coeficiente;
            this.Expoente = expoente;
        }
        public Termo Soma(Termo a)
        {
            return new Termo(a.Coeficiente + this.Coeficiente, this.Expoente);
            
        }
        public override string ToString()
        {
            string Sinal = this.Coeficiente > 0 ? "+" : "-";
            string st;
            if (this.Expoente == 1) {
                st = $"{Sinal}{Math.Abs(this.Coeficiente)}X";
            }else if(this.Expoente == 0) {
                st = $"{Sinal}{Math.Abs(this.Coeficiente)}";
            }
            else
            {
                st = $"{Sinal}{Math.Abs(this.Coeficiente)}X{this.Expoente}";
            }
            return st;
        }
    }
}
