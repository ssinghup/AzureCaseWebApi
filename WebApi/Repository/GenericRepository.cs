using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi.Models;
using System.Web.Http;


namespace WebApi.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ApplicationDBContext db = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this.db = new ApplicationDBContext();
            table = db.Set<T>();
        }

        public GenericRepository(ApplicationDBContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }

        
        public IEnumerable<T> GetAll()
        
        {
            return table.ToList();
        }

        public T GetByID(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
            this.Save();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
            this.Save();
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            this.Save();
        }       


        public void Save()
        {
            db.SaveChanges();
        }
    }
}