using QuanLySVTT.Models;
using QuanLySVTT.Data;
namespace QuanLySVTT.Services.SinhvienService
{
    public interface ISinhvienService
    {
        List<Sinhvien> Sinhvienservices { get; set; }

        Task GetSinhvienDetail();
    }
}
