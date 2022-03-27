using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GearService
    {


        private readonly MedDBContext _context;

        public GearService(MedDBContext context)
        {
            _context = context;
        }

        public void Add(Gear gear)
        {

            _context.Add(gear);
            _context.SaveChanges();
        }

        public void Update(Gear gear)
        {

            _context.Update(gear);
            _context.SaveChanges();
        }
        public List<Gear> GetAll()
        {
            return _context.Gears.ToList();
        }
        public Gear GetById(int? id)
        {
            return _context.Gears.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Gears.Find(id);
            _context.Gears.Remove(selectedProduct);

            _context.SaveChanges();
        }
    }
}
