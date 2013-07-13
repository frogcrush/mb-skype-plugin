﻿using System;

namespace MusicBeePlugin.Events
{
    public class MessageEventArgs:EventArgs
    {
        public MessageEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
