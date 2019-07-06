using System;
using Prism.Commands;
using Prism.Navigation;

namespace XDSPrismForms.ViewModels
{
    public class MainPageViewModel : MvvmHelpers.BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            Title = "Prism.Forms";

            AreaSelected = new DelegateCommand<string>(OnAreaSelected);
            _navigationService = navigationService;
        }

        private void OnAreaSelected(string obj)
        {
            switch (obj)
            {
                case "Commanding":
                    _navigationService.NavigateAsync($"{nameof(CommandingModule.Views.LoginPage)}");
                    break;
                default:
                    break;
            }
        }

        public DelegateCommand<string> AreaSelected { get; }
    }
}
