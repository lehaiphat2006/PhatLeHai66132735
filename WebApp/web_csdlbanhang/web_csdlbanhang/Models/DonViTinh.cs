using System.ComponentModel.DataAnnotations;
//sua loi dong 76 DonViTinhsController.cs
using System.ComponentModel.DataAnnotations.Schema; // Nhớ có dòng using này


namespace web_csdlbanhang.Models
{
    [Table("DonViTinh")] // Bắt buộc EF tìm đúng tên bảng trong SQL

    public class DonViTinh
    {
        [Key]
        public byte MaDVT { get; set; }
        public string TenDVT { get; set; }

    }
}
