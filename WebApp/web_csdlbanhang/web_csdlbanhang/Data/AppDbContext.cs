using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using web_csdlbanhang.Models;

namespace web_csdlbanhang.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }
        //lập trình thao tác
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public List<LoaiSP> LoaiSP_DS()
        {
            return LoaiSPs.FromSqlRaw("EXEC LoaiSP_DS").ToList();
        }

    }
}
