﻿using System;

namespace HelloCI.Core
{
    public class Message
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public Message()
        {

        }

        public string GetFullMessage()
        {
            return Title + " :" + Body; 
        }
    }
}
