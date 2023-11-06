namespace seaside.api.Dtos
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Complete { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}