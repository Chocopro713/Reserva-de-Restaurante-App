namespace RestaurantReservationApp.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Newtonsoft.Json;
    using RestaurantReservationApp.Models;
    using RestaurantReservationApp.Views;

    public class HomeViewModel : BaseViewModel
	{
        #region Properties
        public ObservableCollection<RestaurantModel> Restaurants { get; set; } = new ObservableCollection<RestaurantModel>();
        public ICommand GoToRestaurantCommand => new Command<RestaurantModel>(OnGoToRestaurantCommand);
        public ICommand SaveRestaurantCommand => new Command<RestaurantModel>(OnSaveRestaurantCommand);
        public double ShadowRadius { get; set; }
        public bool IsAnimating { get; set; }

        private const double MaxShadowRadius = 120; // Máximo radio de la sombra
        private const double MinShadowRadius = 20; // Mínimo radio de la sombra
        private const int AnimationDuration = 1000; // Duración de la animación en milisegundos
        #endregion Properties

        #region Constructor
        public HomeViewModel()
		{
			InitData();
            // this.PageActual = this.Home;
            // this.HomeActivated = true;

            // Inicializar el radio de la sombra
            ShadowRadius = MaxShadowRadius;

            // Iniciar la animación
            StartAnimation();
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
            };
        }
        private void StartAnimation()
        {
            IsAnimating = true;

            double currentRadius = MinShadowRadius;





            /*
            Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
            {
                // Aumentar o disminuir el radio de la sombra según la dirección
                if (currentRadius < MaxShadowRadius)
                {
                    currentRadius += 10; // Aumentar el radio
                }
                else if (currentRadius >= MaxShadowRadius && currentRadius > MinShadowRadius)
                {
                    currentRadius -= 10; // Disminuir el radio
                }
                else
                {
                    // Reiniciar la animación
                    currentRadius = MinShadowRadius;
                }

                // Actualizar el radio del efecto de sombra
                ShadowRadius = currentRadius;

                // Continuar la animación mientras esté activa
                return IsAnimating;
            });
            */
        }
        #endregion Methods

        #region Commands
        public async void OnGoToRestaurantCommand(RestaurantModel restaurant)
        {
            var jsonstring = JsonConvert.SerializeObject(restaurant);
            var navigationParameter = new Dictionary<string, object> { { "RestaurantJson", jsonstring } };
            await Shell.Current.GoToAsync($"/{nameof(RestaurantDetailPage)}", true, navigationParameter);
        }

        public async void OnSaveRestaurantCommand(RestaurantModel restaurant)
        {
            Console.WriteLine(restaurant);
        }
        #endregion Commands
    }
}

