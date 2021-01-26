using System;

namespace NiboOfx.Shared
{
    public class Operation
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public DateTime PostedAt { get; set; }

        public double Amount { get; set; }

        public string Memo { get; set; }
    }
}