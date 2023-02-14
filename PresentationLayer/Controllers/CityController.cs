using BusinessLogicLayer.Interface;
using DataAcccesLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [ApiController]
    [Route("Api/City")]
    public class CityController : ControllerBase
    {
        private readonly ICity _ICity;

         public CityController(ICity City) { 
        
            _ICity= City;
        } 
            
        [HttpGet]
        public ActionResult<List<City>> Get()
        {
            return _ICity.Get();
        }

 
        [HttpPost]
        public ActionResult Create(City model )
        {
            _ICity.Add(model);
            return Ok();
        }



        [HttpPut]
        [HttpPut("{id}")]
        public async Task<ActionResult> Edit(int id, [FromBody] City model)
        {
            model.Id = id;
            _ICity.Put(model);
            return Ok();
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _ICity.Delete(id);
            return Ok();
        }

    }
}
