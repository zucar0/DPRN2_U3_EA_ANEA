using System;
using System.Collections.Generic;
class Creator:Planet
{
    // public int Id { get; set; }
    // public string Nombre { get; set; }
    // public string Telefono { get; set; }
    // public int Edad { get; set; }

    // List<Creator> listPlanets = new List<Creator>();
    
    public Creator(string name, string rotation_period, string orbital_period, string diameter, string climate, string gravity, string terrain, string surface_water, string population, string url):base(name, rotation_period, orbital_period, diameter, climate, gravity, terrain, surface_water, population, url){}



    public override string crearNuevoUniverso()
    {
        throw new NotImplementedException();
    }
    public override string mirarListaDePlanetas()
    {
        try
        {

            
        }
        catch(Exception ex)
        {
            throw new NotImplementedException();
            System.Console.WriteLine(ex);
        }
        return base.name;
    }
    public override string elegirPlaneta()
    {
        throw new NotImplementedException();
    }
    public override string destruirPlaneta()
    {
        throw new NotImplementedException();
    }
    public override string crearNuevoPlaneta()
    {

        throw new NotImplementedException();

    }
    public override string transferirPlaneta()
    {
        throw new NotImplementedException();
    }

}