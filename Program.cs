using System;
using System.Collections.Generic;
using System.Linq;
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
            string nombreUp = "Nombre";
            string rotationUp = "Periodo de rotación";
            string orbitalUp="Periodo orbital";
            string diameter = "Diámetro";
            string climate = "Clima";
            string gravity = "Gravedad";
            string terrain = "Terreno";
            string surface = "Superficie del agua";
            string population = "Población";
            string url = "URL";
            string residents = "Residentes";
            string films = "Films";
            string editar = "¿Quiéres editar ";
            string interrogacion= "?";
            string el = " el ";
            string la = " la ";
            string los = " los ";
            string edicionAtributo = "1.- Sí\n2.-No";

            DateTime June14 = DateTime.Today.AddDays(-1);
            DateTime now = DateTime.Now;
            //Lista del Creador del Universo
            List<Creador> listPlanets = new List<Creador>();
            //Lista del nuevo Planeta
            List<Creador> listPlanetsNew = new List<Creador>();
            //Lenamos lista
            listPlanets.Add(new Creador{name="Tatooine", rotation_period="23", orbital_period="304", diameter="10465", climate="arid", gravity="1 standard", terrain="desert", surface_water="1", population="200000", residents=10,films=5,url="http://swapi.dev/api/planets/1/", created=June14, edited=now, id=1 });
            listPlanets.Add(new Creador{name="Alderaan", rotation_period="24", orbital_period="364", diameter="12500", climate="temperate", gravity="1 standard", terrain="grasslands, mountains", surface_water="40", population="2000000000",residents=3,films=2,url="http://swapi.dev/api/planets/2/",created=June14, edited=now,id=2 });
            listPlanets.Add(new Creador{name="Yavin IV", rotation_period="24", orbital_period="4818", diameter="10200", climate="temperate", gravity="1 standard", terrain="jungle, rainforests", surface_water="8", population="1000",residents=0,films=1,url="http://swapi.dev/api/planets/3/",created=June14, edited=now, id=3 });
            listPlanets.Add(new Creador{name="Hoth", rotation_period="23", orbital_period="341", diameter="7200", climate="frozen", gravity="1.1 standard", terrain="tundra, ice caves, mountain ranges", surface_water="100", population="unknown",residents=0,films=1,url="http://swapi.dev/api/planets/3/",created=June14, edited=now, id=4 });
            listPlanets.Add(new Creador{name="Dagobah", rotation_period="23", orbital_period="549", diameter="8900", climate="murky", gravity="N/A", terrain="swamp, jungles", surface_water="8", population="unknown",residents=0,films=3,url="http://swapi.dev/api/planets/3/",created=June14, edited=now, id=5 });
            listPlanets.Add(new Creador{name="Bespin", rotation_period="12", orbital_period="5110", diameter="118000", climate="temperate", gravity="1.5 (surface), 1 standard (Cloud City)", terrain="gas giant", surface_water="0", population="6000000",residents=1,films=1,url="http://swapi.dev/api/planets/3/",created=June14, edited=now, id=6 });
            listPlanets.Add(new Creador{name="Endor", rotation_period="18", orbital_period="402", diameter="4900", climate="temperate", gravity="0.85 standard", terrain="forests, mountains, lakes", surface_water="8", population="30000000",residents=1,films=1,url="http://swapi.dev/api/planets/3/",created=June14, edited=now, id=7 });
            listPlanets.Add(new Creador{name="Naboo", rotation_period="26", orbital_period="312", diameter="12120", climate="temperate", gravity="1 standard", terrain="grassy hills, swamps, forests, mountains", surface_water="12", population="4500000000",residents=11,films=4,url="http://swapi.dev/api/planets/3/",created=June14, edited=now, id=8 });
            listPlanets.Add(new Creador{name="Coruscant", rotation_period="24", orbital_period="368", diameter="12240", climate="temperate", gravity="1 standard", terrain="cityscape, mountains", surface_water="unknown", population="1000000000000",residents=3,films=4,url="http://swapi.dev/api/planets/3/",created=June14, edited=now, id=9 });

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
                    // do{
                    //     System.Console.WriteLine("¿Qué deseas hacer ahora, Creador del Universo");
                    //     System.Console.WriteLine(b+"\n"+c+"\n"+d+"\n"+e+"\n"+f);
                    //     var opcionNuevoUniverso = Console.ReadLine();
                    //     int elegirOpcionNuevoUniverso = 0;
                    //     if (opcionNuevoUniverso=="b" || opcionNuevoUniverso=="B")
                    //     {
                    //         elegirOpcionNuevoUniverso=2;
                    //     }
                    //     else if (opcionNuevoUniverso=="c" || opcionNuevoUniverso=="C")
                    //     {
                    //         elegirOpcionNuevoUniverso=3;
                    //     }
                    //     else if (opcionNuevoUniverso=="d" || opcionNuevoUniverso=="D")
                    //     {
                    //         elegirOpcionNuevoUniverso=4;
                    //     }
                    //     else if (opcionNuevoUniverso=="e" || opcionNuevoUniverso=="E")
                    //     {
                    //         elegirOpcionNuevoUniverso=5;
                    //     }
                    //     else if(opcionNuevoUniverso=="f" || opcionNuevoUniverso=="F")
                    //     {
                    //         elegirOpcionNuevoUniverso=6;
                    //     }
                    //     //
                    //     System.Console.WriteLine("¿Deseas hacer otra acción, Creador del Universo");
                    //     System.Console.WriteLine("1.- Sí \n2.- No");
                    //     var otraAccion = Console.ReadLine();
                    //     int accion = int.Parse(otraAccion);
                    //     if(accion==1)
                    //     {
                    //         elegirOpcion=1;
                    //     }
                    //     else if(accion==2)
                    //     {
                    //         elegirOpcion=0;
                    //     }
                    // }while(elegirOpcion>=1);
                System.Console.WriteLine("Gracias, Creador del Universo. ¡Adiós!");
                break;
                // 2 (b) Mirar la lista de planetas
                case 2 when(elegirOpcion==2):
                    //Mostrar contenido de la lista
                    foreach (Creador p in listPlanets)
                        {
                            Console.Write(p.id+".- "+p.name+" Periodo de rotación: "+p.rotation_period + " Periodo orbital: "+p.orbital_period);
                            Console.Write(" Diámetro: " +p.diameter + " Clima: " + p.climate+ " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                            Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population+" Residentes: "+p.residents+ " Films:"+ p.films);
                            Console.Write(" Url: "+p.url+ " Creado: " + p.created+ " Editado: "+ p.edited);
                            System.Console.WriteLine("\n");
                        }
                        Console.ReadLine();        
                    
                break;
                // 3 (c) Elegir un planeta para modificar sus características, incluso su nombre
                case 3 when (elegirOpcion==3):
                    //Se usa método para editar un planeta.
                    // int indice = 0;
                    // numeros.Insert(indice, 3);
                    // numeros.RemoveAt(indice + 1);
                    Console.WriteLine("Esta es la lista de los planetas. Por favor indícanos el número del planeta del cual deseas modificar sus características.");
                    //Lista de planetas con id y nombre
                    foreach(Creador p in listPlanets)
                    {
                        Console.Write(" "+p.id+".- "+p.name+ "\n");
                    }
                    // System.Console.WriteLine("¿Deseas hacer otra acción, Creador del Universo");
                    // System.Console.WriteLine("1.- Sí \n2.- No");
                    var idPlaneta = Console.ReadLine();
                    int planetaUpdate = int.Parse(idPlaneta);
                    if(planetaUpdate>=1)
                    {
                        System.Console.WriteLine("A continuación enlistaremos las características de cada planeta.");
                        //Editar Nombre
                        System.Console.WriteLine(editar+el+nombreUp+interrogacion);
                        System.Console.WriteLine(edicionAtributo);
                        var nombre_Up = Console.ReadLine();
                        int nameUpdate = int.Parse(nombre_Up);
                        if(nameUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa el nombre por el que será actualizado: ");
                            var nombre_In = Console.ReadLine();
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.name = nombre_In;found.edited = now; }
                        }
                        else
                        {
                            System.Console.WriteLine("No se editará el nombre");
                        }
                        //Editar Rotación
                        System.Console.WriteLine(editar+el+rotationUp+interrogacion);
                        System.Console.WriteLine(edicionAtributo);
                        var rotation_Up = Console.ReadLine();
                        int rotationUpdate = int.Parse(rotation_Up);
                        if(rotationUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa el periodo de rotación por el que será actualizado: ");
                            var rotacion_In = Console.ReadLine();
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.rotation_period = rotacion_In;found.edited = now; }
                        }
                        else
                        {
                            System.Console.WriteLine("No se editará el periodo de rotación");
                        }
                        //Editar orbital
                        System.Console.WriteLine(editar+el+orbitalUp+interrogacion);
                        System.Console.WriteLine(edicionAtributo);  
                        var orbital_Up = Console.ReadLine();
                        int orbitalUpdate = int.Parse(orbital_Up);

                        if(orbitalUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa el periodo orbital por el que será actualizado: ");
                            var orbital_In = Console.ReadLine();
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.orbital_period = orbital_In; found.edited = now;}
                        }
                        else
                        {
                            System.Console.WriteLine("No se editará el periodo de rotación");
                        }
                        //Editar diámetro
                        System.Console.WriteLine(editar+el+diameter+interrogacion);
                        System.Console.WriteLine(edicionAtributo);   
                        var diameter_Up = Console.ReadLine();
                        int diameterUpdate = int.Parse(diameter_Up);
                        if(diameterUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa el diámetro por el que será actualizado: ");
                            var diameter_In = Console.ReadLine();
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.diameter = diameter_In;found.edited = now; }
                        }
                        else
                        {
                            System.Console.WriteLine("No se editará el diámetro");
                        }
                        //Editar clima
                        System.Console.WriteLine(editar+el+climate+interrogacion);
                        System.Console.WriteLine(edicionAtributo);   
                        var climate_Up = Console.ReadLine();
                        int climateUpdate = int.Parse(climate_Up);
                        if(climateUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa el clima por el que será actualizado: ");
                            var climate_In = Console.ReadLine();
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.climate = climate_In;found.edited = now; }
                        }
                        else
                        {
                            System.Console.WriteLine("No se editará el diámetro");
                        }
                        //Editar gravedad
                        System.Console.WriteLine(editar+la+gravity+interrogacion);                        
                        System.Console.WriteLine(edicionAtributo);
                        var gravity_Up = Console.ReadLine();
                        int gravityUpdate = int.Parse(gravity_Up);
                        if(gravityUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa la gravedad por la que será actualizada: ");
                            var gravity_In = Console.ReadLine();
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.gravity = gravity_In;found.edited = now; }
                        }
                        else
                        {
                            System.Console.WriteLine("No se editará la gravedad");
                        }
                        //Editar terreno
                        System.Console.WriteLine(editar+el+terrain+interrogacion);
                        System.Console.WriteLine(edicionAtributo);   
                        var terrain_Up = Console.ReadLine();
                        int terrainUpdate = int.Parse(terrain_Up);
                        if(terrainUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa el terreno por el que será actualizado: ");
                            var terrain_In = Console.ReadLine();
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.terrain = terrain_In;found.edited = now; }
                        }
                        else
                        {
                            System.Console.WriteLine("No se editará el terreno");
                        }
                        //Editar superficie de agua
                        System.Console.WriteLine(editar+la+surface+interrogacion);
                        System.Console.WriteLine(edicionAtributo);  
                        var surface_Up = Console.ReadLine();
                        int surfaceUpdate = int.Parse(surface_Up);                          
                        if(surfaceUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa la superficie de agua por la que será actualizada: ");
                            var surface_In = Console.ReadLine();
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.surface_water = surface_In; found.edited = now;}
                        }
                        else
                        {
                            System.Console.WriteLine("No se editará la superficie de agua");
                        }
                        //Editar población
                        System.Console.WriteLine(editar+la+population+interrogacion);
                        System.Console.WriteLine(edicionAtributo); 
                        var population_Up = Console.ReadLine();
                        int populationUpdate = int.Parse(population_Up); 
                        if(populationUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa la población por la que será actualizada: ");
                            var population_In = Console.ReadLine();
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.population = population_In; found.edited = now;}
                        }
                        else
                        {
                            System.Console.WriteLine("No se editará la población");
                        }
                        //Editar URL
                        System.Console.WriteLine(editar+la+url+interrogacion);
                        System.Console.WriteLine(edicionAtributo);   
                        var url_Up = Console.ReadLine();
                        int urlUpdate = int.Parse(url_Up); 
                        if(urlUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa la URL por la que será actualizada: ");
                            var url_In = Console.ReadLine();
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.url = url_In; found.edited = now;}
                        }
                        else
                        {
                            System.Console.WriteLine("No se editará la URL");
                        }
                        //Editar residentes
                        System.Console.WriteLine(editar+los+residents+interrogacion);
                        System.Console.WriteLine(edicionAtributo);    
                        var residents_Up = Console.ReadLine();
                        int residentsUpdate = int.Parse(residents_Up); 
                        if(residentsUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa el número de residentes por los que será actualizado: ");
                            var residents_In = Console.ReadLine();
                            int residentes_In = int.Parse(residents_In);
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.residents = residentes_In; found.edited = now;}
                        }
                        else
                        {
                            System.Console.WriteLine("No se editarán los residentes");
                        }
                        //Editar Films
                        System.Console.WriteLine(editar+los+films+interrogacion);
                        System.Console.WriteLine(edicionAtributo);
                        var films_Up = Console.ReadLine();
                        int filmsUpdate = int.Parse(films_Up); 
                        if(filmsUpdate==1)
                        {
                            System.Console.WriteLine("Ingresa el número de films por los que será actualizado: ");
                            var films_In = Console.ReadLine();
                            int filmes_In = int.Parse(films_In);
                            var found = listPlanets.FirstOrDefault(p => p.id == planetaUpdate);
                            if (found != null) { found.films = filmes_In; found.edited = now; }
                        }
                        else
                        {
                            System.Console.WriteLine("No se editarán los residentes");
                        }

                        System.Console.WriteLine("Valida tus combios en el universo:");
                        // foreach(Creador p in listPlanets)
                        // {
                        //     Console.WriteLine(" "+p.id+".- "+p.name+" \n");
                        // }
                        foreach (Creador p in listPlanets)
                        {
                            Console.Write(p.id+".- "+p.name+" Periodo de rotación: "+p.rotation_period + " Periodo orbital: "+p.orbital_period);
                            Console.Write(" Diámetro: " +p.diameter + " Clima: " + p.climate+ " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                            Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population+" Residentes: "+p.residents+ " Films:"+ p.films);
                            Console.Write(" Url: "+p.url+ " Creado: " + p.created+ " Editado: "+ p.edited);
                            System.Console.WriteLine("\n");
                        }
                        Console.ReadLine();
                    }
                break;
                // 4 (d) Destruir un planeta
                case 4 when (elegirOpcion==4):  
                    //Se usa método para remover.remove()
                    //listOfNames.Remove("Joe Doe");
                    System.Console.WriteLine("Por favor ingresa el número del planeta que deseas destruir: ");
                    //Lista de planetas con id y nombre
                    foreach(Creador p in listPlanets)
                    {
                        Console.Write(" "+p.id+".- "+p.name+ "\n");
                    }
                    var planeta_In = Console.ReadLine();
                    int planetaARemover = int.Parse(planeta_In);
                    var foundPlanet = listPlanets.FirstOrDefault(p => p.id == planetaARemover);
                    listPlanets.Remove(foundPlanet);
                    System.Console.WriteLine("Valida tus combios en el universo:");
                    foreach (Creador p in listPlanets)
                        {
                            Console.Write(p.id+".- "+p.name+" Periodo de rotación: "+p.rotation_period + " Periodo orbital: "+p.orbital_period);
                            Console.Write(" Diámetro: " +p.diameter + " Clima: " + p.climate+ " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                            Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population+" Residentes: "+p.residents+ " Films:"+ p.films);
                            Console.Write(" Url: "+p.url+ " Creado: " + p.created+ " Editado: "+ p.edited);
                            System.Console.WriteLine("\n");
                        }
                        Console.ReadLine();
                break;
                // 5 (e) Crear un nuevo planeta
                case 5 when (elegirOpcion==5):
                    //// Insert at the top (index 0)
                    // listOfNames.Insert(0, "John Doe");
                    // // Insert in the middle (index 1)
                    // listOfNames.Insert(1, 2"Jane Doe");
                    System.Console.WriteLine("Por favor ingresa el nombre del planeta: ");
                    var nameNewPlanet = Console.ReadLine();
                    System.Console.WriteLine("Por favor ingresa el periodo de rotación: ");
                    var rotationNewPlanet = Console.ReadLine();
                    System.Console.WriteLine("Por favor ingresa el periodo orbital: ");
                    var orbitalNewPlanet = Console.ReadLine();
                    System.Console.WriteLine("Por favor ingresa el diámetro: ");
                    var dimaeterNewPlanet = Console.ReadLine();
                    System.Console.WriteLine("Por favor ingresa el clima: ");
                    var climateNewPlanet = Console.ReadLine();
                    System.Console.WriteLine("Por favor ingresa la gravedad: ");
                    var gravityNewPlanet = Console.ReadLine();
                    System.Console.WriteLine("Por favor ingresa el terreno: ");
                    var terrainNewPlanet = Console.ReadLine();
                    System.Console.WriteLine("Por favor ingresa la superficie del agua: ");
                    var surfaceNewPlanet = Console.ReadLine();
                    System.Console.WriteLine("Por favor ingresa la población: ");
                    var populationNewPlanet = Console.ReadLine();
                    System.Console.WriteLine("Por favor ingresa la URL: ");
                    var urlNewPlanet = Console.ReadLine();
                    System.Console.WriteLine("Por favor ingresa los residentes: ");
                    var residentsNewPlanet = Console.ReadLine();
                    int residentesNewPlanet = int.Parse(residentsNewPlanet);
                    System.Console.WriteLine("Por favor ingresa los films: ");
                    var filmsNewPlanet = Console.ReadLine();
                    int filmesNewPlanet = int.Parse(filmsNewPlanet);
                    listPlanets.Insert(0, new Creador() {name=nameNewPlanet, rotation_period=rotationNewPlanet, orbital_period=orbitalNewPlanet, 
                    diameter=dimaeterNewPlanet, climate=climateNewPlanet, gravity=gravityNewPlanet, terrain=terrainNewPlanet, 
                    surface_water=surfaceNewPlanet, population=populationNewPlanet, created=now, edited=now, url=urlNewPlanet,
                    residents=residentesNewPlanet, films=filmesNewPlanet });
                    
                    //Ver lista de planetas
                    System.Console.WriteLine("El Universo ahora está conformado por estos planetas: ");
                    foreach (Creador p in listPlanets)
                        {
                            Console.Write(p.id+".- "+p.name+" Periodo de rotación: "+p.rotation_period + " Periodo orbital: "+p.orbital_period);
                            Console.Write(" Diámetro: " +p.diameter + " Clima: " + p.climate+ " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                            Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population+" Residentes: "+p.residents+ " Films:"+ p.films);
                            Console.Write(" Url: "+p.url+ " Creado: " + p.created+ " Editado: "+ p.edited);
                            System.Console.WriteLine("\n");
                        }
                        Console.ReadLine();
                break;
                // 6 (f) Transferir planetas entre universos
                case 6 when (elegirOpcion==6):
                    //Tomar valores del planeta e insertarlos en la nueva lista.1
                    System.Console.WriteLine("Realizaremos la transferencia entre planetas.\n");
                    //Mostrar contenido de la lista
                    foreach (Creador p in listPlanets)
                        {
                            Console.Write(p.id+".- "+p.name+" Periodo de rotación: "+p.rotation_period + " Periodo orbital: "+p.orbital_period);
                            Console.Write(" Diámetro: " +p.diameter + " Clima: " + p.climate+ " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                            Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population+" Residentes: "+p.residents+ " Films:"+ p.films);
                            Console.Write(" Url: "+p.url+ " Creado: " + p.created+ " Editado: "+ p.edited);
                            System.Console.WriteLine("\n");
                        }
                    System.Console.WriteLine("Elige el planeta que deseas transferir:");
                    var planeta_Tr = Console.ReadLine();
                    int planetaATransferir = int.Parse(planeta_Tr);
                    System.Console.WriteLine("Haz elegido {0}", planetaATransferir);

                    var foundPlanetToTransfer = listPlanets.FirstOrDefault(p => p.id == planetaATransferir);
                    var nombreTransferencia = foundPlanetToTransfer.name;
                    var rotacionTransferencia=foundPlanetToTransfer.rotation_period;
                    var orbitaTransferencia=foundPlanetToTransfer.orbital_period;
                    var diametroTransferencia = foundPlanetToTransfer.diameter;
                    var climaTransferencia = foundPlanetToTransfer.climate;
                    var gravedadTransferencia=foundPlanetToTransfer.gravity;
                    var terrenoTransferencia=foundPlanetToTransfer.terrain;
                    var superficieTransferencia=foundPlanetToTransfer.surface_water;
                    var poblacionTransferencia = foundPlanetToTransfer.population;
                    var urlTransferencia = foundPlanetToTransfer.url;
                    int residentesTransferencia = foundPlanetToTransfer.residents;
                    int filmsTransferencia = foundPlanetToTransfer.films;
                    int idTransferencias = foundPlanetToTransfer.id;

                    listPlanetsNew.Insert(0, new Creador() {name=nombreTransferencia, rotation_period=rotacionTransferencia, orbital_period=orbitaTransferencia, 
                    diameter=diametroTransferencia, climate=climaTransferencia, gravity=gravedadTransferencia, terrain=terrenoTransferencia, 
                    surface_water=superficieTransferencia, population=poblacionTransferencia, created=now, edited=now, url=urlTransferencia,
                    residents=residentesTransferencia, films=filmsTransferencia, id=idTransferencias });
                    System.Console.WriteLine("Así se ve el planeta en el nuevo Universo: ");
                    foreach (Creador p in listPlanetsNew)
                        {
                            Console.Write(p.id+".- "+p.name+" Periodo de rotación: "+p.rotation_period + " Periodo orbital: "+p.orbital_period);
                            Console.Write(" Diámetro: " +p.diameter + " Clima: " + p.climate+ " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                            Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population+" Residentes: "+p.residents+ " Films:"+ p.films);
                            Console.Write(" Url: "+p.url+ " Creado: " + p.created+ " Editado: "+ p.edited);
                            System.Console.WriteLine("\n");
                        }
                        Console.ReadLine();


                break;
                default:
                System.Console.WriteLine("Haz elegido una opción no válida");
                break;
            }
        }
    }
}