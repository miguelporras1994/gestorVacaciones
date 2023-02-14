using BusinessLogicLayer.Interface;
using DataAcccesLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [ApiController]
    [Route("Api/Search")]
    public class SearchContraller : ControllerBase
    {

      
  
            private readonly ISearch _ISearch;

            public SearchContraller(ISearch Search)
            {

                _ISearch = Search;
            }

            [HttpGet]
            public ActionResult<List<Hotel>> Get(string name)
            {
            return _ISearch.GetName(name);
        }



        //[HttpGet]
        //public ActionResult<List<Hotel>> GetforCity( string name)
        //{
        //    
        //}

    }
}
