namespace RelationshipsDemo.OneToManyRelationShipModel
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        // Foreign key
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; }
    }
}
