using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Abp.Domain.Entities.Auditing;
using PetAdaption.Authorization.Users;

namespace PetAdaption.Domain.LostAndFound_Module
{
    public class LostPetReport : FullAuditedEntity<Guid>
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string Breed { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public DateTime DateLost { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public ICollection<PetMatch> Matches { get; set; }
    }
   
}
