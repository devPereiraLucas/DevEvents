﻿namespace DevEvents.API.Entities
{
    public class DevEventSpeaker
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String TalkTitle { get; set; }
        public String TalkDescription { get; set; }
        public String LinkedInProfile { get; set; }
    }
}