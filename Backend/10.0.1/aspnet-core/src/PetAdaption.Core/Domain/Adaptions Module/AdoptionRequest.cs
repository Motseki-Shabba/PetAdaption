using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Abp.Domain.Entities.Auditing;
using PetAdaption.Authorization.Users;
using PetAdaption.Domain.Pets_Module;

namespace PetAdaption.Domain.Adaptions_Module
{
    public class AdoptionRequest : FullAuditedEntity<Guid>
    {
        public Guid PetId { get; set; }
        public Pet Pet { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public string Reason { get; set; }
        public string IDProofUrl { get; set; }

        public string Status { get; set; } // e.g. "Pending", "Approved", "Rejected"
        public DateTime RequestDate { get; set; }
        public DateTime? DecisionDate { get; set; }

        public Payment Payment { get; set; }
    }
}
