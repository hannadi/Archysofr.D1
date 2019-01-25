using System.Collections.Generic;
using Archysoft.D1.Model.Repositories.Abstract;
using Archysoft.D1.Model.Services.Abstract;
using Archysoft.D1.Model.Users;

namespace Archysoft.D1.Model.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserGridModel> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}
