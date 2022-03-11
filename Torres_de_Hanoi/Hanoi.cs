using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
			if (a.Top < b.Top || b.Top ==0)
			{
                a.push(b.pop());
			}
			else
			{
				if (a.Top != b.Top)
				{
                    b.push(a.pop());
				}
			}
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
			int m = 0;
			if (n % 2 == 0)
			{
				while (fin.Size != n)
				{
					m++; 
					mover_disco(ini, fin);
					m++;
					mover_disco(ini, aux);
					m++;
					mover_disco(aux, fin);
				}
			}
			else
			{
				while (ini.Size != 0 || aux.Size != 0)
				{
					m++;
					mover_disco(ini, aux);
					m++; 
					mover_disco(ini, fin);
					m++; 
					mover_disco(aux, fin);
				}
			}
            return m;
        }

    }
}
