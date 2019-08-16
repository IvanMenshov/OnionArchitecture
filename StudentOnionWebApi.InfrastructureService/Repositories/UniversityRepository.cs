using System;
using System.Collections.Generic;
using System.Linq;
using StudentOnionWebApi.Infrastructure.Interfaces;
using StudentOnionWebApi.Infrastructure.Models;
using StudentOnionWebApi.InfrastructureService.Context;

namespace StudentOnionWebApi.InfrastructureService.Repositories
{
    public class UniversityRepository : IUniversity
    {
        private readonly MyContext _context;

        public UniversityRepository(MyContext context)
        {
            _context = context;
        }

        public IList<University> GetAll()
        {
            return _context.Universities.ToList();
        }

        public University GetById(int id)
        {
            return _context.Universities.Find(id);
        }

        public void Create(int id, string name)
        {
            _context.Universities.Add(new University()
            {
                NameOfUniversity = name,
                Students = null
            });

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _context.Universities.Find(id);

            if (delete != null)
            {
                _context.Universities.Remove(delete);
                _context.SaveChanges();
            }
        }
    }
}
