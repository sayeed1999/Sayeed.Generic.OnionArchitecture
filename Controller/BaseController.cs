using Microsoft.AspNetCore.Mvc;
using Sayeed.Generic.OnionArchitecture.Logic;

namespace Sayeed.Generic.OnionArchitecture.Controller
{
    // abstract class won't create endpoints in swagger
    [Route("api/v1/[controller]")]
    [ApiController]
    public abstract class BaseController<T> : ControllerBase, IBaseController<T> where T : class
    {
        private IBaseService<T> baseService;

        public BaseController(IBaseService<T> baseService)
        {
            this.baseService = baseService;
        }

        // GET: api/<BaseController>
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<T>>> GetAllAsync([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var res = await baseService.GetAllAsync(page, pageSize);
            return Ok(res);
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<T>> GetById(int id)
        {
            var res = await baseService.FindByIdAsync(id);
            return Ok(res);
        }

        // POST api/<BaseController>
        [HttpPost]
        public virtual async Task<ActionResult> Add([FromBody] T body)
        {
            var res = await baseService.AddAsync(body);
            return Ok(res);
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> UpdateById(int id, [FromBody] T body)
        {
            var res = await baseService.UpdateByIdAsync(id, body);
            return Ok(res);
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> DeleteAsync(int id)
        {
            var res = await baseService.DeleteByIdAsync(id);
            return Ok(res);
        }
    }
}
