using System.ComponentModel.DataAnnotations;

namespace web_csdlbanhang.Models
{
    public class LoaiSP
    {
        [Key]
        public int MaLSP { get; set; }
        public string TenLSP { get; set; }
        public int MaNSP { get; set; }


    }
}
