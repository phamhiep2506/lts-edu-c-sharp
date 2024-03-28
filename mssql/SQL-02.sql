use lts;

/* table HocSinh */
create table HocSinh(
	HocSinhID int identity(1,1),
	LopID int,
	HoTen varchar(50),
	GioiTinh bit,
	NgaySinh date,
	DiaChi varchar(50),
	Email varchar(50)
);

insert into HocSinh(LopID, HoTen, GioiTinh, NgaySinh, DiaChi, Email)
values
(1, "Pham Van A", 1, "2005-01-01", "ThaiBinh", "phamvana@gmail.com"),
(2, "Pham Van B", 1, "2000-02-02", "CaoBang", "phamvanb@gmail.com"),
(3, "BNam Van C", 1, "2000-03-03", "NinhBinh", "phamvanc@gmail.com"),
(4, "Cham Van D", 1, "2000-04-04", "ThanhHoa", "phamvand@gmail.com"),
(5, "Pham Van E", 1, "2005-06-05", "HaNam", NULL),
(5, "Tran Van F", 1, "2000-06-06", "HaGiang", "phamvanf@gmail.com"),
(7, "Tran Van I", 1, "2000-07-07", "NamDinh", "phamvani@gmail.com"),
(7, "Pham Thi A", 0, "2000-08-08", "HaNoi", "phamthia@gmail.com")
;

select * from HocSinh;

select * from HocSinh where HoTen like "T%";
select * from HocSinh where HoTen like "%I";
select * from HocSinh where HoTen like "_N%";
select * from HocSinh where HoTen like "%Thi%";
select * from HocSinh where HoTen like "[a-m]%";
select * from HocSinh where DiaChi="HaNoi" and GioiTinh=0;
select * from HocSinh where NgaySinh between "2005-01-01" and "2005-06-05";
select * from HocSinh where DiaChi = "HaNoi" or DiaChi = "ThaiBinh" or DiaChi = "CaoBang";

/* Table Lop */
create table Lop(
	id int identity(1,1),
	LopID int,
	TenLop varchar(50),
	SiSo int,
	GiaoVienChuNhiem varchar(50)
);

insert into Lop
values
("a", 40, "Pham Thi Quynh"),
("b", 31, "Quynh Thi A"),
("c", 10, "Pham Thi B")
;

select SiSo, GiaoVienChuNhiem from Lop where SiSo > 30 and GiaoVienChuNhiem like "%Quynh%";
select LopID, GioiTinh, DiaChi from HocSinh where DiaChi = "HaGiang" and GioiTinh = 1 and LopID = 5;
select HoTen from HocSinh where Email is null;
select * from HocSinh where year(NgaySinh) <> 2005;
select * from HocSinh where HoTen like '%[^a-zA-Z]%';
select * from HocSinh order by HocSinhID desc;
select * from HocSinh order by LopID desc, day(NgaySinh);
