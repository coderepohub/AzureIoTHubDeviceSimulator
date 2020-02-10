using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSimulator.Device.Common
{
    public class LockMessage
    {
        public string LockName { get { return this.LockId; } }
        public string LockId { get; set; }
        public string LockStatus { get; set; }

        public DateTime ActivityTime { get; set; }

        public bool IsLocked { get; set; }
        public string MessageType { get { return "FromIoTHub"; } }
    }
}
