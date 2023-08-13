using GorevAtama.Data.Abstarct;
using GorevAtama.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama.Data.Concrete
{
    public class GenereticRepository<TEntity, Tcontext> : IRepository<TEntity>
        where TEntity : class
        where Tcontext : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            using (var context = new Tcontext())
            {
                context.Set<TEntity>().Add(entity); 
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new Tcontext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public  List<TEntity> GetAll()
        {
            using (var context = new Tcontext())
            {
                return context.Set<TEntity>().ToList(); 

            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new Tcontext())
            {
                return context.Set<TEntity>().Find(id);
                
            }
        }



        public void Update(TEntity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }

}
