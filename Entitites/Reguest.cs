using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public  class Reguest : Base
    {
        [DisplayName("Dr.Name")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        [DisplayName("Ordered Service")]
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        [DisplayName("Patient's Emails")]
        public string? Email { get; set; }

        [DisplayName("Patient's Message")]
        public string Message { get; set; }

        [DisplayName("Patient Name")]
        public string Name { get; set; }

        public string? PhotoUrl { get; set; }

        [DisplayName("Ordered Time")]
        public DateTime ReguestTime { get; set; }
    }
}
