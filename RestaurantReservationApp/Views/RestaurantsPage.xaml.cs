using RestaurantReservationApp.ViewModels;

namespace RestaurantReservationApp.Views;

public partial class RestaurantsPage : ContentPage
{
	public RestaurantsPage()
	{
		InitializeComponent();
		this.BindingContext = new RestaurantsViewModel();
	}
}
