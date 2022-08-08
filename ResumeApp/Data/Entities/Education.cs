namespace ResumeApp.Data.Entities
{
    public class Education : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
    }

}
