using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DanfossHeating.ViewModels;
using System;

namespace DanfossHeating.Views;

public partial class AboutPage : UserControl
{
    private AboutViewModel? _viewModel;
    
    public AboutPage()
    {
        InitializeComponent();
        Console.WriteLine("AboutPage constructed");
        
        Loaded += Page_Loaded;
        DataContextChanged += Page_DataContextChanged;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    private void Page_Loaded(object? sender, EventArgs e)
    {
        Console.WriteLine("AboutPage loaded and visible");
        UpdateThemeClass();
    }
    
    private void Page_DataContextChanged(object? sender, EventArgs e)
    {
        if (_viewModel != null)
        {
            _viewModel.PropertyChanged -= ViewModel_PropertyChanged;
        }
        
        _viewModel = DataContext as AboutViewModel;
        
        if (_viewModel != null)
        {
            Console.WriteLine($"AboutPage received DataContext with userName: {_viewModel.UserName}");
            _viewModel.PropertyChanged += ViewModel_PropertyChanged;
            UpdateThemeClass();
        }
        else
        {
            Console.WriteLine("WARNING: AboutPage DataContext is not AboutViewModel");
        }
    }
    
    private void ViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(AboutViewModel.IsDarkTheme))
        {
            UpdateThemeClass();
        }
    }
    
    private void UpdateThemeClass()
    {
        try
        {
            if (_viewModel != null)
            {
                Classes.Set("dark", _viewModel.IsDarkTheme);
                Console.WriteLine($"Updated AboutPage theme class: {(_viewModel.IsDarkTheme ? "dark" : "light")}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error setting theme class: {ex.Message}");
        }
    }
}
