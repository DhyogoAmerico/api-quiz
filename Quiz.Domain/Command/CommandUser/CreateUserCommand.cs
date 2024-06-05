using Quiz.Domain.ContractsCommand;
using Quiz.Domain.Entity;
using Quiz.Domain.ValueType;

namespace Quiz.Domain.Command.CommandUser
{
    public class CreateUserCommand: ICommand
    {
        public CreateUserCommand(string? name, string? email, string? password, string? phone, DateTime date_birth)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            Date_birth = date_birth;
        }

        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public DateTime Date_birth { get; set; }

        public User ToUser(bool create = true)
        {
            return  new() {
                Name = this.Name,
                Email = this.Email,
                Password = new Password(this.Password ?? string.Empty).ToMD5(),
                Date_birth = this.Date_birth,
                Phone = this.Phone,
                Token = create ? Guid.NewGuid().ToString("N") : string.Empty
            };
        } 
    }
}