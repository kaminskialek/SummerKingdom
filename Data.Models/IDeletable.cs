namespace Data.Models
{
    public interface IDeletable
    {
        public DateTime? DeletedOn { get; set; } 
    }
}
