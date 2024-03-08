using RestaurantReservationApp.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
namespace RestaurantReservationApp.ViewModels
{
	public class RestaurantsViewModel : BaseViewModel
	{
        #region Properties
        public ObservableCollection<RestaurantModel> Restaurants { get; set; } = new ObservableCollection<RestaurantModel>();

        public ICommand SearchRestaurants => new Command(OnSearchRestaurants);
        #endregion Properties

        #region Constructor
        public RestaurantsViewModel()
		{
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
                    ImagePath = "https://cloudfront-us-east-1.images.arcpublishing.com/elespectador/2K7FHLJP75FGRO2LKQMCFKFKWA.jpg",
                },
                new RestaurantModel()
                {
                    Name = "Test Restaurant 2",
                    Address = "Test Address 2",
                    ImagePath = "https://www.eltiempo.com/files/image_640_428/uploads/2022/11/11/636ec9b036dfd.png",
                },
                new RestaurantModel()
                {
                    Name = "Test Restaurant 3",
                    Address = "Test Address 3",
                    ImagePath = "https://resizer.otstatic.com/v2/photos/wide-large/2/50220121.jpg",
                },
                new RestaurantModel()
                {
                    Name = "Test Restaurant 4",
                    Address = "Test Address 4",
                    ImagePath = "https://www.lavanguardia.com/files/og_thumbnail/files/fp/uploads/2021/12/23/61c456cc62a0b.r_d.2520-1680-0.jpeg",
                },
            };
        }
        #endregion Methods

        #region Commands
        private void OnSearchRestaurants()
        {
            InitData();
        }
        #endregion Commands
    }
}

