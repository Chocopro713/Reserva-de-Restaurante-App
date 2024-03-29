﻿using RestaurantReservationApp.Views;

namespace RestaurantReservationApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(RestaurantsPage), typeof(RestaurantsPage));
        Routing.RegisterRoute(nameof(RestaurantDetailPage), typeof(RestaurantDetailPage));
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        Routing.RegisterRoute(nameof(RatingsPage), typeof(RatingsPage));
    }
}

