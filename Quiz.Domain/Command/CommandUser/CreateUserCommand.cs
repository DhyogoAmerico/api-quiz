using Quiz.Domain.ContractsCommand;
using Quiz.Domain.Entity;

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

        public User ToUser(string? token = null)
        {
            return  new() {
                Name = this.Name,
                Email = this.Email,
                Password = this.Password,
                Date_birth = this.Date_birth,
                Phone = this.Phone,
                Token = token ?? string.Empty
            };
        } 
    }
}