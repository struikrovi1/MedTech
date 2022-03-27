using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HeaderService
    {


        private readonly MedDBContext _context;

        public HeaderService(MedDBContext context)
        {
            _context = context;
        }


        public void Add(Header header)
        {
            _context.Add(header);
            _context.SaveChanges();
        }

        public void Update(Header header)
        {
            _context.Update(header);
            _context.SaveChanges();
        }
        public List<Header> GetAll()
        {
            return _context.Headers.ToList();
        }
        public Header? GetById(int id)
        {
            return _context.Headers.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Headers.Find(id);
            _context.Headers. Remove(selectedProduct);
            
            _context.SaveChanges();
        }

    }
}
