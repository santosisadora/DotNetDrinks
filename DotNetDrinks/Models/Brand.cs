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

        [Required]
        public string Name { get; set; }
        [Range(1400,2025)]
        public int YearFounded { get; set; }
    }
}
