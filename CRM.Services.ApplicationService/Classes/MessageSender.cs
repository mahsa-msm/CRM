using System;
using System.Collections.Generic;
using System.Text;

using Kavenegar;
namespace CRM.Services.ApplicationService.Classes
{
    public class MessageSender
    {
        public void SMS(string to , string text )
        {
            var sender = "1000596446";
            var receptor = to;
            var message = text;
            var api = new Kavenegar.KavenegarApi("4D4B78594251324C6932376436747164644A754435454463476B4962533752496B73394442714A534833453D");
            api.Send(sender, receptor, message);
        }
    }
}
