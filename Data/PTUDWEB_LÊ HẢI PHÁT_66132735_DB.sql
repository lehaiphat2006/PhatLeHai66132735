create database CSDL_ban_hang_online
go
create table NhomSP(
MaNSP tinyint not null primary key,
TenNSP nVarchar(50) not null
);
CREATE TABLE LoaiSP (
    MaLSP tinyINT not null PRIMARY KEY,
    TenLSP NVARCHAR(50) not null,
	MaNSP  tinyint not null foreign key references NhomSP(MaNSP)
);
CREATE TABLE DonViTinh (
    MaDVT tinyINT not null PRIMARY KEY,
    TenDVT NVARCHAR(30) not null
);
CREATE TABLE SanPham (
    MaSP char(8) not null PRIMARY KEY,
    TenSP NVARCHAR(50) not null,
    MoTaTT NVARCHAR(100) not null,
	ThongTinCT ntext not null,
    DonGia Money not null,
    AnhMH NVARCHAR(255) null,
    MaLSP tinyINT not null,
    MaDVT tinyINT not null,
    FOREIGN KEY (MaLSP) REFERENCES LoaiSP(MaLSP),
    FOREIGN KEY (MaDVT) REFERENCES DonViTinh(MaDVT)
);
DROP TABLE SanPham
 DROP TABLE DonViTinh
 DROP TABLE LoaiSP
 DROP table NhomSP

 alter table SanPham
 alter column AnhMH NVARCHAR(50) null
 add 
 alter table LoaiSP
 add constraint fk_mansp foreign key (MaNSP) references NhomSP(MaNSP)

 ALTER DATABASE CSDL_ban_hang_online
 MODIFY NAME= PTUDWWEB_LÊHẢIPHÁT_66132735_DB;