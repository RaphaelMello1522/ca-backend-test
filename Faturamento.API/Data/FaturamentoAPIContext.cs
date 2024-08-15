using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Faturamento.API.Business.Models;

namespace Faturamento.API.Data
{
    public class FaturamentoAPIContext : DbContext
    {
        public FaturamentoAPIContext (DbContextOptions<FaturamentoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Faturamento.API.Business.Models.Customers> Customers { get; set; } = default!;
        public DbSet<Faturamento.API.Business.Models.Products> Products { get; set; } = default!;
    }
}
