using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MessageService
    {

        public void OnVideoEncoded(object source, EventArgs e) //3a
        {
            Console.WriteLine("MessageService: Sending a text message...");
        }

        public void OnVideoEncoded(object source, VideoEventArgs e) //3b
        {
            Console.WriteLine("MessageService: Sending a text message..." + e.Video.Title);
        }
    }
}
