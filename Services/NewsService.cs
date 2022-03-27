using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class NewsService
    {

        private readonly MedDBContext _context;

        public NewsService(MedDBContext context)
        {
            _context = context;
        }

        public List<News> GetAll()
        {
            return _context.News.ToList();
        }
        public News? GetById(int id)
        {
            return _context.News.FirstOrDefault(c => c.Id == id);
        }

        public void Add(News news)
        {
            _context.Add(news);
            _context.SaveChanges();
        }

        public void Update(News news)
        {
            _context.Update(news);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.News.Find(id);
            _context.News.Remove(selectedProduct);

            _context.SaveChanges();
        }

    }
}
