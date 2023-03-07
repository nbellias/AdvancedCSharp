using System;
using DependencyInjection.Services.MessageService;

namespace DependencyInjection
{
    
    public class MyProcess
    {
        private readonly IMessageService _messageService;

        public MyProcess(IMessageService messageService)
        {
            _messageService = messageService;

            _messageService.WriteMessage("Hello World");
        }

    }
}

