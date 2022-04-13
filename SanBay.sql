create database SanBay

use SanBay

create table MayBay(
	MaMayBay nvarchar(50),
	TenMayBay nvarchar(50),
	NamSanXuat int,
	HangSanXuat nvarchar(50),
	KhuVucDo nvarchar(50)
)

insert into MayBay(MaMayBay,TenMayBay,NamSanXuat,HangSanXuat,KhuVucDo) values
('1','a30',2002,'VN','Khu a'),
('2','a31',2002,'VN','Khu b'),
('3','a32',2002,'VN','Khu b')

select * from MayBay where KhuVucDo = 'Khu b'

select * from MayBay where HangSanXuat = 'VN'