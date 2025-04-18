namespace RelationshipsDemo.OneToOneRelationShipModel
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        // Navigation property
        public Profiles Profiles { get; set; }
    }
}
