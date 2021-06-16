using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDrinks.Models
{
    public class Brand
    {
        //in ASP.NET, Primary Key fields should always be called either Id or{Model}Id  -  e.g BrandId
        //we use this Model in the Controller to create a mockup list of brand objects, pass to the Index View and use a loop
        public int Id { get; set; }

        [Required(ErrorMessage = "Hey you! Don't forget me!")]
        [MaxLength(100)]
        public string Name { get; set; }
        

        [Range(1400,2025)]
        [Display(Name = "Year Founded")]
        public int YearFounded { get; set; }

        //navigation property to child Product objects - every brand(Parent) has a list of child Products  (Category is also
        //a parent of product)
        public List<Product> Products { get; set; }
    }
}
