namespace seaside.api.Entities
{
    public class Todo : BaseEntity
    {
        public string? Name { get; set; }
        public bool Complete { get; set; }
    }
}