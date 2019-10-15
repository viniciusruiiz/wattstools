using System;
using System.Collections.Generic;
using System.Text;
using WattsTools.Domain.Entity;

namespace WattsTools.Domain.Interface.Services
{
    public interface IServiceService
    {
        Service Get(Guid id);

        IList<Service> GetAll();

        IList<Service> GetAllByCustomer(Guid customerId);

        Service Insert(Service service);

        Service Update(Guid id, Service service);

        void Delete(Guid id);
    }
}
