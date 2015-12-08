using KBMath;
using MathExpressions.ViewModels;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MathExpressions
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer container = new UnityContainer();


            //container.RegisterType<IMathParser, MathParser>();
            //container.RegisterType<IMainWindowViewModel, MainWindowViewModel>();

            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default);


            var window = container.Resolve<MainWindow>();
            window.Show();
        }
    }
}
