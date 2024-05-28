namespace Data.Models
{
    public class Module
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public List<Adventure> Adventures { get; set; } = new List<Adventure>();

    }
}
