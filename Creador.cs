using System;
using System.Collections.Generic;

class Creador:Planeta
{
    public Creador(string name, string rotation_period, string orbital_period, string diameter, string climate, string gravity, string terrain, string surface_water, string population, /*List<string> residents, List<string> films,*/DateTime created, DateTime edited, string url):base(name, rotation_period, orbital_period, diameter, climate, gravity, terrain, surface_water, population, /*residents, films,*/ created, edited, url){}

    public override string crearNuevoUniverso()
    {
        throw new NotImplementedException();
    }
    public override string mirarListaDePlanetas()
    {
        throw new NotImplementedException();
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