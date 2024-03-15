using Microsoft.Maui.Controls;
using RestaurantReservationApp.Models;
using RestaurantReservationApp.ViewModels;

namespace RestaurantReservationApp.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		this.BindingContext = new HomeViewModel();
        // carouselView.CurrentItemChanged += CarouselView_CurrentItemChanged;
    }

    private void carouselTopRestaurants_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {

        if (e.PreviousItem != null)
        {
            var previousRestaurant = e.PreviousItem as RestaurantModel;
            previousRestaurant.IsAnimationRunning = false;
        }

        if (e.CurrentItem != null)
        {
            var currentRestaurant = e.CurrentItem as RestaurantModel;
            currentRestaurant.IsAnimationRunning = true;
        }
    }
}
