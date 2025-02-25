using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using MvcCvm.Models.Entity;

namespace MvcCvm.Repositories
{
    public class GenericRepository<T> where T: class,new()
    {
        DbCvEntities db= new DbCvEntities();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
       
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void TUpdate(T p)
        {
            db.SaveChanges();
        }

        public T Find(Expression<Func<T,bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }

    }
} 

/*Bu T değeri bizim göndereceğimiz sınıflar olacak
 * Deneyimler olabilir,eğitimler ,hakkımda vs herhangi bir sınıf
 * bu T değerini karşılayacak.
 */