using System;
using System.Collections.Generic;
using System.Globalization;
namespace DPRN2_U3_EA_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Creator> listPersona = new List<Creator>();
            //Lenamos la lista
            listPersona.Add(new Creator { Id = 1, Nombre = "Juan", Telefono = "222", Edad = 20 });
            listPersona.Add(new Creator { Id = 2, Nombre = "Marcos", Telefono = "555", Edad = 40 });
            listPersona.Add(new Creator { Id = 3, Nombre = "Pablo", Telefono = "777", Edad = 28 });

            //Mostrar contenido de la lista
            foreach (Creator p in listPersona)
            {
                Console.WriteLine(p.Nombre+" Edad: "+ p.Edad +"\n");
            }
            Console.ReadLine();
        }            
    }
}
                
                