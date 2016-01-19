using Foundation;
using Ninject;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinDDDTemplate.XamarinCore;
using XLabs.Ioc;
using XLabs.Ioc.Ninject;

namespace XamarinDDDTemplate.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();
            var kernel = SetIoc();
            LoadApplication(new App(kernel));

            return base.FinishedLaunching(app, options);
        }

        private IKernel SetIoc()
        {
            var kernel = new StandardKernel();
            kernel.Load(new[] { typeof(AppDelegate).Assembly });
            var container = new NinjectContainer(kernel);
            Resolver.SetResolver(container.GetResolver());
            return kernel;
        }
    }
}