using Microsoft.AspNetCore.Mvc;

namespace Sayeed.Generic.OnionArchitecture.Controller
{
    public interface IBaseController<T> where T : class
    {
        Task<ActionResult<IEnumerable<T>>> GetAllAsync([FromQuery] int page = 1, [FromQuery] int pageSize = 10);
        Task<ActionResult<T>> GetById(int id);
        Task<ActionResult> Add([FromBody] T body);
        Task<ActionResult> UpdateById(int id, [FromBody] T body);
        Task<ActionResult> DeleteAsync(int id);
    }
}
