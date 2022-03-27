using DataAccess;
using Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class TeamService
    {
        private readonly MedDBContext _context;

        public TeamService(MedDBContext context)
        {
            _context = context;
        }

        public void Add(Team team)
        {

            _context.Add(team);
            _context.SaveChanges();
        }

        public void Update(Team team)
        {

            _context.Update(team);
            _context.SaveChanges();
        }
        public List<Team> GetAll()
        {
            return _context.Teams.ToList();
        }
        public Team? GetById(int id)
        {
            return _context.Teams.FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int? id)
        {
            var selectedProduct = _context.Teams.Find(id);
            _context.Teams.Remove(selectedProduct);

            _context.SaveChanges();
        }
    }
}
