using System;

namespace SoapyForum.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime UserCreatedAt { get; set; } = DateTime.Now;
    }
}