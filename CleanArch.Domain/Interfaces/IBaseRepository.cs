using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntitie

    {
        void Created(T entity);
        void Updated(T entity);
        void Delete(T entity);
        Task<T> Get(Guid id, CancellationToken cancellation);
        Task<List<T>> GetAll(CancellationToken cancellation);

    }
}
