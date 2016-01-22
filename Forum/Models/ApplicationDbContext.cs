using System;
using Microsoft.Data.Entity;

namespace Forum.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
