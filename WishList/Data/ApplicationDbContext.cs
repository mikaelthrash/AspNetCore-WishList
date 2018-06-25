using System;

namespace Microsoft.EntityFrameworkCore
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

