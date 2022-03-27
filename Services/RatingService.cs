using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RatingService
    {

        private readonly MedDBContext _context;

        public RatingService(MedDBContext context)
        {
            _context = context;
        }

        public void Add(Rating rating)
        {
            
            _context.Add(rating);
            _context.SaveChanges();
        }

        public void Update(Rating rating)
        {

            _context.Update(rating);
            _context.SaveChanges();
        }
        public List<Rating> GetAll()
        {
            return _context.Ratings.ToList();
        }
        public Rating? GetById(int id)
        {
            return _context.Ratings.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Ratings.Find(id);
            _context.Ratings.Remove(selectedProduct);

            _context.SaveChanges();
        }
    }
}
