using System;
using System.Collections.Generic;
using System.Text;
using WattsTools.Data.Repository;
using WattsTools.Domain.Entity;
using WattsTools.Domain.Interface.Repository;
using WattsTools.Domain.Interface.Services;

namespace WattsTools.Services.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository = null)
        {
            _serviceRepository = serviceRepository ?? new ServiceRepository();
        }

        public void Delete(Guid id)
        {
            _serviceRepository.Delete(id);
        }

        public Service Get(Guid id)
        {
            return _serviceRepository.Get(id);
        }

        public IList<Service> GetAll()
        {
            return _serviceRepository.GetAll();
        }

        public IList<Service> GetAllByCustomer(Guid customerId)
        {
            return _serviceRepository.GetAllByCustomer(customerId);
        }

        public Service Insert(Service service)
        {
            return _serviceRepository.Insert(service);
        }

        public Service Update(Guid id, Service service)
        {
            return _serviceRepository.Update(id, service);
        }
    }
}
