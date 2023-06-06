using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.ViewModels
{
    public class AppShellViewModel : Conductor<object>
    {
        public AppShellViewModel() 
        {
            ActiveItem = new WeatherScreenViewModel();
        }
    }
}
