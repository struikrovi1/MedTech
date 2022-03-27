using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Rating : Base
    {


        [DisplayName("Author Photo")]
        public string AuthorPhoto { get; set; }



        [DisplayName("Background color")]
        public string Background { get; set; }


        [DisplayName("Author Name")]

        public string AuthorName { get; set; }


        [DisplayName("Author Comment")]

        public string Comment { get; set; } 


        public int ServiceId { get; set; }

        [DisplayName("Used service")]
        public virtual Service Service { get; set; }    

    }
}
