using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainBriza.Services
{
   public interface IServiceBase <T>
        where T: class
    {
        void Insert(T entidade);
        void Remov(T entidade);
        void Update(T entidade);
        IQueryable<T> List();
        T ListId(int id);
    }
}
