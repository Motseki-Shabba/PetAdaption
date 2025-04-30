using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace PetAdaption.Domain.Pets_Module
{
    public class PetCategory : FullAuditedEntity<Guid>
    {

        public string Name { get; set; } // e.g. Dog, Cat, Bird
    }
}
