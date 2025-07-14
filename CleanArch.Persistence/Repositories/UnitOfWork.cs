using CleanArch.Domain.Interfaces;
using CleanArch.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Persistence.Repositories
{
    internal class UnitOfWork : IUnitOfWorl

    {
        protected readonly AppDbContext appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task Commit(CancellationToken cancellationToken)
        {
            await appDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
