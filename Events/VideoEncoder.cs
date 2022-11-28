using System;
namespace Events
{
	public class VideoEncoder
	{
		//OLD OPTION
		//a. Define a delegate, i.e., a contract between the publisher and the subscriber,
		//   which will be the event handler of the subscribers.
		//public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
		// b. Define an event based on that delegate. Use past tense.
		//public event VideoEncodedEventHandler VideoEncoded;

		//LATEST OPTION
		//a,b. Use the new EventHandler or EventHandler<TEventArgs> delegate directly.
		public event EventHandler<VideoEventArgs> VideoEncoded;

		//c. Raise or publish the event. It must be protected, and virtual, and its name
		//   should start with On.
		protected virtual void OnVideoEncoded(Video video)
		{
			//Notify subscribers
			if(VideoEncoded != null)
			{
				VideoEncoded(this, new VideoEventArgs() {
					Video = video
				});
			}
		}

		public void Encode(Video video)
		{
			Console.WriteLine($"Encoding video '{video.Title}'");
			Thread.Sleep(3000);

			OnVideoEncoded(video);

        }

		
	}
}

