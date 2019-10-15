using NHibernate;
using System;
using System.Collections.Generic;
using WattsTools.Data.Configuration;
using WattsTools.Domain.Entity;
using WattsTools.Domain.Interface.Repository;

namespace WattsTools.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public User Get(Guid id)
        {
            User entity;

            using (ISession session = SessionFactory.OpenSession())
            {
                entity = session.Get<User>(id);
            }

            return entity;

            //return new User()
            //{
            //    Id = id,
            //    Email = "email@email.com",
            //    Name = "pessoa"
            //};
        }

        public IList<User> GetAll()
        {
            IList<User> entity;

            using (ISession session = SessionFactory.OpenSession())
            {
                entity = session.QueryOver<User>().List();
            }

            return entity;

            //return new List<User>
            //{
            //    new User()
            //    {
            //        Id = Guid.NewGuid(),
            //        Email = "email@email.com",
            //        Name = "pessoa"
            //    },
            //    new User()
            //    {
            //        Id = Guid.NewGuid(),
            //        Email = "email2@email.com",
            //        Name = "pessoa2"
            //    },
            //};
        }

        public User Insert(User user)
        {
            using (ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(user);

                transaction.Commit();
                transaction.Dispose();
            }

            return user;
        }

        public User Update(User user)
        {
            using (ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(user);

                transaction.Commit();
                transaction.Dispose();
            }

            return user;
        }

        public bool Delete(Guid id)
        {
            using (ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                var user = session.Get<User>(id);
                session.Delete(user);

                transaction.Commit();
                transaction.Dispose();
            }

            return true;
        }
    }
}
