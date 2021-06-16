using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DotNetDrinks.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        [Range(0,999999)]
        public int Stock { get; set; }

        public string Image { get; set; }


        //foreign keys field - must follow naming convention => {Model}Id -  Visual Studio recognizes it as FK due 
        //to this naming convetion
        [Display(Name="Brand")]
        public int BrandId { get; set; }

        [Display(Name="Category")]
        public int CategoryId { get; set; }

        //navigation(virtual) properties so we dont have to use joins to connect related records
        // this inficates the 2 properties above are fk fields
        public Brand Brand { get; set; }
        public Category Category { get; set; }

        //chield refs
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
