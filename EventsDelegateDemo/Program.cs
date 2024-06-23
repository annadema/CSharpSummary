using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video=new Video() {Title = "Video 1"};
            var videoEncoder=new VideoEncoder(); //publisher, autore. Oggetto che scatena l'evento

            var mailService=new MailService();//subscriber, sottoscrittore. Oggetto vuole essere avvisato quando si verifica l'evento

            var messageService=new MessageService(); //another subscriber
        
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
