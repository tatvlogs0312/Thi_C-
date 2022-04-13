create database DieuTraDS2

use dieuTraDS2

create table Nguoidung(
	Taikhoan nvarchar(50) primary key,
	Matkhau nvarchar(50)
)

insert into Nguoidung(Taikhoan,Matkhau) values ('tuan','0312')

select count(*) from Nguoidung where Taikhoan = 'tuan' and Matkhau = '0312'

create table CongDan(
	MaCD nvarchar(50) primary key,
	TenCD nvarchar(50),
	CMND nvarchar(50),
	GioiTinh nvarchar(50),
	NamSinh int,
	SoDienThoai nvarchar(10)
)

drop table CongDan

insert into CongDan(MaCD, TenCD, CMND, GioiTinh, NamSinh, SoDienThoai) values 
('1',N'Tuấn','1','nam','2002','0123456789'),
('2',N'Hiếu','2','nam','2002','0123456789'),
('3',N'Đạt','3','nam','2002','0123456789'),
('4',N'Minh','4','nam','2002','0123456789'),
('5',N'Dũng','1','nam','2002','0123456789'),
('6',N'Phương','2','nam','2002','0123456789'),
('7',N'Hải','2','nam','2002','0123456789')

select * from CongDan order by TenCD asc

select * from CongDan where CMND = '1'