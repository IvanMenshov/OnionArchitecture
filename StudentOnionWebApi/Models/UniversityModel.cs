using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentOnionWebApi.Models
{
    public class UniversityModel
    {
        public int UniversityId { get; set; }
        public string NameOfUniversity { get; set; }

        public IList<StudentModel> Students { get; set; }
    }
}