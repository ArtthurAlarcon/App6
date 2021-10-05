using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class PageTwoViewModel : BaseViewModel
    {

        Command _goToRootCommand;
        Command _goToDetailsCommand;

        public PageTwoViewModel(INavigation navigation = null) : base(navigation)
        {
            Navigation = navigation ?? App.Navigation;
        }

        public Command GoToRootCommand
        {
            get
            {
                if (_goToRootCommand == null)
                {
                    _goToRootCommand = new Command(GoToRootAction);
                }
                return _goToRootCommand;
            }

        }

        public Command GoToDetailsCommand
        {
            get
            {
                if(_goToDetailsCommand == null)
                {
                    _goToDetailsCommand = new Command(GoToDetailsAction);
                }
                return _goToDetailsCommand;
            }
        }

        private void GoToRootAction()
        {
            Navigation.PopToRootAsync();
        }

        private void GoToDetailsAction()
        {
            Navigation.PushAsync(new NavigationPage(new PageDetailsUser()));
        }
    }
}
