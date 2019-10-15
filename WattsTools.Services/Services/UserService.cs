using System;
using System.Collections.Generic;
using System.Text;
using WattsTools.Data.Repository;
using WattsTools.Domain.Entity;
using WattsTools.Domain.Interface.Repository;
using WattsTools.Domain.Interface.Services;

namespace WattsTools.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository = null)
        {
            _userRepository = userRepository ?? new UserRepository();
        }

        public void Delete(Guid id)
        {
            _userRepository.Delete(id);
        }

        public User Get(Guid id)
        {
            return _userRepository.Get(id);
        }

        public IList<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User Insert(User user)
        {
            return _userRepository.Insert(user);
        }

        public User Update(Guid id, User user)
        {
            return _userRepository.Update(user);
        }
    }
}
