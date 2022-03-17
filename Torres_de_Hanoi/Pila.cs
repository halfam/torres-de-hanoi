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
        private string _nombre;
        
        public string Nombre { get; set; }
        public int Size
        { 
            get 
            {
                return _elementos.Count;
            }
			
        }

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
       
        public int Top 
        {
			get 
            {
                if (this.isEmpty())
				{
                    return int.MaxValue;
				}
                return Elementos.Last<Disco>().Valor;
            }
        }

        /* TODO: Elegir tipo de Elementos
       public Disco[] Elementos { get; set; }
       public List<Disco> Elementos { get; set; }
       */
        private List<Disco> _elementos;
        public List<Disco> Elementos
        {
            get
            {
                return _elementos;
            }
            set
            {
                _elementos = new List<Disco>();
                for (int i = 0; i < value.Count; i++)
                {
                    if (value.ElementAt(i) != null)
                    {
                        _elementos.Add(value.ElementAt(i));
                    }
                }
            }
        }
        /* TODO: Implementar métodos */
        public Pila(string nombre)
        {
            this.Nombre =  nombre;
            Elementos = new List<Disco>();
        }
        public Pila(string nombre, List<Disco> discos)
        {
            this.Nombre = nombre;
            Elementos = discos;
        }

        public void push(Disco d)
        {
           Elementos.Add(d);
           Elementos = Elementos;
        }

        public Disco pop()
        {
            if (this.isEmpty())
	        {
                return null;
	        }
            Disco elem = Elementos.Last<Disco>();
            Elementos.Remove(elem);
            Elementos = Elementos;
            return elem;
        }                

        public bool isEmpty()
        {
            return Size == 0;
        }

    }
}
