using Entitites;

namespace UIWeb.ViewModels
{
    public class HomeVM
    {

        public Header Header { get; set; }  

        public List<Service> Service { get; set; }  

        public List <Rating> Rating { get; set; }

        public Gear Gears { get; set; }

        public List<News> News { get; set; }

       public List<Reguest> Reguests { get; set;}

        public List<Team> Teams { get; set; }



    }
}
