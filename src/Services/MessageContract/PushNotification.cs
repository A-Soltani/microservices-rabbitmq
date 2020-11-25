﻿using System;

namespace MessageContract
{
    public class PushNotification
    {
        public short NotificationFileType { get; set; }
        public string DestinationNumber { get; set; }
        public string PersianBody { get; set; }
        public string PersianTitle { get; set; }
        public string EnglishBody { get; set; }
        public string EnglishTitle { get; set; }
        public int UserId { get; set; }

    }
}
