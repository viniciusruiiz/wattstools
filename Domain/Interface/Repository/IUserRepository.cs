using System;
using System.Collections.Generic;
using System.Text;
using WattsTools.Domain.Entity;

namespace WattsTools.Domain.Interface.Repository
{
    public interface IUserRepository
    {
        User Get(Guid id);

        IList<User> GetAll();

        User Insert(User user);

        User Update(User user);

        bool Delete(Guid id);
    }
}
