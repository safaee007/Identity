using Identity_SampleProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity_SampleProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        public AuthenticationController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<string> Register([FromBody] User model)
        {

            IdentityUser user = new IdentityUser
            {
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.UserName,
                Email = model.Email,
            };
            var result = await _userManager.CreateAsync(user);

            return "ok";
        }
    }
}
