using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Prism.Modularity;

namespace XDSPrismForms
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
            InitializeComponent();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync($"NavigationPage/MainPage/CategoryPage/DetailPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
			moduleCatalog.AddModule<GeneralModule.GeneralModule>();
			moduleCatalog.AddModule<NavigationModule.NavigationModule>(InitializationMode.WhenAvailable);
        }
    }
}
