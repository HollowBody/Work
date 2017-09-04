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
    public class PalletsController : Controller
    {
        KRSDataBaseContext db;
        public PalletsController(KRSDataBaseContext context)
        {
            db = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Pallet> Get()
        {
            return db.Pallet.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pallet pallet = db.Pallet.FirstOrDefault(x => x.IdPallet == id);
            if (pallet == null)
                return NotFound();
            return new ObjectResult(pallet);
        }

        [HttpGet("{status}")]
        public IEnumerable<Pallet> GetWithStatus(string status)
        {
            var pallet = db.Pallet.Where(x => x.Status == status);
            return pallet.ToList();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Pallet pallet)
        {
            if (pallet == null)
            {
                return BadRequest();
            }

            db.Pallet.Add(pallet);
            db.SaveChanges();
            return Ok(pallet);
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]Pallet pallet)
        {
            if (pallet == null)
            {
                return BadRequest();
            }
            if (!db.Pallet.Any(x => x.IdPallet == pallet.IdPallet))
            {
                return NotFound();
            }

            db.Update(pallet);
            db.SaveChanges();
            return Ok(pallet);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Pallet pallet = db.Pallet.FirstOrDefault(x => x.IdPallet == id);
            if (pallet == null)
            {
                return NotFound();
            }
            db.Pallet.Remove(pallet);
            db.SaveChanges();
            return Ok(pallet);
        }
    }
}
