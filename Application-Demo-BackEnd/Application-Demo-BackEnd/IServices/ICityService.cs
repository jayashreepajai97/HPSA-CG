using Application_Demo_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_Demo_BackEnd.IServices
{
    public interface ICityService
    {
        IEnumerable<City> GetCities();
        City AddCity(City city);

        City UpdateCity(City city);

        City DeleteCity(int id);

        City GetCityById(int id);


    }
}


