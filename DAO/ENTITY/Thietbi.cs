using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DAO.ENTITY
{
    [Table("ThietBi")]
    public class ThietBi
    {
        [Key]   // 👈 BẮT BUỘC
        public int Id { get; set; }

        public string TenThietBi { get; set; }
        public decimal Gia { get; set; }
    }
}