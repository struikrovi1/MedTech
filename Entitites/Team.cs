using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Team : Base
    {


        [DisplayName("Doctor Main Photo")]
        public string PhotoUrl { get; set; }

        [DisplayName("Dr.Name")]
        public string Name { get; set; }

        [DisplayName("Lastame")]
        public string? LastName { get; set; }

        [DisplayName("Position")]
        public string Position { get; set; }

        [DisplayName(" Description")]
        public string Description { get; set; }

        [DisplayName("Article")]
        public string Article { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }
    }
}
