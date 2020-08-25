using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transformator_API.Database;
using Transformator_API.Models;

namespace Transformator_API.Controllers
{
    [ApiController]
    public class TMController : ControllerBase
    {

        DBase _context = new DBase();
        [HttpGet]
        [Route("api/gettmlist")]
        public ActionResult GetTm()
        {
            var tm = from a in _context.TBL_TRANSFORMERS
                     select new
                     {
                         a.NAME,
      
                     };

            return Ok(tm);
        }
        [HttpGet]
        [Route("api/gettmlist/{id}")]
        public ActionResult GetSingleTm(int id)
        {
            var tm = _context.TBL_TRANSFORMERS.Find(id);
            if (tm == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPost]
        [Route("api/createtm")]
        public ActionResult CreateTm(Transformator transformator)
        {
            var tm = _context.TBL_TRANSFORMERS.Add(transformator);
            _context.SaveChanges();
            return Ok();
        }


        [HttpPut]
        [Route("api/edittm/{id}")]
        public ActionResult EditTm(int id ,Transformator transformator)
        {
            var tm = _context.TBL_TRANSFORMERS.Find(id);

            tm.NAME = transformator.NAME;

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        [Route("api/deletetm/{id}")]
        public ActionResult DeleteTm(int id)
        {
            var tm = _context.TBL_TRANSFORMERS.Find(id);
                     _context.TBL_TRANSFORMERS.Remove(tm);
                     _context.SaveChanges();


            return Ok();
        }
    }
}
