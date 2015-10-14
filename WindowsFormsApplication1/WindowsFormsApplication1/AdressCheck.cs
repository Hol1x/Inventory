using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace WindowsFormsApplication1
{
    class AdressCheck
    {
        private static System.Timers.Timer aTimer;
        public AdressCheck()
        {
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 2000;
        }
        public bool PingHost(string nameOrAddress)
        {

            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            return pingable;
        }
    
    }
}
