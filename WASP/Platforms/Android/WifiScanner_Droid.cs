using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WASP.Abstractions;
using WASP.Platforms.Android;

[assembly: Dependency(typeof(WifiScanner_Droid))]
namespace WASP.Platforms.Android
{
    internal class WifiScanner_Droid : IWifiScanner
    {
        public void ScanForWifiNetworks()
        {
            throw new NotImplementedException();
        }
    }
}
