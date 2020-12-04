using Prism;
using Prism.Ioc;
using PrismPages.ViewModels;
using PrismPages.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace PrismPages
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<TabPage1, TabPage1ViewModel>();
            containerRegistry.RegisterForNavigation<TabPage2, TabPage2ViewModel>();
            containerRegistry.RegisterForNavigation<ContentPage1_1, ContentPage1_1ViewModel>();
        }
    }
}
