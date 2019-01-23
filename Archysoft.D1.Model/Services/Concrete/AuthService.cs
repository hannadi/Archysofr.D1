using Archysoft.D1.Data.Entities;
using Archysoft.D1.Model.Auth;
using Archysoft.D1.Model.Exceptions;
using Archysoft.D1.Model.Repositories.Abstract;
using Archysoft.D1.Model.Services.Abstract;

namespace Archysoft.D1.Model.Services.Concrete
{
    public class AuthService: IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public TokenModel Login(LoginModel model)
        {
            var user = _userRepository.Get(model.Login, model.Password);
            if (user == null)
            {
                throw new BusinessException("Invalid User");
            }

            return GenerateToken(user);
        }

        private TokenModel GenerateToken(User user)
        {
            return new TokenModel();
        }
    }
}
