using System;
using System.Collections.Generic;
using System.Text;
using DomainBriza.Services;
using BrizaInfra.Datasource;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BrizaInfra.Generics
{
    public abstract class GenericData<T> : IServiceBase<T>
         where T : class
    {
        protected BrizaContext _brizaContext;
       // private DbSet<T> entities;

        public GenericData(BrizaContext brizaContext)
        {
            _brizaContext = brizaContext;
        }

      //  public BrizaContext BrizaContext => _brizaContext;

        public void Insert(T entidade)
        {
           // using(BrizaContext _brizaContext = new BrizaContext())
            _brizaContext.Set<T>().Add(entidade);
            _brizaContext.SaveChanges();
        }

        public IQueryable<T> List()
        {
            return _brizaContext.Set<T>();
        }

        public T ListId(int id)
        {
            return _brizaContext.Set<T>().Find(id);
        }

        public void Remov(T entidade)
        {
            _brizaContext.Set<T>().Remove(entidade);
            _brizaContext.SaveChanges();
        }

        public void Update(T entidade)
        {
            _brizaContext.Set<T>().Update(entidade);
            _brizaContext.SaveChanges();
        }
    }
}
