using System;
abstract class Planet{
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
    protected string url;

   //Método constructor Planeta con parámetros.
    public Planet(string nombrePlaneta, string periodoRotacion, string PeriodoOrbital, string diametro, string clima, string gravedad,
                   string terreno, string superficieAgua, string poblacion, string link)
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
        url=link;
    }

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

    //URL
    public string DatoURL{
        get{
            return url;
        }
        set{
            url=value;
        }
    }

    public abstract string crearNuevoUniverso();
    public abstract string mirarListaDePlanetas();
    public abstract string elegirPlaneta();
    public abstract string destruirPlaneta();
    public abstract string crearNuevoPlaneta();
    public abstract string transferirPlaneta();

}