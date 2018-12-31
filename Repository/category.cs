using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class category : ICategoryMasterRepository
    {

       private testDatabaseEntities context = new testDatabaseEntities();
        public category()
        {
            Models.category newCat = new Models.category();
            newCat.Name = "NewCat" + DateTime.Now.ToShortDateString();
            context.categories.Add(newCat);
            context.SaveChanges();
           
    
        }

        public  Models.category Add(Models.category item)
        {
            context.categories.Add(item);
            context.SaveChanges();
            return item;
        }

        public bool Delete(Models.category id)
        { 
            context.categories.Remove(id);
            context.SaveChanges();
            return true;
        }

        public Models.category Get(int id)
        {
            return context.categories.Where(c => c.Id == id.ToString()).FirstOrDefault();
            
        }

        public IEnumerable<Models.category> GetAll()
        {
            return context.categories;
           
        }

        public bool Update(Models.category item)
        {
            Models.category  cat= Get(Convert.ToInt16(item.Id));
            cat = item;
            context.SaveChanges();
            return true; 
        }
    }
}