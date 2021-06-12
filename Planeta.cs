using System.Collections.Generic;
using System.Globalization;
using System;
abstract class Planeta{
    //Datos miembro.
    protected string name;
    protected string rotation_period;
    protected string orbital_period;
    protected string diameter;
    protected string climate;
    protected string gravity;
    protected string terrain;
    protected string surface_water;
    protected string population;
    // protected List<string> residents;
    // protected List<string> films;
    protected DateTime created;
    protected DateTime edited;
    protected string url;

    //Método constructor Planeta con parámetros.
    public Planeta(string nombrePlaneta, string periodoRotacion, string PeriodoOrbital, string diametro, string clima, string gravedad,
                   string terreno, string superficieAgua, string poblacion, /*List<string> residentes, List<string> grabaciones,*/ 
                   DateTime creacion, DateTime edicion, string link)
    {
        name=nombrePlaneta;
        rotation_period=periodoRotacion;
        orbital_period=PeriodoOrbital;
        diameter=diametro;
        climate=clima;
        gravity=gravedad;
        terrain=terreno;
        surface_water=superficieAgua;
        population=poblacion;
        // residents=residentes;
        // films=grabaciones;
        created=creacion;
        edited=edicion;
        url=link;
    }

    public abstract string crearNuevoUniverso();
    public abstract string mirarListaDePlanetas();
    public abstract string elegirPlaneta();
    public abstract string destruirPlaneta();
    public abstract string crearNuevoPlaneta();
    public abstract string transferirPlaneta();

    //Interfaz para los planetas
    //Nombre
    public string DatoPlaneta{
        get{
            return name;
        }set{
            name = value;
        }    
    }
    //Rotación
    public string DatoRotacion{
        get{
            return rotation_period;
        }
        set{
            rotation_period=value;
        }
    }
    //Periodo Orbital
    public string DatoPeriodoOrbital{
        get{
            return orbital_period;
        }
        set{
            orbital_period=value;
        }
    }
    //Diámetro
    public string DatoDiametro{
        get{
            return diameter;
        }
        set{
            diameter=value;
        }
    }
    //Clima
    public string DatoClima{
        get{
            return climate;
        }
        set{
            climate=value;
        }
    }
    
    //Gravedad
    public string DatoGravedad{
        get{
            return gravity;
        }
        set{
            gravity=value;
        }
    }
    //Terreno
    public string DatoTerreno{
        get{
            return terrain;
        }
        set{
            terrain=value;
        }
    }
    //Agua
    public string DatoAgua{
        get{
            return surface_water;
        }
        set{
            surface_water=value;
        }
    }
    //Poblacion
    public string DatoPoblacion{
        get{
            return population;
        }
        set{
            population=value;
        }
    }
    // //Residentes
    // public List<string> DatoResidentes{
    //     get{
    //         return residents;
    //     }
    //     set{
    //         residents=value;
    //     }
    // }
    // //Films
    // public List<string> DatoFilms{
    //     get{
    //         return films;
    //     }
    //     set{
    //         films=value;
    //     }
    // }
    //Creado
    public DateTime DatoCreado{
        get{
            return created;
        }
        set{
            created=value;
        }
    }
    //Editado
    public DateTime DatoEditado{
        get{
            return edited;
        }
        set{
            edited=value;
        }
    }
    //URL
    public string DatoURL{
        get{
            return url;
        }
        set{
            url=value;
        }
    }
    /*
    public string name { get; set; }
        public string rotation_period { get; set; }
        public string orbital_period { get; set; }
        public string diameter { get; set; }
        public string climate { get; set; }
        public string gravity { get; set; }
        public string terrain { get; set; }
        public string surface_water { get; set; }
        public string population { get; set; }
        public List<string> residents { get; set; }
        public List<string> films { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
    */
     //Destructor
    ~Planeta() {
        name=""; 
        rotation_period="";
        orbital_period="";
        diameter="";
        climate="";
        gravity="";
        terrain="";
        surface_water="";
        population="";
        // List<string> residents = new List<string>();
        // List<string> films = new List<string>();
        // DateTime? created = null;
        // DateTime? edited = null;
        url="";
        // Console.Write("Este es el destructor ejecutándose para destruir el objeto de la clase Factura");
    } 

    string[,] planetas={
        {"Tatooine", "23", "304", "10465", "arid", "1 standard", "desert",  "1", "200000", "2014-12-09T13:50:49.641000Z", "2014-12-20T20:58:18.411000Z", "http://swapi.dev/api/planets/1/" }
    };
}