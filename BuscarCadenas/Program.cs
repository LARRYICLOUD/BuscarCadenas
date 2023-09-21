using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES RECONOCIDO");
            Console.WriteLine("#JAJAJA_FENOMENAL");

            //"Contains",  "StarWith",  "EndWith",  "IndexOff",  y "LastIndexOff" nos sirve para buscar un texto en concreto

            Console.WriteLine("MI MUNDO LUIS ENRIQUE");

            string parrafo = "-Mío yo tengo un mundo mío De grandes desafíos De eterna evolución Raro, inmensamente humano De paz y sobresaltos Extraño pero mío Mi mundo es complicado Difícil de explorarlo Difícil de vivir Pero es mío es el mundo mío Lleno de triunfos y fracasos Virtudes y pecados Y en el no cabes tu";

            Console.WriteLine("EXTRACTO DE LA CANCION MI MUNDO BY LUIS ENRIQUE: \n\n{0}\n", parrafo);

            Console.Write("\nIngresa el texto a buscar: ");
            string buscarTexto = Console.ReadLine();

            if (parrafo.Contains(buscarTexto))
            {
                Console.WriteLine("El texto ({0}) fue encontrado", buscarTexto);

            }
            else
            {
                Console.WriteLine("No se encontro el texto ({0}) en la cadena", buscarTexto);
            }




        }
    }
}
