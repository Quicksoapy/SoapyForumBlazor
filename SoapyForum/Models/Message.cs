using System;

namespace SoapyForum.Models
{
    public class Message
    {
        public string Text { get; set; }
        public int UserId { get; set; }
        public DateTime MessageTime { get; set; } = DateTime.Now;
        public ulong MessageId { get; set; }
    }
}