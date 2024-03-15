using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Maui.ApplicationModel.Communication;
using PropertyChanged;
using RestaurantReservationApp.Views;

namespace RestaurantReservationApp.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public class BaseViewModel
    {
        #region Properties
        // public event PropertyChangedEventHandler PropertyChanged;

        public string PageActual { get; set; }
        public ICommand ChangePageCommand => new Command<string>(OnChangePageCommand);

        public string Home = "Home";
        public string Restaurantes = "Restaurantes";
        public string Historial = "Historial";
        public string Perfil = "Perfil";

        public bool HomeActivated { get; set; }
        public bool RestaurantesActivated { get; set; }
        public bool HistorialActivated { get; set; }
        public bool PerfilActivated { get; set; }

        public ICommand SaveRestaurantCommand => new Command(OnSaveRestaurantCommand);
        public ICommand GoBackCommand => new Command(OnGoBackCommand);
        #endregion Properties

        #region Constructor
        public BaseViewModel()
		{

        }
        #endregion Constructor

        #region Methods
        private async void TEST()
        {
            // WeakReferenceMessenger.Default.Register<MauiMessage>(this, (r, m) =>
            // {
            //     OnMessageReceived(m.Value);
            // });
        }
        #endregion Methods

        #region Commands
        /// <summary>
        /// Metodo para cambiar de pagina con el parametro desde el xaml
        /// </summary>
        /// <param name="page"></param>
        private async void OnChangePageCommand(string page)
        {
            switch (page)
            {
                case nameof(Home):
                    return;
                case nameof(Restaurantes):
                    if (this.PageActual != "Restaurantes")
                        await Shell.Current.GoToAsync($"./{nameof(RestaurantsPage)}");
                    return;
                case nameof(Historial):
                    return;
                case nameof(Perfil):
                    return;
            }
        }

        /// <summary>
        /// Comando para regresar de la pagina
        /// </summary>
        private async void OnGoBackCommand()
        {
            await Shell.Current.GoToAsync("..", true);
        }

        /// <summary>
        /// Comando para guardar el restaurante
        /// </summary>
        private void OnSaveRestaurantCommand()
        {

        }
        #endregion Commands
    }
}

