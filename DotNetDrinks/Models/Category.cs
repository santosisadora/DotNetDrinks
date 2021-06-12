using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDrinks.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //navigation property to child Product objects - every brand(Parent) has a list of child Products
        public List<Product> Products { get; set; }
    }
}
