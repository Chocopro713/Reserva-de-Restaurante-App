namespace RestaurantReservationApp.ViewModels
{
    using Newtonsoft.Json;
    using RestaurantReservationApp.Models;

    public class RestaurantDetailViewModel : BaseViewModel
    {
        public RestaurantModel Restaurant { get; set; }

        public RestaurantDetailViewModel()
		{
		}

        public void UpdateModel(string jsonRestaurant) => this.Restaurant = JsonConvert.DeserializeObject<RestaurantModel>(jsonRestaurant);
    }
    
}

