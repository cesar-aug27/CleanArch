using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controllers
{
    public class UserController : Controller
    {
        protected readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateUserResponse>> Create(CreateUserRequest createUserRequest,
                                                                        CancellationToken cancellationToken)
        {
            var responde = await mediator.SendAsync(createUserRequest, cancellationToken);
            return Ok(responde);
        }
    }
}
