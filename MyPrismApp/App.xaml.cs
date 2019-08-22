using System;
using MyPrismApp.Repository;
using MyPrismApp.ViewModels;
using MyPrismApp.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPrismApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");

            //Uncomment this list to Test Prism Tabbed Page 
            //NavigationService.NavigateAsync(new System.Uri("/NavigationPage/CustomTabbedPage/Test1Page", System.UriKind.Absolute));

            //Uncomment this list to Test Prism Master DetailPage 
            // NavigationService.NavigateAsync(new System.Uri("/CustomMasterDetailPage/NavigationPage/Test1Page", System.UriKind.Absolute));

            //Uncomment this list to Test Prism general concepts as Custom NavigationPage/Modules/DelegateCommands/Services 
            //NavigationService.NavigateAsync(new System.Uri("http://www.MyTestApp/CustomNavigationPage/LoginPage", System.UriKind.Absolute));

        }

        //Connecting Views with ViewModels
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SecondPage, SecondPageViewModel>();
            containerRegistry.Register<IRepo, Repo>();
            containerRegistry.Register<IDB, DbClass>();


        }


    }
}
