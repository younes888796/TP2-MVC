using FormationMVC.Models.Abstracts;
using FormationMVC.Models.DTO;

namespace FormationMVC.Services
{
    public class CuisinService : ICuisinService
    {
        private List<Cuisin> cuisins = Repository.Repository.GetInstance().Cuisins;
        public void AddCuisin(Cuisin cuisin)
        {
            throw new NotImplementedException();
        }

        public void DeleteCuisin(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Cuisin> GetAllCuisin()
        {
            return cuisins;
        }

        public Cuisin GetCuisin(string Name)
        {
            return cuisins.FirstOrDefault(r => r.Name == Name);
        }

        public void RemoveCuisin(string Name)
        {
            throw new NotImplementedException();
        }

        public void UpdateCuisin(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
