using System;
using System.ComponentModel.DataAnnotations;

namespace CIS174EntityFrameworkDemo.Entities
{
    public class Ingredients
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public decimal Quantity { get; set; }

        [StringLength(12)]
        public string Unit { get; set; }

    }
}

