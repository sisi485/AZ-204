using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmosEF;
using Microsoft.AspNetCore.Mvc;

namespace FoodApiCosmos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private FoodCosmosDbContext foodctx;

        public FoodController(FoodCosmosDbContext ctx)
        {
            foodctx = ctx;
        }

        public ActionResult<IEnumerable<FoodItem>> GetTModels()
        {
            return foodctx.FoodItems;
        }

        // [HttpGet("{id}")]
        // public ActionResult<TModel> GetTModelById(int id)
        // {
        //     return null;
        // }

        // [HttpPost("")]
        // public ActionResult<TModel> PostTModel(TModel model)
        // {
        //     return null;
        // }

        // [HttpPut("{id}")]
        // public IActionResult PutTModel(int id, TModel model)
        // {
        //     return NoContent();
        // }

        // [HttpDelete("{id}")]
        // public ActionResult<TModel> DeleteTModelById(int id)
        // {
        //     return null;
        // }
    }
}