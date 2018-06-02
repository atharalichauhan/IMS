using System.Collections.Generic;

namespace IMS.Core.SharedKernel
{
    public class BaseViewModel
    {
        public int Id { get; set; }

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}
