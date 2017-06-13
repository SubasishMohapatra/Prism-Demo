using EnglishModule.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishModule
{
    public class EnglishModule:IModule
    {
        private readonly IRegionManager regionManager;

        public EnglishModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            //Register all views to be displayed
            this.regionManager.RegisterViewWithRegion("NavigationRegion", typeof(EnglishMenuItemView));
            this.regionManager.RegisterViewWithRegion("ContentRegion", typeof(EnglishContentView));
        }
    }
}
