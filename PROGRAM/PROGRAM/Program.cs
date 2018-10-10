using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contains: indica si un cierto elemento está en la pila.
            //GetType: para saber de que tipo son los elementos almacenados en la pila.
            //ToString: devuelve el elemento actual convertido en un string.
            //ToArray. devuelve toda la pila convertida en un array.
            //GetEnumerator: permite usar enumeradores para recorrer la pila.

            // Objeto Creado
            Stack miPila = new Stack();

            //se apilan los diferentes elementos utilizando metodo Push()
            miPila.Push(2);
            miPila.Push('3');
            miPila.Push("Esta Chido");
            miPila.Push("Primer elemento");
            

             //Utilizamos el metodo Contains para ver si cierto elemento esta en la pila
         //-->Devuelve true or false dependiendo si esta en la Pila.
         Console.WriteLine("La Pila esta chida? {0}", miPila.Contains("Esta Chido"));
        
 
 
         //Utilizamos el metodo Count para saber el numero de elementos
         Console.WriteLine("NUMERO DE ELEMENTOS : {0}", miPila.Count);
         
 
 
 
 
   
         object elemento=0;
 
             //Desapilamos los elementos--> METODO Pop()
             //A la vez veremos el tipo de objeto que es cada elemento
 
             for (int i = 0; i < 3; i++) 
             {
 
                 elemento =(object) miPila.Pop();
                 //GetType: para saber de que tipo son los elementos almacenados en la pila.
              Console.WriteLine(elemento + " = "+elemento.GetType() );
                     
             }
           
             


             Console.WriteLine("Contenido de la pila: ");
            //Creacion de obj que enumera la piila GetEnumerator
             IEnumerator miEnum = miPila.GetEnumerator();

            // Recorrer sin sacar los elementos 
             while (miEnum.MoveNext())
             {
                 Console.WriteLine(miEnum.Current);
             }
             //Cargamos la pila con los 5 nombres        
             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine("Ingrese el " + (i + 1).ToString() + "° Nombre");
                 miPila.Push(Console.ReadLine());
             }

             //Quitamos y mostramos los nombres de la pila
             for (int j = 0; j < 5; j++)
                 Console.WriteLine(miPila.Pop());

            // Creacion del objeto
             Stack<string> numbers = new Stack<string>();
             numbers.Push("one");
             numbers.Push("two");
             numbers.Push("three");
             numbers.Push("four");
             numbers.Push("five");
            //Distribucion de contenido 
            foreach (string number in numbers)
             {
                 Console.WriteLine(number);
             }

             Console.WriteLine("\nSalto  '{0}'", numbers.Pop());
             Console.WriteLine("Siguiente en salir : {0}",
                 numbers.Peek());
             Console.WriteLine("Salto '{0}'", numbers.Pop());
             // Creando el  stack, usando ToArray 
             
             Stack<string> stack2 = new Stack<string>(numbers.ToArray());

             Console.WriteLine("\nlos primeros contenidos :");
             foreach (string number in stack2)
             {
                 Console.WriteLine(number);
             }

             // Creando el array 
             string[] array2 = new string[numbers.Count * 2];
             numbers.CopyTo(array2, numbers.Count);

             // Creando el segundo stack, usando el  constructor 
             Stack<string> stack3 = new Stack<string>(array2);

             Console.WriteLine("\nsegundo contenido:");
             foreach (string number in stack3)
             {
                 Console.WriteLine(number);
             }

             Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
                 stack2.Contains("four"));

             Console.WriteLine("\nstack2.Clear()");
             stack2.Clear();
             Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
             Console.ReadKey();
        }
    }
}
