using Caliburn.Micro;
using System;
using System.Windows;
using WeatherApp.ViewModels;

namespace WeatherApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper() 
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<AppShellViewModel>();
        }
    }
}
