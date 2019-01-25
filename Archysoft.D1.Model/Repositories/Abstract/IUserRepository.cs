using System.Collections.Generic;
using Archysoft.D1.Data.Entities;

namespace Archysoft.D1.Model.Repositories.Abstract
{
    public interface IUserRepository
    {
        User Get(string email, string password);
        List<User> Get();
    }
}
