using DataAcccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface ISearch
    {
        List<Hotel> Get();
        public List<Hotel> GetName(string name);
    }
}
