using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CountService
    {

        private readonly MedDBContext _context;

        public CountService(MedDBContext context)
        {
            _context = context;
        }


        public void Add(Countdown count)
        {
            _context.Add(count);
            _context.SaveChanges();
        }

        public void Update(Countdown count)
        {
            _context.Update(count);
            _context.SaveChanges();
        }
        public List<Countdown> GetAll()
        {
            return _context.Countdowns.ToList();
        }
        public Countdown? GetById(int id)
        {
            return _context.Countdowns.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int? id)
        {

            var selectedCourse = _context.Countdowns.Find(id);

            _context.Countdowns.Remove(selectedCourse);
            _context.SaveChanges();


        }


    }
}
