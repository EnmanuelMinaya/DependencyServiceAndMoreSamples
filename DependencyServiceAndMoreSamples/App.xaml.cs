using DependencyServiceAndMoreSamples.ViewModels;
using DependencyServiceAndMoreSamples.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DependencyServiceAndMoreSamples
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
            InitializeComponent();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync($"{NavigationConstants.NavigationPage}/{NavigationConstants.Main}");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(NavigationConstants.NavigationPage);
            containerRegistry.RegisterForNavigation<MainTabbedPage>(NavigationConstants.Main);
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>(NavigationConstants.Home);

        }
    }
}
