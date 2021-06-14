using System;
using System.Collections.Generic;
namespace DPRN2_U3_EA_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string a = "a) Crear un nuevo universo";
            string b = "b) Mirar la lista de planetas";
            string c = "c) Elegir un planeta para modificar sus características, incluso su nombre";
            string d = "d) Destruir un planeta";
            string e = "e) Crear un nuevo planeta";
            string f = "f) Transferir planetas entre universos";
            DateTime now = DateTime.Now;
            //Lista del Creador del Universo
            List<Creador> listPlanets = new List<Creador>();
            //Lista del nuevo Planeta
            List<Creador> listPlanetsNew = new List<Creador>();
            //Lenamos lista
            listPlanets.Add(new Creador{name="Tatooine", rotation_period="23", orbital_period="304", diameter="10465", climate="arid", gravity="1 standard", terrain="desert", surface_water="1", population="200000", residents=10,films=5,url="http://swapi.dev/api/planets/1/", created=now, edited=now });
            listPlanets.Add(new Creador{name="Alderaan", rotation_period="24", orbital_period="364", diameter="12500", climate="temperate", gravity="1 standard", terrain="grasslands, mountains", surface_water="40", population="2000000000",residents=3,films=2,url="http://swapi.dev/api/planets/2/",created=now, edited=now });
            listPlanets.Add(new Creador{name="Yavin IV", rotation_period="24", orbital_period="4818", diameter="10200", climate="temperate", gravity="1 standard", terrain="jungle, rainforests", surface_water="8", population="1000",residents=0,films=1,url="http://swapi.dev/api/planets/3/",created=now, edited=now });
            listPlanets.Add(new Creador{name="Hoth", rotation_period="23", orbital_period="341", diameter="7200", climate="frozen", gravity="1.1 standard", terrain="tundra, ice caves, mountain ranges", surface_water="100", population="unknown",residents=0,films=1,url="http://swapi.dev/api/planets/3/",created=now, edited=now });
            listPlanets.Add(new Creador{name="Dagobah", rotation_period="23", orbital_period="549", diameter="8900", climate="murky", gravity="N/A", terrain="swamp, jungles", surface_water="8", population="unknown",residents=0,films=3,url="http://swapi.dev/api/planets/3/",created=now, edited=now });
            listPlanets.Add(new Creador{name="Bespin", rotation_period="12", orbital_period="5110", diameter="118000", climate="temperate", gravity="1.5 (surface), 1 standard (Cloud City)", terrain="gas giant", surface_water="0", population="6000000",residents=1,films=1,url="http://swapi.dev/api/planets/3/",created=now, edited=now });
            listPlanets.Add(new Creador{name="Endor", rotation_period="18", orbital_period="402", diameter="4900", climate="temperate", gravity="0.85 standard", terrain="forests, mountains, lakes", surface_water="8", population="30000000",residents=1,films=1,url="http://swapi.dev/api/planets/3/",created=now, edited=now });
            listPlanets.Add(new Creador{name="Naboo", rotation_period="26", orbital_period="312", diameter="12120", climate="temperate", gravity="1 standard", terrain="grassy hills, swamps, forests, mountains", surface_water="12", population="4500000000",residents=11,films=4,url="http://swapi.dev/api/planets/3/",created=now, edited=now });
            listPlanets.Add(new Creador{name="Coruscant", rotation_period="24", orbital_period="368", diameter="12240", climate="temperate", gravity="1 standard", terrain="cityscape, mountains", surface_water="unknown", population="1000000000000",residents=3,films=4,url="http://swapi.dev/api/planets/3/",created=now, edited=now });

            //Inicia menú
            System.Console.WriteLine("Bienvenido Creador del Universo. Indícanos, ¿qué deseas hacer?");
            System.Console.WriteLine(a+"\n"+b+"\n"+c+"\n"+d+"\n"+e+"\n"+f);
            var opcion = Console.ReadLine();
            int elegirOpcion = 0;
            if(opcion=="a" || opcion=="A")
            {
                elegirOpcion=1;
            }
            else if (opcion=="b" || opcion=="B")
            {
                elegirOpcion=2;
            }
            else if (opcion=="c" || opcion=="C")
            {
                elegirOpcion=3;
            }
            else if (opcion=="d" || opcion=="D")
            {
                elegirOpcion=4;
            }
            else if (opcion=="e" || opcion=="E")
            {
                elegirOpcion=5;
            }
            else if(opcion=="f" || opcion=="F")
            {
                elegirOpcion=6;
            }
            switch(elegirOpcion)
            {
                // 1 (a) Crear un nuevo universo
                case 1 when (elegirOpcion==1):
                    //Creación de una nueva lista. 
                    System.Console.WriteLine("Creador del universo. Haz creado un nuevo universo.");
                    //Se utiliza la lista listPlanetsNew.
                break;
                // 2 (b) Mirar la lista de planetas
                case 2 when(elegirOpcion==2):
                    //Mostrar contenido de la lista
                    foreach (Creador p in listPlanets)
                        {
                            Console.Write("Nombre: "+p.name+" Periodo de rotación: "+p.rotation_period + " Periodo orbital: "+p.orbital_period);
                            Console.Write(" Diámetro: " +p.diameter + " Cima: " + p.climate+ " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                            Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population+" Residentes: "+p.residents+ " Films:"+ p.films);
                            Console.Write(" Url: "+p.url+ " Creado: " + p.created+ " Editado: "+ p.edited);
                            System.Console.WriteLine("\n");
                        }
                        Console.ReadLine();        
                    
                break;
                // 3 (c) Elegir un planeta para modificar sus características, incluso su nombre
                case 3 when (elegirOpcion==3):
                //Se usa método para editar un planeta.
                //Console.WriteLine("Actualizamos el primer elemento");
                // int indice = 0;
                // numeros.Insert(indice, 3);
                // numeros.RemoveAt(indice + 1);
                break;
                // 4 (d) Destruir un planeta
                case 4 when (elegirOpcion==4):  
                //Se usa método para remover.remove()
                //listOfNames.Remove("Joe Doe");
                System.Console.WriteLine("Por favor ingresa el nombre del planeta que deseas destruir: ");

                break;
                // 5 (e) Crear un nuevo planeta
                case 5 when (elegirOpcion==5):
                //// Insert at the top (index 0)
                // listOfNames.Insert(0, "John Doe");
                // // Insert in the middle (index 1)
                // listOfNames.Insert(1, 2"Jane Doe");
                System.Console.WriteLine("Por favor ingresa el nombre del planeta: ");

                break;
                // 6 (f) Transferir planetas entre universos
                case 6 when (elegirOpcion==6):
                //Tomar valores delplaneta e insertarlos en la nueva lista.
                break;
                default:
                System.Console.WriteLine("Haz elegido una opción no válida");
                break;
            }
        }
    }
}