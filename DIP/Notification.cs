using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Notification
    {
        private IMessenger _iMessenger;
        public Notification(IMessenger pMessenger)
        {
            _iMessenger = pMessenger;
        }

        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
    }
}
