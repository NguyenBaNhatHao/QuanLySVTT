using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLySVTT.Data;
using QuanLySVTT.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace QuanLySVTT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhvienController : ControllerBase
    {
        private readonly DataContext _context;
        public SinhvienController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Sinhvien>>> GetSinhvienDetail()
        {

            var resutl = await _context.tb_sinhvien.ToListAsync();
            return Ok(resutl);
        }
    }
}
