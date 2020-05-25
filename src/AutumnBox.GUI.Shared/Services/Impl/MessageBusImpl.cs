﻿using AutumnBox.Leafx.Container.Support;
using AutumnBox.Logging;
using System;

namespace AutumnBox.GUI.Services.Impl
{
    [Component(Type = typeof(IMessageBus))]
    sealed class MessageBusImpl : IMessageBus
    {
        public event EventHandler<MessageReceivedEventArgs> MessageReceived;

        public void SendMessage(string msg_type, object value)
        {
            try
            {
                MessageReceived?.Invoke(this,
                    new MessageReceivedEventArgs(msg_type, value));
            }
            catch (Exception e)
            {
                SLogger<MessageBusImpl>.Warn($"An error occured when handling message : {msg_type}/{value}", e);
            }
        }
    }
}
