using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WatchApp.Core.ApplicationServices;
using WatchApp.Core.Entity;

namespace WatchAppRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchesController : ControllerBase
    {
        private readonly IWatchesServices _watchService;
        public WatchesController(IWatchesServices watchServices)
        {
            _watchService = watchServices;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Watches>> Get([FromQuery] Filter filter)
        {
            if (filter.CurrentPage <= 0 && filter.ItemsPerPage <= 0)
            {
                return Ok(_watchService.GetWatches());
            }
            return Ok(_watchService.GetFilteredWatches(filter));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Watches> Get(int id)
        {
            return _watchService.FindWatchesById(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Watches> Post([FromBody] Watches watches)
        {
            watches.Id = 0;
            if (string.IsNullOrEmpty(watches.ProductName))
            {
                return null;
            }
            return _watchService.AddWatch(watches);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
