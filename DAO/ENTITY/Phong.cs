using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DAO.ENTITY
{
    [Table("Phong")]
    public class Phong
    {
        [Key]   // 👈 BẮT BUỘC
        public int PhongId { get; set; }

        public string LoaiPhong { get; set; }
        public string TenPhong { get; set; }
        public string TrangThai { get; set; }
        public decimal Gia { get; set; }
    }
}