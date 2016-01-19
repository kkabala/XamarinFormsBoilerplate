using Android.App;
using Android.Content.PM;
using Android.OS;
using Ninject;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinDDDTemplate.XamarinCore;

namespace XamarinDDDTemplate.Droid
{
    [Activity(Label = "XamarinDDDTemplate", Icon = "@drawable/icon", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            var kernel = SetIoc();
            LoadApplication(new App(kernel));
        }

        private IKernel SetIoc()
        {
            var kernel = new StandardKernel();
            kernel.Load(typeof(MainActivity).Assembly);
            var container = new NinjectContainer(kernel);
            Resolver.SetResolver(container.GetResolver());
            return kernel;
        }
    }
}