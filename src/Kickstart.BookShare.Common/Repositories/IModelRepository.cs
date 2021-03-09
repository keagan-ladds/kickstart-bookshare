using Kickstart.BookShare.Common.Models;
using System;
using System.Collections.Generic;

namespace Kickstart.BookShare.Common.Repositories
{
    public interface IModelRepository<T> where T : ModelBase
    {
        public T FindById(Guid id);

        public IEnumerable<T> Get();

        public T Create(T model);

        public T Update(T model);

        public bool Delete(T model);
    }
}
