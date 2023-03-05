using System;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Navtest.Messages
{
    public class FinishLoadingMessage : ValueChangedMessage<string>
    {
        public FinishLoadingMessage(string value) : base(value)
        {
        }
    }
}

