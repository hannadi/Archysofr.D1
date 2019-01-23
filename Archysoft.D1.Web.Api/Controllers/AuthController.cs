using Archysoft.D1.Model.Auth;
using Archysoft.D1.Web.Api.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Archysoft.D1.Web.Api.Controllers
{
    public class AuthController: Controller
    {
        [HttpPost]
        [AllowAnonymous]
        [Route(Routes.Login)]
        public ApiResponse Login([FromBody] LoginModel model)
        {
            return null;
        }
    }
}
