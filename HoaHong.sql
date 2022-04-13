create database HoaHong2

use HoaHong2

create table LopHoc(
	MaLop nvarchar(50) primary key,
	TenLop nvarchar(50)
)

insert into LopHoc(MaLop, TenLop) values 
('1','a'),
('2','b')

CREATE TABLE BeNgoan(
	MaBN NVARCHAR(50) PRIMARY KEY,
	MaLop NVARCHAR(50) NOT NULL,	
	TenBeNgoan TEXT,
	NgaySinh DATE,
	GioiTinh NVARCHAR(5),
	HoTenBo NVARCHAR(100),
	HoTenMe NVARCHAR(100),
	DiaChi NVARCHAR(100),
	CONSTRAINT Fr_MaLop FOREIGN KEY (MaLop) REFERENCES LopHoc(MaLop) ON DELETE CASCADE,
)

insert into BeNgoan(MaBN, MaLop, TenBeNgoan, NgaySinh, GioiTinh, HoTenBo, HoTenMe, DiaChi) values 
('1','1',N'a','2002-02-02','nam',N'b',N'm',N'Hà Nội'),
('2','2',N'b','2002-02-02','nam',N'b',N'm',N'Hà Nội'),
('3','1',N'c','2002-02-02','nam',N'b',N'm',N'Hà Nội'),
('4','2',N'd','2002-02-02','nam',N'b',N'm',N'Hà Nội'),
('5','2',N'e','2002-02-02','nam',N'b',N'm',N'Hà Nội'),
('6','1',N'f','2002-02-02','nam',N'b',N'm',N'Hà Nội')


select * from BeNgoan , LopHoc where BeNgoan.MaLop = LopHoc.MaLop AND LopHoc.MaLop = '1'