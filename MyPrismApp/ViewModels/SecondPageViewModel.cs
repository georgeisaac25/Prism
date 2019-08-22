using System;
using MyPrismApp.Repository;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace MyPrismApp.ViewModels
{
    public class SecondPageViewModel : BindableBase, INavigatedAware
    {
        IRepo repo;
        public SecondPageViewModel(IRepo repo)
        {
            this.repo = repo;
        }
        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
                

            }
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //OnNavigatedTo  raises when you come from the other page
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //OnNavigateFrom” raise when you navigated from this page to the other page.
            Title = parameters["hell"]+"" + repo.GetNum();

        }
    }
}

