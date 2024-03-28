-- create database lts;
drop table HocSinh;
drop table Lop;

use lts;
create table HocSinh(
	HocSinhID int identity(1,1) primary key,
	LopID int,
	HoTen varchar(50),
	GioiTinh varchar(50),
	NgaySinh date,
	DiaChi varchar(50),
	Email varchar(50)
);
select * from HocSinh
go

create table Lop(
	LopID int identity(1,1) primary key,
	TenLop varchar(50),
	SiSo int,
	GiaoVienChuNhiem varchar(50)
);
