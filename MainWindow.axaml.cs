using Avalonia.Controls;
using Avalonia.Interactivity;

namespace demo2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SelectModeGuest_OnClick(object? sender, RoutedEventArgs e)
    {
        GuestWindow selectModeGuest = new GuestWindow();
        selectModeGuest.ShowDialog(this);
    }

    private void SelectModeAdmin_OnClick(object? sender, RoutedEventArgs e)
    {
        if (Password.Text == "0000") {

            AdminWindow selectModeAdmin = new AdminWindow();
            selectModeAdmin.ShowDialog(this);
        }
    }
}
