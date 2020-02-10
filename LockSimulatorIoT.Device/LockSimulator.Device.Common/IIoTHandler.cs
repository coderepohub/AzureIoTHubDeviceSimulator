using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSimulator.Device.Common
{
   public interface IIoTHandler
    {
        Task SendMessage(DeviceClient deviceClient, LockMessage lockMessage);
        Task RecieveMessage(DeviceClient deviceClient);
    }
}
