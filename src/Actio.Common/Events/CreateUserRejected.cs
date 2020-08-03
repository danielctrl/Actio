using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public class CreateActivityRejected : IRejectedEvent
    {
        public string Name { get; }

        public string Reason { get; }

        public string Code { get; }

        protected CreateActivityRejected()
        {
        }

        public CreateActivityRejected(string name, string reason, string code)
        {
            Name = name;
            Reason = reason;
            Code = code;
        }
    }
}
