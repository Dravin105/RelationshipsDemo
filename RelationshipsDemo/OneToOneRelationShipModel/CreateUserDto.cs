namespace RelationshipsDemo.OneToOneRelationShipModel
{
    public class CreateUserDto
    {
        public string UserName { get; set; }
        public CreateProfileDto Profiles { get; set; }
    }
}
