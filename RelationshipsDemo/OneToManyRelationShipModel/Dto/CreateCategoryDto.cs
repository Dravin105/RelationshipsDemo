namespace RelationshipsDemo.OneToManyRelationShipModel.Dto
{
    public class CreateCategoryDto
    {
        public string Name { get; set; }

        // Navigation property
        public ICollection<CreateProdectDto> Products { get; set; }
    }
}
