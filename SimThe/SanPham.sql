create database PMStore

use PMStore

create table SanPham(
	MaSanPham nvarchar(50) primary key,
	TenSanPham nvarchar(50),
	SoLuongTon int,
	NgaySanXuat date,
	NgayHetHan date,
	NhaCungCap nvarchar(50)
)

insert into SanPham(MaSanPham, TenSanPham, SoLuongTon, NgaySanXuat, NgayHetHan, NhaCungCap) values
('1','a',100,'2020-12-13','2022-12-13','a'),
('2','b',50,'2019-12-13','2021-12-13','b'),
('3','c',50,'2020-12-13','2022-12-13','b'),
('4','d',0,'2019-12-13','2022-12-13','a'),
('5','e',0,'2019-12-13','2021-12-13','a'),
('6','f',100,'2019-12-13','2021-12-13','b')

select * from SanPham where SoLuongTon = 0 or NgayHetHan < GETDATE()

select * from SanPham where NhaCungCap like '%a%'

select * from SanPham

delete from SanPham where SoLuongTon = 0 or NgayHetHan < GETDATE()