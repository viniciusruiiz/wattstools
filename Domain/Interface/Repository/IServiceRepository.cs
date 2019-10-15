using System;
using System.Collections.Generic;
using System.Text;
using WattsTools.Domain.Entity;

namespace WattsTools.Domain.Interface.Repository
{
    public interface IServiceRepository
    {
        Service Get(Guid id);

        IList<Service> GetAll();

        IList<Service> GetAllByCustomer(Guid customerId);

        Service Insert(Service service);

        Service Update(Guid id, Service service);

        bool Delete(Guid id);
    }
}
