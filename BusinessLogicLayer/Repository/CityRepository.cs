using BusinessLogicLayer.Interface;
using DataAcccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repository
{
    public  class CityRepository : ICity
    {
        private readonly GestorvacacionesContext _DBcontext;
        public CityRepository(GestorvacacionesContext context) {
        _DBcontext= context;
        }
        public void Add(City model)
        {

            _DBcontext.Cities.Add(model);
            _DBcontext.SaveChanges();

            

        }

        public void Delete(int id)
        {
            var City = _DBcontext.Cities.Find(id);
            _DBcontext.Cities.Remove(City);
            _DBcontext.SaveChanges();
        }

        public List<City> Get()
        {
            return _DBcontext.Cities.OrderBy(x => x.NameCity).ToList();
        }

        public City GetId(int id)
        {
            return _DBcontext.Cities.Where(x => x.Id == id).FirstOrDefault();  
        }

        public void Put(City model)
        {
            _DBcontext.Cities.Update(model);
            _DBcontext.SaveChanges();
            
        }
    }
}
