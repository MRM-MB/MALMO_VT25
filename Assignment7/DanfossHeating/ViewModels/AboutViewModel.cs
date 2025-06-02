using System;
using System.Windows.Input;

namespace DanfossHeating.ViewModels;

public class AboutViewModel : PageViewModelBase
{
    public override PageType PageType => PageType.About;
    
    public ICommand NavigateToHomeCommand { get; }
    public ICommand NavigateToOptimizerCommand { get; }
    public ICommand NavigateToMachineryCommand { get; }
    public ICommand NavigateToAboutCommand { get; }
    
    public AboutViewModel(string userName, bool isDarkTheme) : base(userName, isDarkTheme)
    {
        NavigateToHomeCommand = new Command(NavigateToHome);
        NavigateToOptimizerCommand = new Command(NavigateToOptimizer);
        NavigateToMachineryCommand = new Command(NavigateToMachinery);
        NavigateToAboutCommand = new Command(() => { /* Already on about page */ });
        
        Console.WriteLine($"AboutViewModel created for user: {userName}");
    }
    
    private void NavigateToHome()
    {
        if (MainViewModel != null)
        {
            var viewModel = new HomePageViewModel(UserName, IsDarkTheme);
            viewModel.SetMainViewModel(MainViewModel);
            MainViewModel.NavigateTo(viewModel);
        }
    }
    
    private void NavigateToOptimizer()
    {
        if (MainViewModel != null)
        {
            var viewModel = new OptimizerViewModel(UserName, IsDarkTheme);
            viewModel.SetMainViewModel(MainViewModel);
            MainViewModel.NavigateTo(viewModel);
        }
    }

    
    private void NavigateToMachinery()
    {
        if (MainViewModel != null)
        {
            var viewModel = new MachineryViewModel(UserName, IsDarkTheme);
            viewModel.SetMainViewModel(MainViewModel);
            MainViewModel.NavigateTo(viewModel);
        }
    }
}
