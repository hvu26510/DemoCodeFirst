using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCodeFirst.Models
{
    [Table("Student", Schema = "Guest")]
    public class SinhVien
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Column("YearOfBirth")]
        public int NamSinh {  get; set; }

        [NotMapped]
        public int Tuoi { get { return (DateTime.Now.Year - NamSinh); } }

        public string Email {  get; set; }


        [ForeignKey("chuyenNganh")]
        public int idChuyenNganh {  get; set; }
        public virtual ChuyenNganh chuyenNganh { get; set; }


    }
}
