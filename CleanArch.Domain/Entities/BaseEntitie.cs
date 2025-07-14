using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public abstract class BaseEntitie

    {
        public Guid Id { get; set; }
        public DataSetDateTime DataCreated { get; set; }
        public DataSetDateTime? DataUpdate {get;set;}
        public DataSetDateTime? DataDelete { get; set; }
    }
}
