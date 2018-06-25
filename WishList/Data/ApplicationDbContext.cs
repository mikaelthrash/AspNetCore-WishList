using System;
using Microsoft.EntityFrameworkCore;

namespace WishList.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

