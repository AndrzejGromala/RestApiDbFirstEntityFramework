using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDbEntityFramework.Models
{
    public class CarModel
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Field can be only 50 characters long!")]
        public string MakeModel { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Field can be only 50 characters long!")]
        public string Engine { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Field can be only 50 characters long!")]
        public string Transmission { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Field can be only 50 characters long!")]
        public string Color { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Field can be only 50 characters long!")]
        public string Year { get; set; }
    }
}
