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
    public class BatchesController : Controller
    {
        KRSDataBaseContext db;
        public BatchesController(KRSDataBaseContext context)
        {
            db = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Batch> Get()
        {
            return db.Batch.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Batch batch = db.Batch.FirstOrDefault(x => x.IdBatch == id);
            if (batch == null)
                return NotFound();
            return new ObjectResult(batch);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Batch batch)
        {
            if (batch == null)
            {
                return BadRequest();
            }

            db.Batch.Add(batch);
            db.SaveChanges();
            return Ok(batch);
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]Batch batch)
        {
            if (batch == null)
            {
                return BadRequest();
            }
            if (!db.Batch.Any(x => x.IdBatch == batch.IdBatch))
            {
                return NotFound();
            }

            db.Update(batch);
            db.SaveChanges();
            return Ok(batch);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Batch batch = db.Batch.FirstOrDefault(x => x.IdBatch == id);
            if (batch == null)
            {
                return NotFound();
            }
            db.Batch.Remove(batch);
            db.SaveChanges();
            return Ok(batch);
        }

        [HttpGet("{batchID}")]
        public IQueryable GetBatchOpeningDate(int batchID)
        {
            var OpeningDate = db.Batch.Where(b => b.IdBatch == batchID)
                .Select(b => b.OpeningDate);
            return OpeningDate;
        }

        [HttpGet("{batchID}")]
        public IQueryable GetBatchDebitCount(int batchID)
        {
            var DebitCount = db.Batch.Where(b => b.IdBatch == batchID)
                .Select(b => b.DebitCount);
            return DebitCount;
        }

        [HttpGet("{batchID}")]
        public IQueryable GetBatchProviderID(int batchID)
        {
            var ProviderId = db.Batch.Where(b => b.IdBatch == batchID)
                .Select(b => b.IdProvider);
            return ProviderId;
        }
    }
}
