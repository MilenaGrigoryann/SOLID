using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{

    public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending message");
        }
    }

    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending message");
        }
    }
}

