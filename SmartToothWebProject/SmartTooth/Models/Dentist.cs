using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartTooth.Models
{
    public class Dentist
    {


        public Guid Id { get; set; }

        [StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
        [Required(ErrorMessage = "Please enter a  Name")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
        [Required(ErrorMessage = "Please enter a  LastName")]
        public string LastName { get; set; }

        [Phone]
        [Required(ErrorMessage = "Please enter a  Number")]
        public string Number { get; set; }

        [Url]
        [Required(ErrorMessage = "Please enter a  FacebookUrl")]
        public string FacebookUrl { get; set; }

        [StringLength(1000, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
        [Required(ErrorMessage = "Please enter a  Specialization")]
        public string Specialization { get; set; }

        [Required(ErrorMessage = "Please enter a  Email")]
        public string Email { get; set; }

        [StringLength(1000, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
        [Required(ErrorMessage = "Please enter a  Description")]
        public string Description { get; set; }

        public double Popularity { get; set; }
    }
}
