namespace RestaurantReservationApp;
using CommunityToolkit.Mvvm.Messaging.Messages;

public class MauiMessage : ValueChangedMessage<string>

{
    public MauiMessage(string value) : base(value)
    {

    }
}

public static class MessageKeys
{
    public const string ThemeChanged = "ThemeChanged";
}