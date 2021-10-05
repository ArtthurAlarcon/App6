using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {

        Command _goToViewTwoCommand;
        string _userName;
        string _password;
        bool _isErrorLogin;

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        public bool IsErrorLogin
        {
            get => _isErrorLogin;
            set
            {
                _isErrorLogin = value;
                OnPropertyChanged();
            }
        }

        public Command GoToViewTwoCommand
        {
            get => _goToViewTwoCommand ?? (_goToViewTwoCommand = new Command(GoToViewTwoAction));
        }

        public void GoToViewTwoAction()
        {
            IsErrorLogin = !(string.Equals(UserName, "ABCDE") && string.Equals(Password, "12345"));

            if (!IsErrorLogin)
            {
                UserName = String.Empty;
                Password = String.Empty;
                Navigation.PushAsync(new NavigationPage(new PageTwo()));
            }

        }
    }
}
