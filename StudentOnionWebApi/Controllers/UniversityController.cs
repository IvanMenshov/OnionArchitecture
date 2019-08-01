using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentOnionWebApi.Domain.Interfaces;
using StudentOnionWebApi.Mappers;
using StudentOnionWebApi.Models;

namespace StudentOnionWebApi.Controllers
{
    [RoutePrefix("university")]
    public class UniversityController : ApiController
    {
        private readonly IDomainUniversity _domainUniversity;

        public UniversityController(IDomainUniversity domainUniversity)
        {
            _domainUniversity = domainUniversity;
        }

        [HttpGet, Route("")]
        public IList<UniversityModel> GetAll()
        {
            var result = _domainUniversity.GetAll();

            return result.Select(_ => _.ToUniversityModel()).ToList();
        }

        [HttpGet, Route("{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            var result = _domainUniversity.GetById(id);

            return Ok(result.ToUniversityModel());
        }

        [HttpPost]
        public IHttpActionResult Create(int id, string name)
        {
            _domainUniversity.Create(id, name);

            return Ok(_domainUniversity.GetById(id));
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _domainUniversity.Delete(id);

            return NotFound();
        }
    }
}
