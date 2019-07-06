﻿using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Prism.Modularity;
using XDSPrismForms.Views;

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
            NavigationService.NavigateAsync($"NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<MagicPage>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
			moduleCatalog.AddModule<CommandingModule.CommandingModule>(InitializationMode.OnDemand);
            moduleCatalog.AddModule<GeneralModule.GeneralModule>(InitializationMode.OnDemand);
            moduleCatalog.AddModule<NavigationModule.NavigationModule>(InitializationMode.OnDemand);
        }
    }
}
