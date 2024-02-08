using Microsoft.AspNetCore.Mvc;
using Quiz.Domain.Command.CommandUser;
using Quiz.Domain.ContractsCommand;
using Quiz.Domain.Handler;

namespace Quiz.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class UserController
    {
        private  readonly UserHandler _userHandler;

        public UserController(UserHandler userHandler)
        {
            _userHandler = userHandler;
        }

        [HttpPost]
        public async Task<CommandResult> Insert([FromBody] CreateUserCommand createUserCommand)
        {
            return await _userHandler.Handle(createUserCommand);
        }
    }
}