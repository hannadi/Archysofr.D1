using System.Collections.Generic;
using Archysoft.D1.Data;
using Archysoft.D1.Data.Entities;
using Archysoft.D1.Model.Repositories.Abstract;

namespace Archysoft.D1.Model.Repositories.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public User Get(string email, string password)
        {
            return new User();
        }

        public List<User> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}
