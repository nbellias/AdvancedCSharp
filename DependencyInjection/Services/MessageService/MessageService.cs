using System;
namespace DependencyInjection.Services.MessageService
{
    public class MessageService : IMessageService
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"Message Service: {message}");
        }
    }
}

