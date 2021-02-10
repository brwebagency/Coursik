using Microsoft.AspNetCore.Mvc;
using PPA_Core;
using PPA_DB;

namespace PPA_API.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : Controller {
        private ITokenServices _tokenServices;
        
        public TokenController(ITokenServices tokenServices) {
            _tokenServices = tokenServices;
        }

        [HttpGet]
        public IActionResult Token(User user) {
            return Ok(_tokenServices.Token(user));
        }
    }
}