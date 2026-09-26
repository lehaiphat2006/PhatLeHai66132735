using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using web_csdlbanhang.Models;
using Microsoft.Data.SqlClient;

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
        public DbSet<DonViTinh> DonViTinhs { get; set; }
        public List<DonViTinh> DonViTinh_DS()
        {
            return DonViTinhs.FromSqlRaw("EXEC DonViTinh_DS").ToList();
        }
        public int DonViTinh_Them(DonViTinh dvt)
        {
            var cmd = Database.GetDbConnection().CreateCommand();
            cmd.CommandText = "DonViTinh_Them";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TenDVT", dvt.TenDVT));
            Database.OpenConnection();
            var kq=cmd.ExecuteNonQuery();
            Database.CloseConnection();
            return kq;

        }
        public int DonViTinh_Sua(DonViTinh dvt)
        {
            var cmd = Database.GetDbConnection().CreateCommand();
            cmd.CommandText = "DonViTinh_Sua";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaDVT", dvt.MaDVT));
            cmd.Parameters.Add(new SqlParameter("@TenDVT", dvt.TenDVT));
            Database.OpenConnection();
            var kq = cmd.ExecuteNonQuery();
            Database.CloseConnection();
            return kq;

        }

    }
}
