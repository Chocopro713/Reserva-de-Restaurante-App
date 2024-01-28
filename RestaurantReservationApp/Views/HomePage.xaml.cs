using RestaurantReservationApp.ViewModels;

namespace RestaurantReservationApp.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		this.BindingContext = new HomeViewModel();
	}
}
