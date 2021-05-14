using ms_rules_engine.crm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine
{
    public class Message<T> : IMessage<T>
    {
        public Guid CompanyId { get; set; }
        public Guid BookId { get; set; }
        public T Payload { get; set; }
    }
}
