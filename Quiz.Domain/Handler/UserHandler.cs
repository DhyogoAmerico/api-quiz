using Quiz.Domain.Command.CommandUser;
using Quiz.Domain.ContractsCommand;
using Quiz.Domain.Entity;
using Quiz.Domain.Repository;

namespace Quiz.Domain.Handler
{
    public class UserHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CommandResult> Handle(CreateUserCommand command)
        {
            User user = command.ToUser();
            await _userRepository.Insert(user);

            return CommandResult.Send(true, true);
        }
    }
}