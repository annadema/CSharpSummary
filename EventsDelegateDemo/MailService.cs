using System;

namespace EventsDelegate
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail Service: Sending an Email..."+e.Video.Title);
        }
    }
}