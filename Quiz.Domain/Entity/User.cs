using Quiz.Domain.ValueType;

namespace Quiz.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Password? Password { get; set; }
        public string? Phone { get; set; }
        public DateTime Date_birth { get; set; }
        public string? Token { get; set; }
    }
}