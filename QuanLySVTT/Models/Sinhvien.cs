using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace QuanLySVTT.Models
{
    public class Sinhvien
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string sv_id { get; set; }
        public string? sv_name { get; set; }
        public string? sv_ngaysinh { get; set; }
        public string? sv_nganh { get; set; }
        public string? sv_hedaotao { get; set; }
        public string? sv_ketqua { get; set; }
        public string? sv_hinhthuc { get; set; }
        public string? sv_tinhtrang { get; set; }
        public string? sv_email { get; set; }
        public string? img_name { get; set; }
        public DateTime? img_time { get; set; }
    }
}
