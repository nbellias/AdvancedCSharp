// See https://aka.ms/new-console-template for more information
using Events;

Console.WriteLine("...Events...");

var video = new Video()
{
    Title = "Star Wars Andor"
};
var videoEncoder = new VideoEncoder(); //Publisher
var mailService = new MailService(); //Subscriber
var smsService = new SMSService(); //Subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += smsService.OnVideoEncoded;
videoEncoder.Encode(video);

Console.WriteLine("End program...");