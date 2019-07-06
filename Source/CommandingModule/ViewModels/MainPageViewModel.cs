using System;
using Prism.Commands;

namespace CommandingModule.ViewModels
{
    public class MainPageViewModel : MvvmHelpers.BaseViewModel
    {
        public MainPageViewModel()
        {
            Title = "Welcome";
        }
    }
}
