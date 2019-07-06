﻿using System;
using ObserverPattern.New.Base;

namespace ObserverPattern.New.Notifiers
{
    public class PhoneNotifier : Observer
    {
        public PhoneNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);
        }

        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine(
                    string.Format($"Notify all subscribers via PHONE NUMBER with new data" +
                                    "\n\tName: {0}" +
                                    "\n\tDescription: {1}" +
                                    "\n\tFile name: {2}",
                                    videoData.GetTitle(),
                                    videoData.GetDescription(),
                                    videoData.GetFileName()));
            }
        }
    }
}