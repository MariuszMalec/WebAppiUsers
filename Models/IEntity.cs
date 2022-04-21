namespace WebAppiUsers.Models
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
