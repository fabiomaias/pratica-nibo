using System;

namespace NiboOfx.Shared
{
    public class Account
    {
        public int Id { get; set; }

        public Bank Bank { get; set; }

        public string AccountCode { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
