using RestaurantReservationApp.ViewModels;

namespace RestaurantReservationApp.Views;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
		this.BindingContext = new ProfileViewModel();
	}
}