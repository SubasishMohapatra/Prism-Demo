using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsModule
{
    public class MathsModule:IModule
    {
        private readonly IRegionManager regionManager;

        public MathsModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("NavigationRegion", typeof(MathsNavigationItem));
        }
    }
}
