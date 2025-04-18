using System.ComponentModel.DataAnnotations;

namespace RelationshipsDemo.OneToOneRelationShipModel
{
        public class Profiles
        {
        [Key]
            public int ProfileId { get; set; }
            public string Bio { get; set; }

            // Foreign key
            public int UserId { get; set; }

            // Navigation property
            public User User { get; set; }
        }
    
}
