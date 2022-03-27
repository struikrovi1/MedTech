using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Gear : Base
    {
        [DisplayName("Offer Photo")]
        public string PhotoUrl { get; set; }

   
        public byte Discount { get; set; }

        [DisplayName("Offer Title")]
        public string TitleOne{ get; set; }

        [DisplayName("Offer color")]
        public string Color { get; set; }
    }
}
