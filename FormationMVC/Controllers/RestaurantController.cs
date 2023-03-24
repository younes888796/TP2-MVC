using FormationMVC.Filter;
using FormationMVC.Models.Abstracts;
using FormationMVC.Models.DTO;
using FormationMVC.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormationMVC.Controllers
{
    //[Route("[controller]")]
    [ResponseHeader("controller","restaurant")]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restaurantService;
        private readonly ICuisinService _cuisinService;
        public RestaurantController(IRestaurantService restaurantService , ICuisinService cuisinService) {
            
            _restaurantService=restaurantService;
            _cuisinService=cuisinService;


        }
        //[Route("/Test/Index/{id?}")]
        // GET: Restaurant
        public ActionResult Index()
        {
            ViewBag.message = "Welcome to the list of Restaurants";
            
            List<Restaurant> restaurants = _restaurantService.getAllRestaurants();

            return View(restaurants);
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(string id)
        {
            var restaurant = _restaurantService.GetRestaurant(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return View(restaurant);
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            var cuisins = _cuisinService.GetAllCuisin();

            var CreateVm = new CreateVM(cuisins, new Restaurant());
            return View(CreateVm);
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateVM createVM)
        {

                    
                 var cuisin = _cuisinService.GetCuisin(Request.Form["Restaurant.Cuisines"].FirstOrDefault());
                  createVM.Restaurant.Cuisines.Add(cuisin);
                _restaurantService.AddRestaurant(createVM.Restaurant);
                TempData["message"] = "Created Succesfully";
                return RedirectToAction("Details", new { id = createVM.Restaurant.Id });
            
            

            
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(string id)
        {
            var restaurant = _restaurantService.GetRestaurant(id);
            var cuisins = _cuisinService.GetAllCuisin();

            var createVm = new CreateVM(cuisins,restaurant);
            if (restaurant == null)
            {
              
               return NotFound();
            }

            return View(createVm);
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id , CreateVM createVM)
        {


            if (!ModelState.IsValid)
            {
                var cuisin = _cuisinService.GetCuisin(Request.Form["Restaurant.Cuisines"].FirstOrDefault());
                createVM.Restaurant.Cuisines.Where(c => 1 != 1);
                createVM.Restaurant.Cuisines.Add(cuisin);
                _restaurantService.UpdateRestaurant(createVM.Restaurant);
                return RedirectToAction(nameof(Index));
            }

                return View();
            


                
            
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(string id)
        {
            _restaurantService.DeleteRestaurant(id);
            return RedirectToAction("Index");
        }

        // POST: Restaurant/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
