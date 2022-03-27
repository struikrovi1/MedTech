using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Service : Base
    {

        [DisplayName("Service Icon")]
        public  string IconUrl { get; set; }

        [DisplayName("Service Name")]
        public string ServiceName { get; set; }


        [DisplayName("Service Description")]
        public string ServDescription { get; set; }


    }
}
