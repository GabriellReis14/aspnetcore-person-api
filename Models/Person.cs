namespace aspnetcore_person_api.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
    }
}
