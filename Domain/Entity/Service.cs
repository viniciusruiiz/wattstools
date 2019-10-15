using System;
using System.Collections.Generic;
using System.Text;

namespace WattsTools.Domain.Entity
{
    public class Service
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual IList<User> Users { get; set; }
    }
}
