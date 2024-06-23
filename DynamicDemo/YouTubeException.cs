using System;

namespace dynamic
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message,Exception innerException)
            :base(message,innerException)
        {
            
        }
    }
}