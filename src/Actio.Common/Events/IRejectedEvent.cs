using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public interface IRejectedEvent : IEvent
    {
        public string Reason { get; }

        public string Code { get; }
    }
}
