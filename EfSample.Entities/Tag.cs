namespace EfSample.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
