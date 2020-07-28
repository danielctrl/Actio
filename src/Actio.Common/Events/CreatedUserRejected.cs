using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public class CreatedUserRejected : IRejectedEvent
    {
        public string Email { get; set; }

        public string Reason { get; }

        public string Code { get; }

        protected CreatedUserRejected()
        {
        }

        public CreatedUserRejected(string email, string reason, string code)
        {
            Email = email;
            Reason = reason;
            Code = code;
        }
    }
}
