using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCodeFirst.Models
{
    [Table("StudentDetails", Schema = "Guest")]
    public class SinhVienDetail
    {
        [Key]
        [ForeignKey("sv")]
        public int MaSV { get; set; }
        public string Info { get; set; }
        public virtual SinhVien sv { get; set; }
    }
}
