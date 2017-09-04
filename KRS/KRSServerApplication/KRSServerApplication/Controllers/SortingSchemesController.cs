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
    public class SortingSchemesController : Controller
    {
        KRSDataBaseContext db;
        public SortingSchemesController(KRSDataBaseContext context)
        {
            db = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<SortingScheme> Get()
        {
            return db.SortingScheme.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            SortingScheme sortingScheme = db.SortingScheme.FirstOrDefault(x => x.IdScheme == id);
            if (sortingScheme == null)
                return NotFound();
            return new ObjectResult(sortingScheme);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
