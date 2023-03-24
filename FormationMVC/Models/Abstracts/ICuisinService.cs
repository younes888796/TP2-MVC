using FormationMVC.Models.DTO;

namespace FormationMVC.Models.Abstracts
{
    public interface ICuisinService
    {
        public List<Cuisin> GetAllCuisin();
        public void AddCuisin(Cuisin cuisin);
        public void RemoveCuisin(string Name);
        public void UpdateCuisin(string Name);
        public void DeleteCuisin(string Name);
        public Cuisin GetCuisin(string Name);
    }
}
