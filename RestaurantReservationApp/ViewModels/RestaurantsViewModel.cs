﻿using Newtonsoft.Json;
using RestaurantReservationApp.Models;
using RestaurantReservationApp.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
namespace RestaurantReservationApp.ViewModels
{
	public class RestaurantsViewModel : BaseViewModel
	{
        #region Properties
        public ObservableCollection<RestaurantModel> Restaurants { get; set; } = new ObservableCollection<RestaurantModel>();

        public string Search { get; set; }

        public ICommand SearchRestaurants => new Command(OnSearchRestaurants);
        public ICommand GoToRestaurantCommand => new Command<RestaurantModel>(OnGoToRestaurantCommand);
        #endregion Properties

        #region Constructor
        public RestaurantsViewModel()
        {
            InitData();
        }
        #endregion Constructor

        #region Methods

        private void InitData()
        {
            this.Restaurants = new ObservableCollection<RestaurantModel>()
            {
                new RestaurantModel()
                {
                    Name = "Test Restaurant 1",
                    Address = "Test Address 1",
                    ImagePath = "dotnet_bot.png",
                },
                new RestaurantModel()
                {
                    Name = "Test Restaurant 2",
                    Address = "Test Address 2",
                    ImagePath = "dotnet_bot.png",
                },
                new RestaurantModel()
                {
                    Name = "Test Restaurant 3",
                    Address = "Test Address 3",
                    ImagePath = "dotnet_bot.png",
                },
                new RestaurantModel()
                {
                    Name = "Test Restaurant 4",
                    Address = "Test Address 4",
                    ImagePath = "dotnet_bot.png",
                },

                new RestaurantModel()
                {
                    Name = "Test Restaurant 1",
                    Address = "Test Address 1",
                    ImagePath = "dotnet_bot.png",
                },
                new RestaurantModel()
                {
                    Name = "Test Restaurant 2",
                    Address = "Test Address 2",
                    ImagePath = "dotnet_bot.png",
                },
                new RestaurantModel()
                {
                    Name = "Test Restaurant 3",
                    Address = "Test Address 3",
                    ImagePath = "dotnet_bot.png",
                },
                new RestaurantModel()
                {
                    Name = "Test Restaurant 4",
                    Address = "Test Address 4",
                    ImagePath = "dotnet_bot.png",
                },

                new RestaurantModel()
                {
                    Name = "Test Restaurant 1",
                    Address = "Test Address 1",
                    ImagePath = "dotnet_bot.png",
                },

                new RestaurantModel()
                {
                    Name = "Test Restaurant 1",
                    Address = "Test Address 1",
                    ImagePath = "dotnet_bot.png",
                },

                new RestaurantModel()
                {
                    Name = "Test Restaurant 1",
                    Address = "Test Address 1",
                    ImagePath = "dotnet_bot.png",
                }
            };
        }
        #endregion Methods

        #region Commands
        private void OnSearchRestaurants()
        {
            // InitData();
        }

        public async void OnGoToRestaurantCommand(RestaurantModel restaurant)
        {
            var jsonstring = JsonConvert.SerializeObject(restaurant);
            var navigationParameter = new Dictionary<string, object> { { "RestaurantJson", jsonstring } };
            await Shell.Current.GoToAsync($"/{nameof(RestaurantDetailPage)}", true, navigationParameter);
        }
        #endregion Commands
    }
}

