create database SimTheCS

use SimTheCS

create table mang(
	id nvarchar(10) primary key,
	tenMang nvarchar(50)
)

create table sim(
	id nvarchar(10) primary key,
	soSim nvarchar(10),
	mangId nvarchar(10),
	ngayKichHoat Date,
	ngayHetHan Date,
	constraint fk_mangid foreign key (mangId) references mang(id)
)

insert into mang(id,tenMang) values 
('1','viettel'),
('2','vina')

insert into sim(id,soSim , mangId,ngayKichHoat,ngayHetHan) values 
('1','0123456789','1','2021-1-1','2023-1-1'),
('2','0123456788','2','2021-1-1','2022-1-1')

select * from sim

delete from sim where id = 7