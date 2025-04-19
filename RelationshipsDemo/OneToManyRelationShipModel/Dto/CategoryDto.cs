namespace RelationshipsDemo.OneToManyRelationShipModel.Dto
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        // Navigation property
        public ICollection<ProductDto> Products { get; set; }
    }
}
