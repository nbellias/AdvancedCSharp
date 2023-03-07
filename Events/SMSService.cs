using System;
namespace Events
{
	public class SMSService
	{
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"SMS Service: Sending SMS...{e.Video.Title}");
        }
    }
}

