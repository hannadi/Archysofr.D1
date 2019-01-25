using Archysoft.D1.Model.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Archysoft.D1.Web.Api.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
    }
}
