namespace ResumeApp.Data.Entities
{
    public class Programming : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Percent { get; set; }
    }

}
