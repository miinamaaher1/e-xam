namespace BLL.Entities
{
    public class Track : Entity
    {
        public int id { get; set; }
        public string name { get; set; }
        public Department dept { get; set; }
    }
}
