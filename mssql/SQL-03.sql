use lts;

create table NhanVien(
	ID int identity(1,1);
	IDNhanVien int;
	HoTen varchar(50);
	DiaChi varchar(50);
	SoDienThoai int;
	Email varchar(50);
);

create table DuAn(
	ID int identity(1,1);
	IDDuAn int;
	TenDuAn varchar(50);
	MoTa varchar(50);
	GhiChu varchar(50);
);

create table CongViec(
	ID int identity(1,1);
	IDPhanCong int;
	IDNhanVien int;
	IDDuAn int;
	SoGioLam int;
);
