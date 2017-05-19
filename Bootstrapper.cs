using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace Prism_Demo
{
    //This is the main bootstrapper class
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(MenuModule.MenuModule));
            moduleCatalog.AddModule(typeof(NavModule.NavModule));
            moduleCatalog.AddModule(typeof(ContentModule.ContentModule));
        }

    }
}
