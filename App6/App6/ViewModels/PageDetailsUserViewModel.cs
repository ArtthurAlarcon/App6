using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    class PageDetailsUserViewModel : BaseViewModel
    {
        Command _goToPageTwo;

        public PageDetailsUserViewModel(INavigation navigation = null) : base(navigation)
        {
            Navigation = navigation ?? App.Navigation;
        }

        public Command GoToPageTwo
        {
            get => _goToPageTwo ?? (_goToPageTwo = new Command(GoToPageTwoAction));
        }

        private void GoToPageTwoAction()
        {
            Navigation.PushAsync(new NavigationPage(new PageTwo()));
        }
    }
}
