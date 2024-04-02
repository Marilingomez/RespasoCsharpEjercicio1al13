using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCsharpRepaso
{
    internal class Ejercicios
    {
        public void ejercicio1()

        {
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadKey();
        }

        public void ejercicio2()
        {

            Console.WriteLine("Ingrese un texto:");
            string texto = Console.ReadLine();
            Console.WriteLine("Usted ingresó: " + texto);

        }

        public void ejercicio3()
        {
            Console.WriteLine("Ingrese frases. Para finalizar, escriba 'fin':");
            string frase = "";
            while (frase.ToLower() != "fin")
            {
                frase = Console.ReadLine();
                if (frase.ToLower() != "fin")
                {
                    Console.WriteLine("Usted ingresó: " + frase);
                }
            }
        }
        public void ejercicio4()
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);

        }

        public void ejercicio5()
        {
            Console.WriteLine("Ingrese una frase:");
            string frase5 = Console.ReadLine();
            if (frase5.Contains("fin"))
            {
                Console.WriteLine("La frase contiene la palabra 'fin'.");
            }
            else
            {
                Console.WriteLine("La frase no contiene la palabra 'fin'.");
            }
        }

        public void ejercicio6()
        {

            Console.WriteLine("Ingrese un texto:");
            string texto = Console.ReadLine();
            Console.WriteLine("Texto en mayúsculas: " + texto.ToUpper());
        }

        public void ejercicio7()
        {
            Console.WriteLine("Ingrese un texto:");
            string texto = Console.ReadLine();
            Console.WriteLine("Texto en minúsculas: " + texto.ToLower());

        }

        public void ejercicio8()
        {

            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();
            frase = frase.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u");
            Console.WriteLine("Frase sin vocales acentuadas: " + frase);
        }

        public void ejercicio9()
        {
            Console.WriteLine("Ingrese la primera frase:");
            string frase = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda frase:");
            string frase2 = Console.ReadLine();
            if (frase == frase2)
            {
                Console.WriteLine("Las frases son iguales");
            }
            else
            {
                Console.WriteLine("Las frases no son iguales");
            }
        }

        public void ejercicio10()
        {

            Console.WriteLine("Ingrese la primera frase:");
            string frase1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda frase:");
            string frase2 = Console.ReadLine();
            if (frase1.Length == frase2.Length)
            {
                Console.WriteLine("Las frases tienen la misma longitud.");
            }
            else
            {
                Console.WriteLine("Las frases tienen diferente longitud.");
            }

        }
        public void ejercicio11()
        {
            Console.WriteLine("Ingrese la primera frase:");
            string frasea = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda frase:");
            string fraseb = Console.ReadLine();
            if (frasea == fraseb)
            {
                Console.WriteLine("Las frases son iguales");
            }
            else
            {
                Console.WriteLine("Las frases no son iguales");
            }
        }
        public void ejercicio12()
        {
            Console.WriteLine("Ingrese una frase:");
            string frasec = Console.ReadLine();
            int cantidadPalabras = frasec.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Cantidad de palabras en la frase: " + cantidadPalabras);

        }
        public void ejercicio13()
        {
            Console.WriteLine("Ingrese una frase:");
            string frased = Console.ReadLine();
            int cantidadPalabras2 = frased.Split(new char[] { ' ', '.', ',', ';' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Cantidad de palabras en la frase: " + cantidadPalabras2);
        }
    }
}
