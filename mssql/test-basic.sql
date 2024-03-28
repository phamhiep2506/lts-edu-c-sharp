use master
go

-- Delete database DatPhong
drop database DatPhong
go

-- Create database DatPhong
create database DatPhong
go

use DatPhong
go

-- Drop fk and pk
alter table phong
drop constraint pk_phong_id
go
alter table khach_hang
drop constraint pk_khach_hang_id
go
alter table dat_phong
drop constraint pk_dat_phong_id
go
alter table dich_vu_di_kem
drop constraint pk_dich_vu_id
go
alter table dat_phong
drop constraint fk_phong_id
go
alter table dat_phong
drop constraint fk_khach_hang_id
go
alter table chi_tiet_su_dung_dich_vu
drop constraint fk_dich_vu_id
go
alter table chi_tiet_su_dung_dich_vu
drop constraint fk_dat_phong_id
go

-- Drop table phong
drop table phong
go

-- Drop table khach_hang
drop table khach_hang
go

-- Drop table dat_phong
drop table dat_phong
go

-- Drop table dich_vu_di_kem
drop table dich_vu_di_kem
go

-- Drop table chi_tiet_su_dung_dich_vu
drop table chi_tiet_su_dung_dich_vu
go

-- Create table phong
create table phong(
	phong_id int,
	loai_phong varchar(200),
	so_khach_toi_da int,
	gia_phong money,
	mo_ta varchar(200),
	create_at datetime,
	update_at datetime,
	constraint pk_phong_id primary key (phong_id)
)
go

-- Create table khach_hang
create table khach_hang(
	khach_hang_id int,
	ten_khach_hang varchar(200),
	dia_chi varchar(200),
	so_dien_thoai int,
	create_at datetime,
	update_at datetime,
	constraint pk_khach_hang_id primary key (khach_hang_id)
)
go

-- Create table dat_phong
create table dat_phong(
	dat_phong_id int,
	phong_id int,
	khach_hang_id int,
	ngay_dat datetime,
	gio_bat_dau datetime,
	gio_ket_thuc datetime,
	tien_dat_coc money,
	ghi_chu varchar(200),
	trang_thai_dat bit,
	create_at datetime,
	update_at datetime,
	constraint pk_dat_phong_id primary key (dat_phong_id),
	constraint fk_phong_id foreign key (phong_id) references phong(phong_id),
	constraint fk_khach_hang_id foreign key (khach_hang_id) references khach_hang(khach_hang_id)
)
go

-- Create table dich_vu_di_kem
create table dich_vu_di_kem(
	dich_vu_id int,
	ten_dich_vu varchar(200),
	don_vi_tinh varchar(200),
	don_gia money,
	create_at datetime,
	update_at datetime,
	constraint pk_dich_vu_id primary key (dich_vu_id)
)
go

-- Create table chi_tiet_su_dung_dich_vu
create table chi_tiet_su_dung_dich_vu(
	dich_vu_id int,
	dat_phong_id int,
	so_luong int,
	create_at datetime,
	update_at datetime,
	constraint fk_dich_vu_id foreign key (dich_vu_id) references dich_vu_di_kem(dich_vu_id),
	constraint fk_dat_phong_id foreign key (dat_phong_id) references dat_phong(dat_phong_id)
)
go

-- Insert data phong
insert into phong(
	phong_id,
	loai_phong,
	so_khach_toi_da,
	gia_phong
)
values
	(1, 'Loai 1', 20, 60000),
	(2, 'Loai 1', 25, 80000),
	(3, 'Loai 2', 15, 50000),
	(4, 'Loai 3', 20, 50000)
go

-- Insert data khach_hang
insert into khach_hang(
	khach_hang_id,
	ten_khach_hang,
	dia_chi,
	so_dien_thoai
)
values
	(1, 'Nguyen Van A', 'Hoa xuan', 1111111111),
	(2, 'Nguyen Van B', 'Hoa hai', 1111111112),
	(3, 'Nguyen Van A', 'Cam le', 1111111113),
	(4, 'Nguyen Van B', 'Hoa xuan', 1111111114)
go

-- Insert data dich_vu_di_kem
insert into dich_vu_di_kem(
	dich_vu_id,
	ten_dich_vu,
	don_vi_tinh,
	don_gia
)
values
	(1, 'Beer', 'lon', 10000),
	(2, 'Nuoc ngot', 'lon', 8000),
	(3, 'Trai cay', 'dia', 35000),
	(4, 'Khan uot', 'cai', 2000)
go

-- Insert data dat_phong
insert into dat_phong(
	dat_phong_id,
	phong_id,
	khach_hang_id,
	ngay_dat,
	gio_bat_dau,
	gio_ket_thuc,
	tien_dat_coc,
	trang_thai_dat
)
values
	(1, 1, 2, '2018-03-26', '11:00', '13:30', 100000, 1),
	(2, 1, 3, '2018-03-27', '17:15', '19:15', 50000, 0),
	(3, 2, 2, '2018-03-26', '20:30', '22:15', 100000, 1),
	(4, 3, 1, '2018-04-01', '19:30', '21:15', 200000, 1),
	(5, 1, 2, NULL, NULL, NULL, 200000, 1)
go

-- Insert data chi_tiet_su_dung_dich_vu
insert into chi_tiet_su_dung_dich_vu(
	dat_phong_id,
	dich_vu_id,
	so_luong
)
values
	(1, 1, 20),
	(1, 3, 3),
	(1, 2, 10),
	(2, 2, 10),
	(2, 3, 1),
	(3, 3, 2),
	(3, 4, 10)
go

-- I
-- I.1. Liệt kê MaDatPhong, MaDV, SoLuong của tất cả các dịch vụ có số lượng lớn hơn 3 và nhỏ hơn 10.
select dat_phong_id, dich_vu_id, so_luong from chi_tiet_su_dung_dich_vu
where so_luong >= 3 and so_luong <= 10
go

-- I.2. Cập nhật dữ liệu trên trường GiaPhong thuộc bảng PHONG tăng lên 10,000 VNĐ so với giá phòng hiện tại, chỉ cập nhật giá phòng của những phòng có số khách tối đa lớn hơn 10
update phong
set gia_phong = gia_phong + 10000
where so_khach_toi_da > 10
go
--
select * from phong
go

-- I.3. Xóa tất cả những đơn đặt phòng (từ bảng DAT_PHONG) có trạng thái đặt (TrangThaiDat) là “Da huy”
delete from dat_phong
where trang_thai_dat = 0
go
-- Error: The DELETE statement conflicted with the REFERENCE constraint "fk_dat_phong_id". The conflict occurred in database "DatPhong", table "dbo.chi_tiet_su_dung_dich_vu", column 'dat_phong_id'.
-- select * from dat_phong
-- go

-- II.4. Hiển thị TenKH của những khách hàng có tên bắt đầu là một trong các ký tự “H”, “N”, “M” và có độ dài tối đa là 20 ký tự.
select ten_khach_hang from khach_hang
where ten_khach_hang like 'H%' or ten_khach_hang like 'N%' or ten_khach_hang like 'M%'
go

-- II .5 . Hiển thị TenKH của tất cả các khách hàng có trong hệ thống, TenKH nào trùng nhau thì chỉ hiển thị một lần. Sinh viên sử dụng hai cách khác nhau để thực hiện yêu cầu trên, mỗi cách sẽ được 0,5 điểm
select ten_khach_hang as 'Ten khach hang' from khach_hang
group by ten_khach_hang
go

-- II.6. Hiển thị MaDV, TenDV, DonViTinh, DonGia của những dịch vụ đi kèm có DonViTinh là “lon” và có DonGia lớn hơn 10,000 VNĐ hoặc những dịch vụ đi kèm có DonViTinh là “Cai” và có DonGia nhỏ hơn 5,000 VNĐ.
select dich_vu_id, ten_dich_vu, don_gia from dich_vu_di_kem
where
don_vi_tinh = 'lon' and don_gia > 10000
or
don_vi_tinh = 'cai' and don_gia < 5000
go

-- II.7.  Hiển thị MaDatPhong, MaPhong, LoaiPhong, SoKhachToiDa, GiaPhong, MaKH, TenKH, SoDT, NgayDat, GioBatDau, GioKetThuc, MaDichVu, SoLuong, DonGia của những đơn đặt phòng có năm đặt phòng là “2016”, “2017” và đặt những phòng có giá phòng > 50,000 VNĐ/ 1 giờ
select *
from dat_phong
inner join khach_hang on dat_phong.khach_hang_id = khach_hang.khach_hang_id
inner join phong on dat_phong.phong_id = phong.phong_id
inner join chi_tiet_su_dung_dich_vu on dat_phong.dat_phong_id = chi_tiet_su_dung_dich_vu.dat_phong_id
inner join dich_vu_di_kem on chi_tiet_su_dung_dich_vu.dich_vu_id = dich_vu_di_kem.dich_vu_id
where year(ngay_dat) = 2018 and gia_phong > 50000
go

-- III. 8. Hiển thị MaDatPhong, MaPhong, LoaiPhong, GiaPhong, TenKH, NgayDat, TongTienHat, TongTienSuDungDichVu, TongTienThanhToan tương ứng với từng mã đặt phòng có trong bảng DAT_PHONG. Những đơn đặt phòng nào không sử dụng dịch vụ đi kèm thì cũng liệt kê thông tin của đơn đặt phòng đó ra.
select
	dat_phong.dat_phong_id,
	dat_phong.phong_id,
	phong.loai_phong,
	phong.gia_phong,
	khach_hang.ten_khach_hang,
	dat_phong.ngay_dat,
	phong.gia_phong * datediff(hour, dat_phong.gio_bat_dau, dat_phong.gio_ket_thuc) as 'Tong tien dat',
	chi_tiet_su_dung_dich_vu.so_luong * dich_vu_di_kem.don_gia as 'Tong tien su dung dich vu',
	(phong.gia_phong * datediff(hour, dat_phong.gio_bat_dau, dat_phong.gio_ket_thuc)) + (chi_tiet_su_dung_dich_vu.so_luong * dich_vu_di_kem.don_gia) as 'Don gia tong tien thanh toan'
from dat_phong
inner join khach_hang on dat_phong.khach_hang_id = khach_hang.khach_hang_id
inner join phong on dat_phong.phong_id = phong.phong_id
inner join chi_tiet_su_dung_dich_vu on dat_phong.dat_phong_id = chi_tiet_su_dung_dich_vu.dat_phong_id
inner join dich_vu_di_kem on chi_tiet_su_dung_dich_vu.dich_vu_id = dich_vu_di_kem.dich_vu_id
go

-- III. 9. Hiển thị MaKH, TenKH, DiaChi, SoDT của những khách hàng đã từng đặt phòng karaoke có địa chỉ ở “Hoa xuan”
select
	khach_hang.ten_khach_hang,
	khach_hang.ten_khach_hang,
	khach_hang.dia_chi,
	khach_hang.so_dien_thoai
from khach_hang
inner join dat_phong on khach_hang.khach_hang_id = dat_phong.khach_hang_id
where khach_hang.dia_chi = 'Hoa xuan'

-- III. 10. Hiển thị MaPhong, LoaiPhong, SoKhachToiDa, GiaPhong, SoLanDat của những phòng được khách hàng đặt có số lần đặt lớn hơn 2 lần và trạng thái đặt là “Da dat”.
select
	dat_phong.phong_id,
	phong.loai_phong,
	phong.so_khach_toi_da,
	phong.gia_phong,
	count(dat_phong.phong_id) as 'So lan dat'
from dat_phong
inner join phong on dat_phong.phong_id = phong.phong_id
where dat_phong.trang_thai_dat = 1
group by dat_phong.phong_id, phong.loai_phong, phong.so_khach_toi_da, phong.gia_phong
having count(dat_phong.phong_id) > 1
