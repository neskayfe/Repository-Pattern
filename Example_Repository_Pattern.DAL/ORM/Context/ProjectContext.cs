﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Example_Repository_Pattern.DAL.ORM.Entity.Abstract;
using Example_Repository_Pattern.DAL.ORM.Map;
using Example_Repository_Pattern.DAL.ORM.Entity.Concrete;

namespace Example_Repository_Pattern.DAL.ORM.Context
{
   public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=ExpRP;uid=sa;pwd=*********;";
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new LikeMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Properties<DateTime>().Configure(x => x.HasColumnType("datetime2"));
            base.OnModelCreating(modelBuilder);
        }
    }
}
