using LockSimulator.Device.Common;
using LockSimulator.IoTHubCommunication;
using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockSimulatorIoT
{
    public partial class homelockform : Form
    {
        private const string lockId = "frontdoorlock";
        private DeviceClient _deviceClient;
        private IIoTHandler _ioTHandler;
        private string DeviceHubConnectionString = ConfigurationManager.AppSettings["LockConnectionString"].ToString();
        public homelockform()
        {
            InitializeComponent();
             _ioTHandler = new IoTHandler();
            _deviceClient = DeviceClient.CreateFromConnectionString(DeviceHubConnectionString);
            Task recieveMessageTask = new Task(() => _ioTHandler.RecieveMessage(_deviceClient));
            recieveMessageTask.Start();
            //TODO :- ADD SEND TELEMETRY TASK
        }

        private async void lockBtn_Click(object sender, EventArgs e)
        {
            lockBtn.Enabled = false;
            unlockBtn.Enabled = true;
            LockMessage lockMessage = new LockMessage()
            {
                IsLocked = true,
                LockId = lockId,
                LockStatus = "Locked",
                ActivityTime = DateTime.UtcNow
            };
            await _ioTHandler.SendMessage(_deviceClient, lockMessage);
            lockpicturebox.ImageLocation = @"C:\Users\akumar7\Documents\Visual Studio 2019\Projects\IoT\LockSimulatorIoT.Device\LockSimulatorIoT\Images\lock.png";
        }

        private async void unlockBtn_Click(object sender, EventArgs e)
        {
            lockBtn.Enabled = true;
            unlockBtn.Enabled = false;
            LockMessage lockMessage = new LockMessage()
            {
                IsLocked = false,
                LockId = lockId,
                LockStatus = "Unlocked",
                ActivityTime = DateTime.UtcNow
            };
            await _ioTHandler.SendMessage(_deviceClient, lockMessage);
            lockpicturebox.ImageLocation = @"C:\Users\akumar7\Documents\Visual Studio 2019\Projects\IoT\LockSimulatorIoT.Device\LockSimulatorIoT\Images\unlock.png";
        }

        private void homelockform_Load(object sender, EventArgs e)
        {

        }
    }
}
