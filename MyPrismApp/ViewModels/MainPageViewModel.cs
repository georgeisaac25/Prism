using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Navigation.Xaml;
using Prism.Services;

namespace MyPrismApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private string _title;
        IPageDialogService pageDialogService;
        INavigationService _navigationService;
        public string Title
        {
            get { return _title; }
            set {
                SetProperty(ref _title, value);
                if (_title.Length <= 5)
                {
                    IsEnable = true;
                }
                
            }
        }


        private bool isEnable;
        public bool IsEnable
        {
            get { return isEnable; }
            set
            {
                SetProperty(ref isEnable, value);
            }
        }

        public DelegateCommand MyClick { get; private set; }

        public MainPageViewModel(IPageDialogService pageDialogService,INavigationService navigationService)
        {
            Title = "isaac";
            this._navigationService = navigationService;
            this.pageDialogService = pageDialogService;
            MyClick = new DelegateCommand(MyClickButton).ObservesCanExecute(() => IsEnable);

        }

        private void MyClickButton()
        {
            var par = new Prism.Navigation.NavigationParameters();
            par.Add("hell", 4);

            _navigationService.NavigateAsync("SecondPage",par);
            //pageDialogService.DisplayActionSheetAsync("hello", "hi", "ok");
        }
    }
}
