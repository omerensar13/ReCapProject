using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Transmission : IEntity
    {
        public int TransmissionId { get; set; }
        public string TransmissionName { get; set; }
    }
}
