using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MateoPuga_Taller1.Models;

namespace MateoPuga_Taller1.Data
{
    public class MateoPuga_Taller1Context : DbContext
    {
        public MateoPuga_Taller1Context (DbContextOptions<MateoPuga_Taller1Context> options)
            : base(options)
        {
        }

        public DbSet<MateoPuga_Taller1.Models.Burger> Burger { get; set; } = default!;
    }
}
