using Application_Demo_BackEnd.IServices;
using Application_Demo_BackEnd.Models;
using Application_Demo_BackEnd.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_Demo_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {

        private readonly ICityService cityService;

        public CityController(ICityService city)
        {
            cityService = city;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/City/GetCities")]
        public IEnumerable<City> GetCities()
        {
            return cityService.GetCities();
        }


        [HttpPost]
        [Route("[action]")]
        [Route("api/City/AddCity")]
        public City AddCity(City city)
        {
             return cityService.AddCity(city);
        }



        [HttpPut]
        [Route("[action]")]
        [Route("api/City/EditCity")]
        public City UpdateCity(City city)
        {
            return cityService.UpdateCity(city);
        }


       
         [HttpDelete]
         [Route("[action]")]
         [Route("api/City/DeleteCity")]
         public City DeleteCity(int id)
         {
             return cityService.DeleteCity(id);
         }



        [HttpGet]
        [Route("[action]")]
        [Route("api/City/GetCityId")]
        public City GetCityId(int id)
        {
            return cityService.GetCityById(id);
        }


    }

}
