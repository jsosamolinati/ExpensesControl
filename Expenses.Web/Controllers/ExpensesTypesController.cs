using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Expenses.Data;
using Expenses.Entities.Expenses;
using Expenses.Web.Models.Expenses;

namespace Expenses.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesTypesController : ControllerBase
    {
        private readonly DbContextExpenses _context;

        public ExpensesTypesController(DbContextExpenses context)
        {
            _context = context;
        }

        // GET: api/ExpensesTypes/GetExpensesTypes
        [HttpGet("[action]")]
        public async Task<IEnumerable<ExpensesTypeViewModel>> GetExpensesTypes()
        {
            var ExpensesTypes = await _context.ExpensesTypes.ToListAsync();
            return ExpensesTypes.Select( c => new ExpensesTypeViewModel
            {
                conditionTypeExpenses = c.conditionTypeExpenses,
                descriptionTypeExpenses = c.descriptionTypeExpenses,
                idTypeExpenses = c.idTypeExpenses,
                nameTypeExpenses = c.nameTypeExpenses
            });
        }

        // GET: api/ExpensesTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExpensesType([FromRoute] int id)
        {

            var expensesType = await _context.ExpensesTypes.FindAsync(id);

            if (expensesType == null)
            {
                return NotFound();
            }

            return Ok(new ExpensesTypeViewModel
            {
                conditionTypeExpenses = expensesType.conditionTypeExpenses,
                descriptionTypeExpenses = expensesType.descriptionTypeExpenses,
                idTypeExpenses = expensesType.idTypeExpenses,
                nameTypeExpenses = expensesType.nameTypeExpenses
            });
        }

        // PUT: api/ExpensesTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpensesType([FromRoute] int id, [FromBody] ExpensesType expensesType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != expensesType.idTypeExpenses)
            {
                return BadRequest();
            }

            _context.Entry(expensesType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpensesTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ExpensesTypes
        [HttpPost]
        public async Task<IActionResult> PostExpensesType([FromBody] ExpensesType expensesType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ExpensesTypes.Add(expensesType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExpensesType", new { id = expensesType.idTypeExpenses }, expensesType);
        }

        // DELETE: api/ExpensesTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpensesType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var expensesType = await _context.ExpensesTypes.FindAsync(id);
            if (expensesType == null)
            {
                return NotFound();
            }

            _context.ExpensesTypes.Remove(expensesType);
            await _context.SaveChangesAsync();

            return Ok(expensesType);
        }

        private bool ExpensesTypeExists(int id)
        {
            return _context.ExpensesTypes.Any(e => e.idTypeExpenses == id);
        }
    }
}