using DataAcccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public  interface ICity
    {
        void Add( City model);
        void Delete(int id);
        void Put(City model);
        List<City> Get();
        City GetId(int id);

    }
}
