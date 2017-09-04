using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KRSServerApplication.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KRSServerApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    public class SchemeTypesController : Controller
    {
        KRSDataBaseContext db;
        public SchemeTypesController(KRSDataBaseContext context)
        {
            db = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<SchemeType> Get()
        {
            return db.SchemeType.ToList();
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            SchemeType schemeType = db.SchemeType.FirstOrDefault(x => x.IdSchemeType == id);
            if (schemeType == null)
                return NotFound();
            return new ObjectResult(schemeType);
        }


        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]SchemeType schemeType)
        {
            if (schemeType == null)
            {
                return BadRequest();
            }

            db.SchemeType.Add(schemeType);
            db.SaveChanges();
            return Ok(schemeType);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            SchemeType schemeType = db.SchemeType.FirstOrDefault(x => x.IdSchemeType == id);
            if (schemeType == null)
            {
                return NotFound();
            }
            db.SchemeType.Remove(schemeType);
            db.SaveChanges();
            return Ok(schemeType);
        }
    }
}
