drop table employee;
create table employee(
	id int identity(1,1),
	name varchar(50),
	address varchar(50),
	phone_number int,
	email varchar(50)
);

insert into employee values
("Phan Van A", "HaNoi", 1111, "phamvana@gmail.com"),
("Phan Van B", "HaNoi", 1111, "phamvanb@gmail.com"),
("Phan Van C", "HaNoi", 1111, "phamvanc@gmail.com"),
("Phan Van D", "HaNoi", 1111, "phamvand@gmail.com"),
("Phan Van E", "HaNoi", 1111, "phamvane@gmail.com")
;
select count(*) from employee;

drop table project;
create table project(
	id int identity(1,1),
	name varchar(50),
	describe varchar(200),
	note varchar(200),
);
insert into project values
("Test 1", "Test 1", "Test 1"),
("Test 2", "Test 2", "Test 2"),
("Test 3", "Test 3", "Test 3"),
("Test 4", "Test 4", "Test 4")
;
select count(*) from project;

drop table job;
create table job(
	id int identity(1,1),
	id_employee int,
	id_project int,
	work_time int
);
insert into job values
(1, 1, 1),
(1, 1, 2),
(2, 2, 2),
(3, 3, 3),
(4, 1, 4),
(5, 5, 5)
;
select count(*) from job where id_project = 1;
select count(distinct id_employee) from job;
select sum(work_time) from job where id_employee = 1;
select min(id_employee) from job;
select id_employee, max(work_time) from job;
select id_project, sum(work_time) as "Tong so gio lam cua moi du an" from job group by id_project order by sum(work_time);
select id_project, avg(work_time) as "Tong so gio lam trung binh moi du an" from job group by id_project order by avg(work_time);
select id_employee, avg(work_time) as "Tong so gio lam trung binh moi nhan vien" from job group by id_employee order by avg(work_time);
select top(3) id_project, sum(work_time) as "3 du an gio lam cao nhat" from job group by id_project;
