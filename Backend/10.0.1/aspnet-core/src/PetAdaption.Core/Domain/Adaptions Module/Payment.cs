using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace PetAdaption.Domain.Adaptions_Module
{
    public class Payment : FullAuditedEntity<Guid>
    {
        public Guid AdoptionRequestId { get; set; }
        public AdoptionRequest AdoptionRequest { get; set; }

        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } // e.g. "Stripe", "PayPal"
        public string TransactionId { get; set; }

        public DateTime PaidOn { get; set; }
        public string Status { get; set; }
    }
}
