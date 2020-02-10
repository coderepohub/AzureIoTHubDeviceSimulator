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
    public class IoTHandler : IIoTHandler
    {
        public async Task RecieveMessage(DeviceClient deviceClient)
        {
            while (true)
            {
                var message = await deviceClient.ReceiveAsync();
                if (message == null) continue;
                var messageBody = message.GetBytes();
                var messagePayload = Encoding.ASCII.GetString(messageBody);
                //DO SOMETHING WITH MESSAGE
                await deviceClient.CompleteAsync(message);
            }
        }

        public async Task SendMessage(DeviceClient deviceClient, LockMessage lockMessage)
        {
            for (int i = 0; i < 5; i++)
            {
                var messagePayload = JsonConvert.SerializeObject(lockMessage);
                var message = new Message(Encoding.ASCII.GetBytes(messagePayload));
                await deviceClient.SendEventAsync(message);
            }
          
        }
    }
}
