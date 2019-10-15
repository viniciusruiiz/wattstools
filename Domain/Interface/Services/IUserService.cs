using System;
using System.Collections.Generic;
using System.Text;
using WattsTools.Domain.Entity;

namespace WattsTools.Domain.Interface.Services
{
    public interface IUserService
    {
        User Get(Guid id);

        IList<User> GetAll();

        User Insert(User user);

        User Update(Guid id, User user);

        void Delete(Guid id);
    }
}
