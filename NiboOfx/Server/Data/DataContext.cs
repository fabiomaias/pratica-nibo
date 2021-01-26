using NiboOfx.Shared;
using System;
using Microsoft.EntityFrameworkCore;

namespace NiboOfx.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Bank> Banks { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<History> Histories { get; set; }
    }
}
