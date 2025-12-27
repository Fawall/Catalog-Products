using System;
using System.ComponentModel.DataAnnotations;

namespace src.Model
{
    public class Catalog
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "What name of product?")]
        [StringLength(maximumLength: 10, MinimumLength = 3  )]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 10, MinimumLength: 3 )]
        public string Category { get; set; }
    }
}