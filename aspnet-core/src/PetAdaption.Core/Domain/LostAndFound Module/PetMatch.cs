using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace PetAdaption.Domain.LostAndFound_Module
{
    public class PetMatch : FullAuditedEntity<Guid>
    {

        public Guid LostPetReportId { get; set; }
        public LostPetReport LostPet { get; set; }

        public Guid FoundPetReportId { get; set; }
        public FoundPetReport FoundPet { get; set; }

        public float MatchConfidence { get; set; } 
        public DateTime MatchedOn { get; set; } 
    }
}
