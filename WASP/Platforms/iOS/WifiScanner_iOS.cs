using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WASP.Abstractions;
using WASP.Platforms.iOS;

[assembly: Dependency(typeof(WifiScanner_iOS))]
namespace WASP.Platforms.iOS
{
    internal class WifiScanner_iOS : IWifiScanner
    {
        public void ScanForWifiNetworks()
        {
            throw new NotImplementedException();
        }
    }
}
