﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentOnionWebApi.Domain.Models;

namespace StudentOnionWebApi.Domain.Interfaces
{
    public interface IDomainStudent
    {
        IList<DomainStudent> GetStudents();
    }
}
