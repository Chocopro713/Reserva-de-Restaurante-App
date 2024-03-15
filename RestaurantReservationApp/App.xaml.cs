using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Maui.ApplicationModel.Communication;

namespace RestaurantReservationApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        // Suscribirse al evento RequestedThemeChanged para detectar cambios en el tema
        RequestedThemeChanged += OnRequestedThemeChanged;
    }
    private void OnRequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
    {
        // Cuando cambia el tema, realizar acciones necesarias
        // Por ejemplo, puedes notificar a tus ViewModels para que actualicen la imagen de fondo
        // WeakReferenceMessenger.Default.Send(new MauiMessage(MessageKeys.ThemeChanged));
    }
}

