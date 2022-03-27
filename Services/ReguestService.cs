using DataAccess;
using Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ReguestService
    {

        private readonly MedDBContext _context;

        public ReguestService(MedDBContext context)
        {
            _context = context;
        }

        public List<Reguest> GetAll()
        {
            return _context.Reguests
                .Include(x => x.Team)
                .Include(x => x.Service)
                .ToList();
        }
        public Reguest? GetById(int id)
        {
            return _context.Reguests
                       .Include(x => x.Team)
                .Include(x => x.Service)
                .FirstOrDefault(c => c.Id == id);
        }

        public void Add(Reguest reguests)
        {
            _context.Add(reguests);
            _context.SaveChanges();
        }

        public void Update(Reguest reguests)
        {
            _context.Update(reguests);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Reguests.Find(id);
            _context.Reguests.Remove(selectedProduct);

            _context.SaveChanges();
        }
    }
}
