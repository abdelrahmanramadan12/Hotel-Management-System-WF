using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelMng.Data;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HotelMng.Manager
{
    public static class EntityManager<T> where T : class
    {
        static HotelMngContext context = new HotelMngContext();

        public static IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public static T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public static void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }
        public static void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
        public static void Delete(int id)
        {
            var entity = context.Set<T>().Find(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }
    }
}
