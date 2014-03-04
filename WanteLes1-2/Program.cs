using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WanteLes1_2
{
    class EmailProcessor
    {
        public delegate void EmailReceived(string email);
        public event EmailReceived EmailReceivedEvent;

        public void checkEmail()
        {
            while(true)
            {
                if(checkServer())
                {
                    EmailReceivedEvent("some email");
                }
                Thread.Sleep(5000);
            }
        }

        private bool checkServer()
        {
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            EmailProcessor emailProcessor = new EmailProcessor();
            emailProcessor.EmailReceivedEvent += emailProcessor_EmailReceivedEvent;
            emailProcessor.checkEmail();
        }

        static void emailProcessor_EmailReceivedEvent(string email)
        {
            Console.WriteLine("Email Received: {0}", email);
        }
    }
}
