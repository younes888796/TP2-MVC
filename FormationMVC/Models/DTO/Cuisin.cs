using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace FormationMVC.Models.DTO
{
    public class Cuisin
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
