using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTransmissionDal : ITransmissionDal
    {
        public void Add(Transmission entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Transmission entity)
        {
            throw new NotImplementedException();
        }

        public Transmission Get(Expression<Func<Transmission, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Transmission> GetAll(Expression<Func<Transmission, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Transmission entity)
        {
            throw new NotImplementedException();
        }
    }
}
