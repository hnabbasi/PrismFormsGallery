using System;
using CommandingModule.Views;
using Prism.Commands;
using Prism.Navigation;

namespace CommandingModule.ViewModels
{
    public class LoginPageViewModel : MvvmHelpers.BaseViewModel
    {
        readonly INavigationService _navigationService;

        public LoginPageViewModel(INavigationService navigationService)
        {
            Title = "Commanding";
            _navigationService = navigationService;

            //SubmitCommand = new DelegateCommand(OnSumbitTapped).ObservesProperty(()=> IsValid);
            SubmitCommand = new DelegateCommand(OnSumbitTapped, ()=>IsValid).ObservesProperty(() => IsValid);
        }

        private void OnSumbitTapped()
        {
            _navigationService.NavigateAsync(nameof(MainPage));
        }

        private string _username;
        public string Username { get => _username; set { SetProperty(ref _username, value); } }

        private string _password;
        

        public string Password { get => _password; set { SetProperty(ref _password, value); } }

        //public bool IsValid => !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
        private bool _isValid;
        public bool IsValid { get => _isValid; set { SetProperty(ref _isValid, value); } }

        public DelegateCommand SubmitCommand { get; }
    }
}
