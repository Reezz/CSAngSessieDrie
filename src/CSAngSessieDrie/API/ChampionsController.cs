using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using CSAngSessieDrie.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CSAngSessieDrie.API
{
    [Route("api/[controller]")]
    public class ChampionsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<LoLChampion> Get()
        {
            LoLChampionManager championManager = new LoLChampionManager();
            return championManager.GetAll;
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public LoLChampion Get(int id)
        {
            LoLChampionManager championManager = new LoLChampionManager();
            return championManager.GetChamionByID(id);
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
