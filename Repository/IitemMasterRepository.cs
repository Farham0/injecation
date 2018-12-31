using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

 interface IitemMasterRepository
{
    IEnumerable<WebApplication2.Models.product> GetAll();
    product Get(int id);
    product Add(product item);
    product GetByCategory(category item);
    bool Update(product item);
    bool Delete(product item);

}
 