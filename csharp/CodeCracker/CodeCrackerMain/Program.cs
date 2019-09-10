using System;
using System.Collections.Generic;

namespace CodeCrackerMain
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PRUEBA DE LISTA!
            Code code = new Code();
            Console.WriteLine("Hello World!");
            List<Code> lista = code.tableCodeLetters();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(i + " "+lista[i].letterSimple + " "+ lista[i].letterEncripted);
            }
            //Console.WriteLine(lista);       
            
        }
    }
}
