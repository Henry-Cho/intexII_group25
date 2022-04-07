using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntexFinal.Models
{
    public class CrashDBContext : DbContext
    {
        public CrashDBContext(DbContextOptions<CrashDBContext> options) : base(options)
        {

        }
        public DbSet<crash_data> Crash_Data { get; set; }
    }
}
