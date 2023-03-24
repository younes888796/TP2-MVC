using FormationMVC.Models.DTO;

namespace FormationMVC.Models.Abstracts
{
    public interface IRestaurantService
    {
        Restaurant GetRestaurant(string id);
        List<Restaurant> getAllRestaurants();
        Restaurant AddRestaurant(Restaurant restaurant);
        Restaurant UpdateRestaurant(Restaurant newRestaurant);
        Restaurant DeleteRestaurant(string id);
       
    }
}
