using System;
using System.Collections.Generic;
using System.Text;

namespace WattsTools.Domain.Entity
{
    public class User
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual IList<Service> Products { get; set; }
    }
}
