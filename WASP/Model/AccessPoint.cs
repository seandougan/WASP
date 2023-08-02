using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP.Model
{
    sealed class AccessPoint
    {
        [Description("The SSID is a unique name assigned to the access point. It serves as the identifier for the wireless network. When you search for available Wi-Fi networks on your device, you see a list of SSIDs to choose from.")]
        public string SSID { get; }

        [Description("The BSSID is the unique MAC (Media Access Control) address assigned to the wireless network interface of the access point. It distinguishes one access point from others, especially in cases where multiple access points are part of the same network.")]
        public string BSSID { get; }

        [Description("The Wi-Fi spectrum is divided into different channels to avoid interference between neighboring networks. Access points can be set to operate on specific channels, and the channel information is used by Wi-Fi devices to communicate with the correct access point.")]
        public string Channel { get; }

        [Description("Access points are configured with security settings to protect the network from unauthorized access. Common security protocols include WPA2 (Wi-Fi Protected Access II) and WPA3, which require a password or passphrase to connect to the network.")]
        public string SecuritySettings { get; }

        [Description("Access points operate in different frequency bands, such as 2.4 GHz or 5 GHz. The RF band determines the range and performance characteristics of the Wi-Fi network.")]
        public string RFBand { get; }

        [Description("The encryption type used by the access point for securing the data transmitted over the network. Common encryption types include WEP (Wired Equivalent Privacy), WPA (Wi-Fi Protected Access), and WPA2/WPA3.")]
        public string EncryptionType { get; }

        [Description("The data transmission rate supported by the access point, measured in Mbps (Megabits per second). The transmission rate affects the speed of data transfer between the access point and connected devices")]
        public string TransmissionRate { get; }

        [Description("Access points support various Wi-Fi standards such as 802.11a/b/g/n/ac/ax. The Wi-Fi standard determines the data transfer speed and other capabilities of the access point.")]
        public string SupportedWifiStandards { get; }

        [Description("DHCP is a network protocol used to assign IP addresses to devices connecting to the network. Access points may act as DHCP servers to assign IP addresses to wireless devices.")]
        public string DHCP { get; }
    }
}
