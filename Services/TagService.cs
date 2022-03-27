using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TagService
    {
        private readonly MedDBContext _context;

        public TagService(MedDBContext context)
        {
            _context = context;
        }

        public List<Tags> GetAll()
        {
            return _context.Tags.ToList();
        }
        public Tags? GetById(int id)
        {
            return _context.Tags.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Tags tags)
        {
            _context.Add(tags);
            _context.SaveChanges();
        }

        public void Update(Tags tags)
        {
            _context.Update(tags);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Tags.Find(id);
            _context.Tags.Remove(selectedProduct);

            _context.SaveChanges();
        }
    }
}

