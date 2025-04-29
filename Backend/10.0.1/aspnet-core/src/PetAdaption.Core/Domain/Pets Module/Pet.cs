using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace PetAdaption.Domain.Pets_Module
{
    public class Pet : FullAuditedEntity<Guid>
    {
       
            public string Name { get; set; }
            public int Age { get; set; } // in months
            public string Breed { get; set; }
            public string Description { get; set; }
            public string HealthStatus { get; set; }
            public string VaccinationInfo { get; set; }
            public decimal Price { get; set; }

            public Guid CategoryId { get; set; }
            public PetCategory Category { get; set; }

            public string ImageUrl { get; set; }
            public bool IsAdopted { get; set; }
    }
    
}
