using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Zadanie1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static string str;

        protected override void OnActivated(EventArgs e)
        {
            str += "Activated \n";
            base.OnActivated(e);
        }

        protected override void OnDeactivated(EventArgs e)
        {
            str += "Deactivated \n";
            base.OnDeactivated(e);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            str += "Startup \n";
            base.OnStartup(e);
        }

    }
}
