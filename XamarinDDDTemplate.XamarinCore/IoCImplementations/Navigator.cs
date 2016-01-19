using System;
using Xamarin.Forms;
using XamarinDDDTemplate.Navigation.Interfaces;
using XamarinDDDTemplate.XamarinCore.Views;

namespace XamarinDDDTemplate.XamarinCore.IoCImplementations
{
    public class Navigator : INavigator
    {
        private readonly INavigation navigation;
        private readonly string viewsNamespace = typeof(StartView).Namespace;

        public Navigator(INavigation navigation)
        {
            this.navigation = navigation;
        }

        public async void NavigateBack()
        {
            await navigation.PopAsync();
        }

        public async void NavigateTo(string viewName, object parameter = null)
        {
            var viewToCreate = Type.GetType($"{viewsNamespace}.{viewName}");
            if (viewToCreate == null)
            {
                throw new Exception("Type does not exist!");
            }

            var view = (Page)Activator.CreateInstance(viewToCreate);
            await navigation.PushAsync(view);
        }
    }
}