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
    public class CostJournalsController : Controller
    {
        KRSDataBaseContext db;
        public CostJournalsController(KRSDataBaseContext context)
        {
            db = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<CostJournal> Get()
        {
            return db.CostJournal.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            CostJournal costJournal = db.CostJournal.FirstOrDefault(x => x.IdCost == id);
            if (costJournal == null)
                return NotFound();
            return new ObjectResult(costJournal);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]CostJournal costJournal)
        {
            if (costJournal == null)
            {
                return BadRequest();
            }

            db.CostJournal.Add(costJournal);
            db.SaveChanges();
            return Ok(costJournal);
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
            CostJournal costJournal = db.CostJournal.FirstOrDefault(x => x.IdCost == id);
            if (costJournal == null)
            {
                return NotFound();
            }
            db.CostJournal.Remove(costJournal);
            db.SaveChanges();
            return Ok(costJournal);
        }
    }
}
