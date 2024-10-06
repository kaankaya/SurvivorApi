namespace SurvivorApi.Entities
{
    public class CategoryEntity : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Competitor> Competitors { get; set; }
    }
}
