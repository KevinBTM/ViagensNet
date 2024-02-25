using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ViagensNet.Models;

namespace ViagensNet.Data
{
    public class ViagensNetContext : DbContext
    {
        public ViagensNetContext (DbContextOptions<ViagensNetContext> options)
            : base(options)
        {
        }

        public DbSet<ViagensNet.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<ViagensNet.Models.Produto>? Produto { get; set; }

        public DbSet<ViagensNet.Models.Parceiro>? Parceiro { get; set; }
    }
}
