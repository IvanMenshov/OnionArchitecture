using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentOnionWebApi.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}