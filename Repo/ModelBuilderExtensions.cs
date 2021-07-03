using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
 
using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public static class ModelBuilderExtensions
    {
        // data for first time 
        public static void seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = "Admin",CreationDate=DateTime.Now,IsDeleted=false}, new Role { Id = 2, Name = "User", CreationDate = DateTime.Now, IsDeleted = false });

            modelBuilder.Entity<FoodType>().HasData(new FoodType { Id = 1, CreationDate = DateTime.Now, foodName = "Pizza", IsDeleted = false }, new FoodType { Id = 2, CreationDate = DateTime.Now, foodName = "meat", IsDeleted = false }, new FoodType { Id = 3, CreationDate = DateTime.Now, foodName = "rice", IsDeleted = false });

            modelBuilder.Entity<Table>().HasData(new Table { Id = 1, tableNumber = 1, CreationDate = DateTime.Now, IsDeleted = false }, 
                new Table { Id = 2, tableNumber = 2, CreationDate = DateTime.Now, IsDeleted = false },
                new Table { Id = 3, tableNumber = 3, CreationDate = DateTime.Now, IsDeleted = false });

        }
    }
}
