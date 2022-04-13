create database NguoiDung

use NguoiDung

create table nguoiDung(
	TaiKhoan nvarchar(50),
	MatKhau nvarchar(50),
	quyenAdmin nvarchar(50)
)

insert into nguoiDung(TaiKhoan,MatKhau,quyenAdmin) values ('abc123','abc123','x'),('def456','def456',' ')

select * from nguoiDung

select count(*) from Nguoidung where Taikhoan = 'abc123' and Matkhau = 'abc123' and quyenAdmin = 'x'