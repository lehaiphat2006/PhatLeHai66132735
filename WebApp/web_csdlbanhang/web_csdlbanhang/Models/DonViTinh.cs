using System.ComponentModel.DataAnnotations;

namespace web_csdlbanhang.Models
{
    public class DonViTinh
    {
        [Key]
        public byte MaDVT { get; set; }
        public string TenDVT { get; set; }

    }
}
