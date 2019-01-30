using System.Collections.Generic;
using Archysoft.D1.Model.Common;
using Archysoft.D1.Model.Repositories.Abstract;
using Archysoft.D1.Model.Services.Abstract;
using Archysoft.D1.Model.Users;

namespace Archysoft.D1.Model.Services.Concrete
{
    public class UsersService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UsersService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public SearchResult<UserGridModel> Get(BaseFilter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}
