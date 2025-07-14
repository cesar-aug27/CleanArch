using CleanArch.Domain.Entities;
using CleanArch.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Persistence.Repositories

    public class UserRepositoty : BaseRepository<User>
    {
        protected readonly AppDbContext appDbContext1;
        public UserRepositoty(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<User> GetByEmail(string email, CancellationToken cancellation)
        {
            return await appDbContext1.Users.FirstOrDefaultAsync(x => x.Email == email, cancellation);
        }
    }
}
