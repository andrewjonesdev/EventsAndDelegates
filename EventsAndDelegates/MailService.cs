using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MailService
    {

        public void OnVideoEncoded(object source, EventArgs e) //3a
        {
            Console.WriteLine("MailService: Sending an email...");
        }

        public void OnVideoEncoded(object source, VideoEventArgs e) //3B
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }
}
