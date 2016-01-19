using Ninject;
using Xamarin.Forms;
using XamarinDDDTemplate.Navigation.Interfaces;
using XamarinDDDTemplate.XamarinCore.IoCImplementations;
using XamarinDDDTemplate.XamarinCore.Views;

namespace XamarinDDDTemplate.XamarinCore
{
    public class App : Application
    {
        public App(IKernel kernel)
        {
            // The root page of your application
            var startPage = new StartView();
            var navigationPage = new NavigationPage(startPage);
            RegisterNavigator(navigationPage, kernel);
            MainPage = navigationPage;
        }

        private void RegisterNavigator(NavigationPage navigationPage, IKernel kernel)
        {
            var navigator = new Navigator(navigationPage.Navigation);
            kernel.Bind<INavigator>().ToConstant(navigator);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}