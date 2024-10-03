using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp
{
    public class Notification
    {
        // Определение событий
        public event Action<string>? OnMessageSent;
        public event Action<string>? OnCallReceived;
        public event Action<string>? OnEmailSent;

        public void SendMessage(string message)
        {
            OnMessageSent?.Invoke(message);
        }

        public void ReceiveCall(string caller)
        {
            OnCallReceived?.Invoke(caller);
        }


        public void SendEmail(string email)
        {
            OnEmailSent?.Invoke(email);
        }
    }
}
