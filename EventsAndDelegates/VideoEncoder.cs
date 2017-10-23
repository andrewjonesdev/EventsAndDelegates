using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1- Define a delegate agreement between publisher and subscriber
        // 2- Define an event based on that delegate
        // 3- Raise the event

        //public delegate void VideoEncodedEventHandler(object source, EventArgs args); //1a
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); //1b

        //EventHandler
        //EventHandler<TEventArgs>

        //public event VideoEncodedEventHandler VideoEncoded; //2a 2b

        public event EventHandler<VideoEventArgs> VideoEncoded; //2c
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            //OnVideoEncoded(); //3a
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded()//3a
        {
            if(VideoEncoded != null)
            {
                //VideoEncoded(this, EventArgs.Empty); //3a
            }
        }

        protected virtual void OnVideoEncoded(Video video)//3b
        {
            if (VideoEncoded != null)
            {

                VideoEncoded(this, new VideoEventArgs() { Video = video}); //3b
            }
        }

    }
    
}
