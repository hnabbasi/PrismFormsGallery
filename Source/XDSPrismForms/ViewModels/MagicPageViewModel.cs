using System;
using Prism.Commands;
using Prism.Modularity;
using Prism.Services;

namespace XDSPrismForms.ViewModels
{
    public class MagicPageViewModel : MvvmHelpers.BaseViewModel
    {
        private readonly IModuleManager _moduleManager;

        public MagicPageViewModel(IModuleManager moduleManager)
        {
            Title = "Load Modules";
            _moduleManager = moduleManager;

            LoadCommand = new DelegateCommand<string>(OnLoadTapped);
        }

        private void OnLoadTapped(string moduleName)
        {
            if (string.IsNullOrWhiteSpace(moduleName))
                return;

            _moduleManager.LoadModule(moduleName);
        }

        public DelegateCommand<string> LoadCommand { get; }
    }
}
