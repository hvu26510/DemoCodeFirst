using System.ComponentModel.DataAnnotations;
namespace DemoCodeFirst.Models
{
    public class ChuyenNganh
    {
        [Key]
        public int idChuyenNganh { get; set; }
        public string TenNganh { get; set; }

        public ICollection<SinhVien> sinhViens { get; set; }
    }
}
