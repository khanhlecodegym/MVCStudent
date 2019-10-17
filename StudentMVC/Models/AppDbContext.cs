﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Group>().HasData(new Group { GroupId = 1, GroupName = "C1", Description = "An Hai" });
            modelBuilder.Entity<Group>().HasData(new Group { GroupId = 2, GroupName = "C2", Description = "Cuc An Hai" });
            modelBuilder.Entity<Group>().HasData(new Group { GroupId = 3, GroupName = "C3", Description = "An Hai Cuc" });
        }
    }
}
