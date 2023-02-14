using BusinessLogicLayer.Interface;
using DataAcccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repository
{
    public class SearchRepository : ISearch
    {
        private readonly GestorvacacionesContext _DBcontext;
        public SearchRepository(GestorvacacionesContext context)
        {
            _DBcontext = context;
        }
        public List<Hotel> Get()
        {
            return _DBcontext.Hotels.OrderBy(x => x.NameHotel).ToList();
        }

        public List<Hotel> GetName(string name)
        {
            return _DBcontext.Hotels.Include(x => x.IdcityNavigation).Where(x=>x.IdcityNavigation.NameCity == name).ToList();
        }


       

    }
}
