namespace XamarinDDDTemplate.Navigation.Interfaces
{
    public interface INavigator
    {
        void NavigateBack();

        void NavigateTo(string viewName, object parameter = null);
    }
}