﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shopping_app.Data.Models;

namespace Shopping_app.Data
{
    public class AppDBContent : DbContext
    {
       public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Car> Car { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<ShopCarItem> ShopCarItem { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}