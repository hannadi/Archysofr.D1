using System.Collections.Generic;
using Archysoft.D1.Model.Users;

namespace Archysoft.D1.Model.Services.Abstract
{
    public interface IUserService
    {
        List<UserGridModel> Get();
    }
}
