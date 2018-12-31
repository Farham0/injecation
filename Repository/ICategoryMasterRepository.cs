using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    interface ICategoryMasterRepository
    {
        IEnumerable<WebApplication2.Models.category> GetAll();
        Models.category Get(int id);
        Models.category Add(Models.category item);
        bool Update(Models.category item);
        bool Delete(Models.category id);
    }
}