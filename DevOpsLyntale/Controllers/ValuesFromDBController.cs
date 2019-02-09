using System.Collections.Generic;
using System.Linq;
using DevOpsLyntale.Models;
using DevOpsLyntale.Context;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsLyntale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesFromDBController : ControllerBase
    {
        private readonly DBContext _context;
        public ValuesFromDBController(DBContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get()
        {
            return _context.Items.ToList();
        }


        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id)
        {
            return _context.Items.Find(id);
        }
        
    }
}
