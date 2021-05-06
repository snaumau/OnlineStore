﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder
                    .UseSqlServer(
                        @"Server=localhost\SQLEXPRESS;Database=OnlineStore;Trusted_Connection=True;MultipleActiveResultSets=true",
                        options => options.EnableRetryOnFailure());

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
