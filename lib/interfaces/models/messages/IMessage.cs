using ms_rules_engine.crm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_rules_engine
{
    public interface IMessage<T> 
    {
        Guid CompanyId { get; set; }
        Guid BookId { get; set; }
        T Payload { get; set; }

    }
}
