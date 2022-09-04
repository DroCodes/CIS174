using System;
using System.ComponentModel.DataAnnotations;

namespace CIS174EntityFrameworkDemo.Entities
{
    public class Recipe
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public TimeSpan TimeToCook { get; set; }

        public bool isDeleted { get; set; }

        [StringLength(1024)]
        public string Method { get; set; }

        public bool isVegetarian { get; set; }

        public bool isVegan { get; set; }

        public ICollection<Ingredients> Ingredients { get; set; }
    }
}
