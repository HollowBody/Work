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
    public class SkinTypesController : Controller
    {
        KRSDataBaseContext db;
        public SkinTypesController(KRSDataBaseContext context)
        {
            db = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<SkinType> Get()
        {
            return db.SkinType.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            SkinType skinType = db.SkinType.FirstOrDefault(x => x.IdTypeSkin == id);
            if (skinType == null)
                return NotFound();
            return new ObjectResult(skinType);
        }


        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]SkinType skinType)
        {
            if (skinType == null)
            {
                return BadRequest();
            }

            db.SkinType.Add(skinType);
            db.SaveChanges();
            return Ok(skinType);
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
            SkinType skinType = db.SkinType.FirstOrDefault(x => x.IdTypeSkin == id);
            if (skinType == null)
            {
                return NotFound();
            }
            db.SkinType.Remove(skinType);
            db.SaveChanges();
            return Ok(skinType);
        }
    }
}
