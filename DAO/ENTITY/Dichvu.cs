using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DAO.ENTITY
{
    [Table("DichVu")]
    public class DichVu
    {
        [Key]   // 👈 BẮT BUỘC
        public int Id { get; set; }

        public string TenDichVu { get; set; }
        public decimal Gia { get; set; }
    }
}