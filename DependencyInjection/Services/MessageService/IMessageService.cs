using System;
namespace DependencyInjection.Services.MessageService
{
    public interface IMessageService
    {
        public void WriteMessage(string message);
    }
}

