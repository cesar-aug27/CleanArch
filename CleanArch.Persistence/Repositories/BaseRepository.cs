using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntitie
    {

        protected readonly AppDbContext _appDbContext;
        public BaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Created(T entity)
        {
            entity.DataCreated = System.Data.DataSetDateTime.Utc;
            _appDbContext.Add(entity);

        }

        public void Delete(T entity)
        {
            entity.DataDelete = System.Data.DataSetDateTime.Utc;
            _appDbContext.Remove(entity);
        }

        public async Task<T> Get(Guid id, CancellationToken cancellation)
        {
            return await _appDbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellation);
        }

        public async Task<List<T>> GetAll(CancellationToken cancellation)
        {
            return await _appDbContext.Set<T>().ToListAsync(cancellation);
        }

        public void Updated(T entity)
        {
            entity.DataUpdate = System.Data.DataSetDateTime.Utc;
            _appDbContext.Update(entity);
        }
    }
}
