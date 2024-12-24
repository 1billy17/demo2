using Avalonia.Controls;
using Avalonia.Interactivity;

namespace demo2;

public partial class AdminWindow : Window
{
    public AdminWindow()
    {
        InitializeComponent();
    }

    private void AddProductButton_OnClick(object? sender, RoutedEventArgs e)
    {
        AddProduct addProduct = new AddProduct();
        addProduct.ShowDialog(this);
    }

    private void Sign_OnClick(object? sender, RoutedEventArgs e)
    {
        SignWindow signWindowAdmin = new SignWindow();
        signWindowAdmin.ShowDialog(this);
    }

    private void ViewRecords_OnClick(object? sender, RoutedEventArgs e)
    {
        ViewWindow viewWindow = new ViewWindow();
        viewWindow.ShowDialog(this);
    }
}