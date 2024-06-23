using System;
using System.IO;

namespace dynamic
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var api=new YouTubeApi();
                var video = api.GetVideos("Mosh");
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
