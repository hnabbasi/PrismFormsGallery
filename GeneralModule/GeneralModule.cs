using System;
using GeneralModule.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace GeneralModule
{
    public class GeneralModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            Console.WriteLine($">>> {GetType().Name} initialized.");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
        }
    }
}
