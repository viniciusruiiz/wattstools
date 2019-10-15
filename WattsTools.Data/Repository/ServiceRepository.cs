using NHibernate;
using System;
using System.Collections.Generic;
using WattsTools.Data.Configuration;
using WattsTools.Domain.Entity;
using WattsTools.Domain.Interface.Repository;

namespace WattsTools.Data.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        public Service Get(Guid id)
        {
            Service entity;

            using (ISession session = SessionFactory.OpenSession())
            {
                entity = session.Get<Service>(id);
            }

            return entity;
        }

        public IList<Service> GetAll()
        {
            IList<Service> entity;

            using (ISession session = SessionFactory.OpenSession())
            {
                entity = session.QueryOver<Service>().List();
            }

            return entity;
        }

        public Service Insert(Service service)
        {
            using (ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(service);

                transaction.Commit();
                transaction.Dispose();
            }

            return service;
        }

        public Service Update(Guid id, Service service)
        {
            using (ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(service);

                transaction.Commit();
                transaction.Dispose();
            }

            return service;
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

        public IList<Service> GetAllByCustomer(Guid customerId)
        {
            IList<Service> entity;

            using (ISession session = SessionFactory.OpenSession())
            {
                entity = session.QueryOver<Service>().JoinQueryOver<User>(x => x.Users).Where(x => x.Id == customerId).List();
            }

            return entity;
        }
    }
}
