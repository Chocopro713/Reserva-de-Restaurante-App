namespace RestaurantReservationApp.Converters;

public class ShadowRadiusConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        bool isAnimationRunning = (bool)value;

        // Definir el radio del efecto de sombra basado en si la animación está activa o inactiva
        if (isAnimationRunning)
        {
            return Device.RuntimePlatform == Device.iOS ? 15 : 50; // Ajusta el radio según la plataforma
        }
        else
        {
            return Device.RuntimePlatform == Device.iOS ? 30 : 100; // Ajusta el radio según la plataforma
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
