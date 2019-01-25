using System.Collections.Generic;
using Archysoft.D1.Model.Services.Abstract;
using Archysoft.D1.Model.Users;
using Archysoft.D1.Web.Api.Model;
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

        [HttpGet]
        [Route(Routes.Users)]
        public ApiResponse<List<UserGridModel>> GetUsers()
        {
            List<UserGridModel> gridModels = _userService.Get();
            return new ApiResponse<List<UserGridModel>>(gridModels);
        }


    }
}
