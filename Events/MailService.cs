using System;
namespace Events
{
	public class MailService
	{
		public void OnVideoEncoded(object source, VideoEventArgs e)
		{
			Console.WriteLine($"Mail Service: Sending email...{e.Video.Title}");
		}
	}
}

