using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOnionWebApi.Domain.Interfaces;
using StudentOnionWebApi.Domain.Models;
using StudentOnionWebApi.DomainService.Mappers;
using StudentOnionWebApi.Infrastructure.Interfaces;

namespace StudentOnionWebApi.DomainService.Service
{
    public class UniversitiesService : IDomainUniversity
    {
        private readonly IUniversity _university;

        public UniversitiesService(IUniversity university)
        {
            _university = university;
        }

        public IList<DomainUniversity> GetAll()
        {
            var result = _university.GetAll();

            return result.Select(_ => _.ToDomainUniversity()).ToList();
        }

        public DomainUniversity GetById(int id)
        {
            var result = _university.GetById(id);

            return result.ToDomainUniversity();
        }

        public void Create(int id, string name)
        {
            _university.Create(id, name);
        }

        public void CreateStudent(int? domainUniversityId, int domainStudentId, string name, string surname)
        {
            _university.CreateStudent(domainUniversityId, domainStudentId, name, surname);
        }

        public void Delete(int id)
        {
            _university.Delete(id);
        }
    }
}
