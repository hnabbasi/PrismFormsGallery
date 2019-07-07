using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;

namespace XDSPrismForms.ViewModels
{
    public class ModulesPageViewModel : BindableBase
    {
        private readonly IModuleManager _moduleManager;

        public ModulesPageViewModel(IModuleManager moduleManager)
        {
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
