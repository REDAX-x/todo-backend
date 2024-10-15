
namespace todo_backend.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public bool Checked { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
