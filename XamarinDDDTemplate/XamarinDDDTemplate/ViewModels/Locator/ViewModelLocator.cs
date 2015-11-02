using XLabs.Ioc;

namespace XamarinDDDTemplate.ViewModels.Locator
{
    public class ViewModelLocator
    {
        public StartViewModel StartViewModel
        {
            get { return Resolver.Resolve<StartViewModel>(); }
        }
    }
}
