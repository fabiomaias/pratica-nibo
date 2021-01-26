using System;
using System.Collections.Generic;

namespace NiboOfx.Shared
{
    public class History
    {
        public int Id { get; set; }

        public Account Account { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IList<Operation> Operations { get; set; }



        public void AddOperation(Operation operation)
        {
            if (Operations == null)
                Operations = new List<Operation>();
            Operations.Add(operation);
        }
    }
}
