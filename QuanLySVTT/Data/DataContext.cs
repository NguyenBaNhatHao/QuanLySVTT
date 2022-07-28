using Microsoft.EntityFrameworkCore;
using QuanLySVTT.Models;
namespace QuanLySVTT.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Sinhvien> tb_sinhvien { get; set; }
    }
}
