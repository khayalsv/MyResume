namespace ResumeApp.Data.Entities
{
    public class Portfolio : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Project { get; set; }
        public string Category { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
    }


}
