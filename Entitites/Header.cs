using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Header : Base
    {

        [DisplayName("Header Main Photo")]
        public string PhotoUrl { get; set; }

        [DisplayName("Header Title")]
        public string MainTitle { get; set; }

        [DisplayName("Header Subheader")]
        public string SubHeader { get; set; }

        [DisplayName("Header Description")]
        public string Description{ get; set; }
      
    }
}
