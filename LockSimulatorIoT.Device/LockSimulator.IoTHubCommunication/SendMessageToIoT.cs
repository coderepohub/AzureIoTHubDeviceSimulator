using LockSimulator.Device.Common;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSimulator.IoTHubCommunication
{
    public class SendMessageToIoT
    {
        public async Task SendMessage(DeviceClient deviceClient,LockMessage lockMessage)
        {
            var messagePayload = JsonConvert.SerializeObject(lockMessage);
            var message = new Message(Encoding.ASCII.GetBytes(messagePayload));
            await deviceClient.SendEventAsync(message);
        }
    }
}
