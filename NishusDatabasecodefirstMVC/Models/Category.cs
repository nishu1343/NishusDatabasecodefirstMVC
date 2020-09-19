using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace NishusDatabasecodefirstMVC.Models
{
    public class Category
    {
        /*id property will bcome the primary key column of the db table
         * by default, the EF interprets a property named ID or 'classname' ID as the primary key*/
        public int Id { get; set;}
        public String CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}