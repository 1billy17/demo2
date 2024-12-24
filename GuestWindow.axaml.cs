using Avalonia.Controls;
using Avalonia.Interactivity;

namespace demo2;

public partial class GuestWindow : Window
{
    public GuestWindow()
    {
        InitializeComponent();
    }

    private void Sign_OnClick(object? sender, RoutedEventArgs e)
    {
        SignWindow signUpWindowGuest = new SignWindow();
        signUpWindowGuest.ShowDialog(this);
    }
}