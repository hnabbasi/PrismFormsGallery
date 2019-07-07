using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace XDSPrismForms.ViewModels
{
    public class ModulesPageViewModel : BindableBase
    {
        private readonly IModuleManager _moduleManager;
        private readonly IModuleCatalog _moduleCatalog;

        public ModulesPageViewModel(IModuleManager moduleManager, IModuleCatalog moduleCatalog)
        {
            _moduleManager = moduleManager;
            _moduleCatalog = moduleCatalog;
            LoadModules();
            LoadCommand = new DelegateCommand<IModuleInfo>(OnLoadTapped);
        }

        private IEnumerable<IModuleInfo> _modules;
        public IEnumerable<IModuleInfo> Modules { get => _modules; private set { SetProperty(ref _modules, value); } }

        private void OnLoadTapped(IModuleInfo moduleInfo)
        {
            if (moduleInfo == null)
                return;

            _moduleManager.LoadModule(moduleInfo.ModuleName);
            LoadModules();
        }

        void LoadModules()
        {
            Modules = _moduleCatalog.Modules.OrderByDescending(_ => _.State).ThenBy(_ => _.ModuleName);
        }

        public DelegateCommand<IModuleInfo> LoadCommand { get; }
    }
}
