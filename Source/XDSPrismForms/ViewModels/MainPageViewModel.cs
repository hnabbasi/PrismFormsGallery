using System;
using Prism.Commands;
using Prism.Navigation;

namespace XDSPrismForms.ViewModels
{
    public class MainPageViewModel : MvvmHelpers.BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand<string> AreaSelected { get; }

        public MainPageViewModel(INavigationService navigationService)
        {
            Title = "Prism.Forms";
            _navigationService = navigationService;

            AreaSelected = new DelegateCommand<string>(OnAreaSelected);
        }

        private void OnAreaSelected(string area)
        {
            switch (area)
            {
                case "Commanding":
                    _navigationService.NavigateAsync($"{nameof(CommandingModule.Views.LoginPage)}"); //"LoginPage"
                    break;
                case "Navigation":
                    _navigationService.NavigateAsync($"{nameof(NavigationModule.Views.NavMainPage)}");
                    break;
                case "DialogService":
                    _navigationService.NavigateAsync($"{nameof(CommandingModule.Views.LoginPage)}");
                    break;
                case "EventAggregator":
                    _navigationService.NavigateAsync($"{nameof(CommandingModule.Views.LoginPage)}");
                    break;
            }
        }
    }
}
