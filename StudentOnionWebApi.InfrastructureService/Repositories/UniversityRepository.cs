using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var universitities = _context.Universities;

            foreach (var university in universitities)
            {
                if (university != null && university.UniversityId == id)
                {
                    return university;
                }
            }

            return default(University);
        }

        public void Create(int id, string name)
        {
            _context.Universities.Add(new University()
            {
                UniversityId = id,
                NameOfUniversity = name,
                Students = null
            });

            _context.SaveChanges();
        }

        public void CreateStudent(int? universityId, int studentId, string name, string surname)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _context.Universities.Remove(_context.Universities.FirstOrDefault(_ => _.UniversityId == id));
            _context.SaveChanges();
        }
    }
}
