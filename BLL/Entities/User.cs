namespace BLL.Entities
{
    public class User : Entity
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public char? type { get; set; }
        public char gender { get; set; }
        public string ssn { get; set; }
    }

}
