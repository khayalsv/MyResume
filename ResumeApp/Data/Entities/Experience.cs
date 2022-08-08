namespace ResumeApp.Data.Entities
{
    public class Experience : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
    }

}
