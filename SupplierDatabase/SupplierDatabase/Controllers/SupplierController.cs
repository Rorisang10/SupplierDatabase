using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SupplierDatabase.Models; 
using System.Data.Entity;

public class SuppliersController : ApiController
{
    private readonly ApplicationDbContext _context;

    public SuppliersController()
    {
        _context = new ApplicationDbContext();
    }

    // Web API action to get all suppliers
    [HttpGet]
    public IHttpActionResult GetSuppliers()
    {
        var suppliers = _context.Suppliers.ToList();
        return Ok(suppliers);
    }

    public ApplicationDbContext Get_context()
    {
        return _context;
    }

    // Web API action to add a new supplier
    [HttpPost]
    public IHttpActionResult AddSupplier(Supplier supplier)
    {
        if (!ModelState.IsValid)
            return BadRequest("Invalid data.");

        _context.Suppliers.Add(supplier);
        _context.SaveChanges();

        return Ok();
    }

    // Web API action to search supplier by company name
    [HttpGet]
    [Route("api/suppliers/search")]
    public IHttpActionResult SearchSupplier(string company)
    {
        var supplier = _context.Suppliers.FirstOrDefault(s => s.Company == company);
        if (supplier == null)
            return NotFound();

        return Ok(supplier.Telephone);
    }

    protected override void Dispose(bool disposing)
    {
        _context.Dispose();
        base.Dispose(disposing);
    }
}
