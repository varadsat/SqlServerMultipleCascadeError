
namespace SqlServerMultipleCascade.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public ICollection<Entity> ChildEntities { get; set; } = new HashSet<Entity>();
        public int? ParentEntityId { get; set; }
        public Entity? ParentEntity { get; set; }

    }
}
