using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NishusDatabasecodefirstMVC;
using NishusDatabasecodefirstMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NishusDatabasecodefirstMVC.Context
{
    public class ProductManagementContext : DbContext
    {
        /*name of connection string  is passed into the constructor.
         * This name will be used in web.config file */
        public ProductManagementContext() : base("ProductManagementContextDB")
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        /*This code removes the pluralizing convention that is the default behavior for all model builders.then we will be able to 
         * create tables with singular names*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}

    
