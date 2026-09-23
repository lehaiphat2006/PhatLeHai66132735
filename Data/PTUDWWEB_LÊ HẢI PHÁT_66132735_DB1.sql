create database CSDL_ban_hang_online
go
create table NhomSP(
MaNSP int not null primary key,
TenNSP Varchar(100) not null
);
CREATE TABLE LoaiSP (
    MaLSP INT not null PRIMARY KEY,
    TenLSP NVARCHAR(100) not null
);
CREATE TABLE DonViTinh (
    MaDVT INT not null PRIMARY KEY,
    TenDVT NVARCHAR(50) not null
);
CREATE TABLE SanPham (
    MaSP INT not null PRIMARY KEY,
    TenSP NVARCHAR(100) not null,
    MoTaCT NVARCHAR(500) null,
    DonGia DECIMAL(18,2) not null,
    AnhDG VARCHAR(255) null,
    MaLSP INT not null,
    MaDVT INT not null,
    FOREIGN KEY (MaLSP) REFERENCES LoaiSP(MaLSP),
    FOREIGN KEY (MaDVT) REFERENCES DonViTinh(MaDVT)
);
DROP TABLE SanPham
 DROP TABLE DonViTinh
 DROP TABLE LoaiSP
 DROP table NhomSP

 alter table LoaiSP
 add MaNSP  int not null
 alter table LoaiSP
 add constraint fk_mansp foreign key (MaNSP) references NhomSP(MaNSP)