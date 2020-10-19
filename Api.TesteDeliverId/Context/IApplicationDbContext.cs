using Api.TesteDeliverId.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.TesteDeliverId.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Account> Accounts { get; set; }

        Task<int> SaveChangesAsync();
    }
}
