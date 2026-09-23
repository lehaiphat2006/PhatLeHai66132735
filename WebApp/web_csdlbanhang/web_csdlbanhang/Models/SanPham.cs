using System.ComponentModel.DataAnnotations;

namespace web_csdlbanhang.Models
{
    public class SanPham
    {
        [Key]
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string MoTaTT { get; set; }
        public string ThongTinCT { get; set; }
        public decimal DonGia { get; set; }
        public string AnhMH { get; set; }
        public int MaLSP { get; set; }
        public int MaDVT { get; set; }
        
    }
}
