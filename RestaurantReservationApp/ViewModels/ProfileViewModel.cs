using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservationApp.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        #region Properties
        public string Wallpaper { get; set; }
        private void GetWallpaper()
        {
            var currentTheme = AppInfo.RequestedTheme;

            if (currentTheme == AppTheme.Dark)
            {
                List<string> fondosOscuros = new List<string> { "fondo_oscuro_1.jpg", "fondo_oscuro_2.jpg", "fondo_oscuro_3.jpg" };
                Random rnd = new Random();
                Wallpaper = fondosOscuros.ElementAt(rnd.Next(fondosOscuros.Count));
            }
            else
            {
                List<string> fondosClaro = new List<string> { "fondo_claro_1.jpg", "fondo_claro_2.jpg", "fondo_claro_3.jpg" };
                Random rnd = new Random();
                Wallpaper = fondosClaro.ElementAt(rnd.Next(fondosClaro.Count));
            }
        }
        #endregion Properties

        #region Constructor
        public ProfileViewModel()
        {
            // Suscribirse al evento AppThemeChanged para detectar cambios en el tema
            GetWallpaper();
            App.Current.RequestedThemeChanged += OnRequestedThemeChanged;
        }
        #endregion Constructor

        private void OnRequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            // Cuando cambia el tema, actualizar la propiedad Wallpaper
            GetWallpaper();
        }
    }
}
