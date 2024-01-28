namespace RestaurantReservationApp.ViewModels
{
    using System.Collections.ObjectModel;
    using RestaurantReservationApp.Models;

    public class HomeViewModel : BaseViewModel
	{
        #region Properties
        public ObservableCollection<RestaurantModel> Restaurants { get; set; } = new ObservableCollection<RestaurantModel>();
        #endregion Properties

        #region Constructor
        public HomeViewModel()
		{
			InitData();
            this.PageActual = this.Home;
        }
        #endregion Constructor

        #region Methods
        private void InitData()
        {
            this.Restaurants = new ObservableCollection<RestaurantModel>()
            {
                new RestaurantModel()
                {
                    Nombre = "Test Restaurant 1",
                    Direccion = "Test Direccion 1",
                    ImagePath = "https://cloudfront-us-east-1.images.arcpublishing.com/elespectador/2K7FHLJP75FGRO2LKQMCFKFKWA.jpg",
                },
                new RestaurantModel()
                {
                    Nombre = "Test Restaurant 2",
                    Direccion = "Test Direccion 2",
                    ImagePath = "https://www.eltiempo.com/files/image_640_428/uploads/2022/11/11/636ec9b036dfd.png",
                },
                new RestaurantModel()
                {
                    Nombre = "Test Restaurant 3",
                    Direccion = "Test Direccion 3",
                    ImagePath = "https://resizer.otstatic.com/v2/photos/wide-large/2/50220121.jpg",
                },
                new RestaurantModel()
                {
                    Nombre = "Test Restaurant 4",
                    Direccion = "Test Direccion 4",
                    ImagePath = "https://www.lavanguardia.com/files/og_thumbnail/files/fp/uploads/2021/12/23/61c456cc62a0b.r_d.2520-1680-0.jpeg",
                },
            };
        }
        #endregion Methods

        #region Commands
        #endregion Commands
    }
}

