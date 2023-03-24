using FormationMVC.Models.DTO;

namespace FormationMVC.ViewModel
{
    public class CreateVM
    {
        public List<Cuisin> Cuisins { get; set; }
        public Restaurant Restaurant { get; set; }

        public CreateVM(List<Cuisin> cuisins,Restaurant restaurant) {
               Cuisins=cuisins;
            Restaurant=restaurant;
        }

        public CreateVM()
        {
        }
    }
}
