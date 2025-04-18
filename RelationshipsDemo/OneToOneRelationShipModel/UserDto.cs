namespace RelationshipsDemo.OneToOneRelationShipModel
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public ProfileDto Profiles { get; set; }
    }
}
