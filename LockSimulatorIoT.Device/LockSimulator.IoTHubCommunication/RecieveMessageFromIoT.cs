using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSimulator.IoTHubCommunication
{
    public class RecieveMessageFromIoT
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
    }
}
