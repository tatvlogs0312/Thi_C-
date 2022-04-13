create database LopHoc

use LopHoc

create table lophoc(
	id nvarchar(50) primary key,
	ten nvarchar(50)
)

select * from lophoc

insert into lophoc(id,ten) values ('1',N'a')

delete from lophoc where id = ''

update lophoc set ten = 'a' where id = '1'