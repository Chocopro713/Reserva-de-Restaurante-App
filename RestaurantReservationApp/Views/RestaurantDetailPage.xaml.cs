using RestaurantReservationApp.ViewModels;

namespace RestaurantReservationApp.Views;

[QueryProperty(nameof(RestaurantJson), "RestaurantJson")]
public partial class RestaurantDetailPage : ContentPage
{
    private string _restaurantJson;
    public string RestaurantJson
    {
        get { return _restaurantJson; }
        set
        {
            _restaurantJson = Uri.UnescapeDataString(value);
            (BindingContext as RestaurantDetailViewModel)?.UpdateModel(_restaurantJson);
        }
    }


    public RestaurantDetailPage()
    {
        InitializeComponent();
        this.BindingContext = new RestaurantDetailViewModel();
    }

}
