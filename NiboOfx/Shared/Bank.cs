using System;

namespace NiboOfx.Shared
{
    public class Bank
    {
        public int Id { get; set; }

        public int Agency { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
