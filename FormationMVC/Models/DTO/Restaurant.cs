using System.ComponentModel.DataAnnotations;

namespace FormationMVC.Models.DTO
{
    public class Restaurant
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Name { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]

        public string PhoneNumber { get; set; }

        public  List<Cuisin> Cuisines { get; set; }
    }
}
