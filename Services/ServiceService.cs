using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceService
    {

        private readonly MedDBContext _context;

        public ServiceService(MedDBContext context)
        {
            _context = context;
        }

        public void Add(Service service)
        {
            _context.Add(service);
            _context.SaveChanges();
        }

        public void Update(Service service)
        {
            _context.Update(service);
            _context.SaveChanges();
        }
        public List<Service> GetAll()
        {
            return _context.Services.ToList();
        }
        public Service? GetById(int id)
        {
            return _context.Services.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int? id)
        {

            var selectedCourse = _context.Services.Find(id);

            _context.Services.Remove(selectedCourse);
            _context.SaveChanges();


        }
    }
}
