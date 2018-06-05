using System;

namespace IMS.Core.SharedKernel
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}
