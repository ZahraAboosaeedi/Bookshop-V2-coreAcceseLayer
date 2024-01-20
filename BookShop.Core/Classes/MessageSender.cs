using System;
using System.Collections.Generic;
using System.Text;

using Kavenegar;

namespace BookShop.Core.Classes
{
    public class MessageSender
    {
        public void SMS(string to, string body)
        {
            var sender = "10004346";
            var receptor = to;
            var massage = body;
            var api = new KavenegarApi("71494B3036654D52664C7869524B7755743443725071596A70534154486346586A4C6564575441312B7A343D");

            api.Send(sender, receptor, massage);

        }
    }
}
