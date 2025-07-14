using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public sealed class User: BaseEntitie
    {
        public string? Email { get; set; }
        public string? Name { get; set; }
        
    }
}
