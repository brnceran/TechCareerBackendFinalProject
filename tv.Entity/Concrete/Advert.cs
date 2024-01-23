using tv.Core.Entity.Abstract;

namespace tv.Entity.Concrete
{
    public class Advert : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        public int OwnerId { get; set; }
    }
}
