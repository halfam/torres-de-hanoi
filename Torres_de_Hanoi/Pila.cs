using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*public Pila() que representa el constructor de la clase.
public void push(Disco d) que permitir´a colocar un disco en la pila de discos.
public Disco pop() que permitir´a extraer el disco de la parte superior de la pila.
public bool isEmpty() que informar´a si la pila est´a o no vac´ıa.
Size para representar la cantidad de discos que hay en el palo.
Top para representar el disco que est´a en la parte superior del palo.
Elementos para representar el conjunto de discos que hay en ese palo
*/
namespace Torres_de_Hanoi
{
    class Pila
    {
        private int _size;
        public int Size
        { 
            get 
            {
                return Elementos.Count;
            }
			
        }

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
       
        public Disco Top 
        {
			get 
            {
                return Elementos.Last<Disco>();
            }
        }

        /* TODO: Elegir tipo de Elementos
       public Disco[] Elementos { get; set; }
       public List<Disco> Elementos { get; set; }
       */
        public List<Disco> Elementos { get; set; }
        /* TODO: Implementar métodos */
        public Pila()
        {
            Elementos = new List<Disco>();
        }
        public Pila(List<Disco> discos)
        {
            Elementos = discos;
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
	        
        }

        public Disco pop()
        {
            if (this.isEmpty())
	        {
                return null;
	        }
            Disco elem = Top;
            Elementos.Remove(elem);
            return elem;
        }                

        public bool isEmpty()
        {
            if (Size == 0)
                return true;
            else
                return false;
        }

    }
}
