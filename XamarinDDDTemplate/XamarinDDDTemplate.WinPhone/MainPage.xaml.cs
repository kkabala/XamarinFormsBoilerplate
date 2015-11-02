using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Ninject;
using XLabs.Ioc;
using XLabs.Ioc.Ninject;

namespace XamarinDDDTemplate.WinPhone
{
    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            global::Xamarin.Forms.Forms.Init();
            SetIoc();
            LoadApplication(new XamarinDDDTemplate.App());
        }

        private void SetIoc()
        {
            var kernel = new StandardKernel();
            kernel.Load(new []{typeof(MainPage).Assembly});
            var container = new NinjectContainer(kernel);
            Resolver.SetResolver(container.GetResolver());
        }
    }
}
