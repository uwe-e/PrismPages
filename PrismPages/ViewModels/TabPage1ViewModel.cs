using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismPages.Views;
using System;
using Xamarin.Forms;

namespace PrismPages.ViewModels
{
    public class TabPage1ViewModel : BindableBase
    {
        public DelegateCommand NavigateForwardCommand { get; set; }

        public TabPage1ViewModel(INavigationService navigationService)
        {
            NavigateForwardCommand = new DelegateCommand(async () =>
            {
                await navigationService.NavigateAsync($"{nameof(ContentPage1_1)}");
            });
        }

    }
}
