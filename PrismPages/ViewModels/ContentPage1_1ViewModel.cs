using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismPages.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace PrismPages.ViewModels
{
    public class ContentPage1_1ViewModel : BindableBase
    {
        public DelegateCommand NavigateBackwardCommand { get; set; }
        
        public ContentPage1_1ViewModel(INavigationService navigationService)
        {
            NavigateBackwardCommand = new DelegateCommand(async () =>
            {
                var result = await navigationService.GoBackAsync();
            });
        }
    }
}
