using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DAO.ENTITY
{
    [Table("KhachHang")]

    public class KhachHang
    {
        [Key]   // 👈 BẮT BUỘC
        public int KhachHangId { get; set; }

        public string TenKhach { get; set; }
        public string QuocTich { get; set; }
        public string CCCD { get; set; }
        public string Sdt { get; set; }
        public string? DiaChi { get; set; }

        // Đã thanh toán / Chưa thanh toán / Không xác định
        public string TrangThai { get; set; }

        public string? GhiChu { get; set; }

        public DateOnly? NgayVao { get; set; }
        public DateOnly? NgayRa { get; set; }
        public int? PhongId { get; set; }   // chỉ dùng khi Chưa thanh toán
        public Phong Phong { get; set; }
    }

}
