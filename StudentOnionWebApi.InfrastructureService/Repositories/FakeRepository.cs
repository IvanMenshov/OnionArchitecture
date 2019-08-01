using System.Collections.Generic;
using System.Linq;
using StudentOnionWebApi.Infrastructure.Interfaces;
using StudentOnionWebApi.Infrastructure.Models;

namespace StudentOnionWebApi.InfrastructureService.Repositories
{
    public class FakeRepository : IUniversity
    {
        public static List<University> db = new List<University>()
        {
            new University
            {
                UniversityId = 1,
                NameOfUniversity = "BNTU",
                Students = new List<Student>
                {
                    new Student()
                    {
                        StudentId = 1,
                        Name = "Ivan",
                        Surname = "Menshov"
                    },

                    new Student()
                    {
                        StudentId = 2,
                        Name = "Maxim",
                        Surname = "Masuk"
                    },

                    new Student()
                    {
                        StudentId = 3,
                        Name = "Vlad",
                        Surname = "Mihasev"
                    }
                }
            },

            new University
            {
                UniversityId = 2,
                NameOfUniversity = "BSU",
                Students = new List<Student>
                {
                    new Student()
                    {
                        StudentId = 4,
                        Name = "Maxim",
                        Surname = "Ivanov"
                    },

                    new Student()
                    {
                        StudentId = 5,
                        Name = "Kate",
                        Surname = "Korobochkina"
                    }
                }
            }
        };

        public IList<University> GetAll()
        {
            return db;
        }

        public University GetById(int id)
        {
            return db.FirstOrDefault(_ => _.UniversityId == id);
        }

        public void Create(int id, string name)
        {
            db.Add(new University
            {
                UniversityId = id,
                NameOfUniversity = name,
                Students = null
            });
        }

        public void CreateStudent(int? universityId, int studentId, string name, string surname)
        {
            int result = db.FindIndex(_ => _.UniversityId == universityId);

            if (result != 0)
            {
                db[result].Students.Add(new Student()
                {
                    StudentId = studentId,
                    Name = name,
                    Surname = surname
                });
            }
        }

        public void Delete(int id)
        {
            db = db.Where(_ => _.UniversityId != id).ToList();
        }
    }
}
