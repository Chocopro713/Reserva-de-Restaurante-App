using System.Windows.Input;
using PropertyChanged;
using RestaurantReservationApp.Views;

namespace RestaurantReservationApp.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public class BaseViewModel
    {
        #region Properties
        public string PageActual { get; set; }
        public ICommand ChangePageCommand => new Command<string>(OnChangePageCommand);

        public string Home = "Home";
        public string Restaurantes = "Restaurantes";
        public string Historial = "Historial";
        public string Perfil = "Perfil";
        #endregion Properties

        #region Constructor
        public BaseViewModel()
		{
        }
        #endregion Constructor



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
        #endregion Commands
    }
}

