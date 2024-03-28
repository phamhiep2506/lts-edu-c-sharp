﻿drop database DonDatHang
go

create database DonDatHang
go

use DonDatHang
go

create table KhachHang(
	KhachHangID int identity(1,1) not null,
	HoTen nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	SoDienThoai int not null,
	GhiChu nvarchar(100) not null,
	Email nvarchar(100) not null
)
go
alter table KhachHang add primary key (KhachHangId)
go

create table LoaiSanPham(
	LoaiSanPhamID int identity(1,1) not null,
	TenLoai nvarchar(100) not null,
	GhiChu nvarchar(100) not null
)
go
alter table LoaiSanPham add primary key (LoaiSanPhamID)

create table SanPham(
	SanPhamID int identity(1,1) not null,
	LoaiSanPhamID int not null,
	KyHieuSanPham nvarchar(100) not null,
	TenSanPham nvarchar(100) not null,
	MoTa nvarchar(100) not null,
	NhaSanXuat nvarchar(100) not null,
	NgayDang datetime not null,
	GiaBan int not null,
	LaSanPhamMoi nvarchar(100) not null
)
go
alter table SanPham add primary key (SanPhamID)
go
alter table SanPham add foreign key (LoaiSanPhamID) references LoaiSanPham(LoaiSanPhamID)
go

create table DonDatHang(
	DonDatHangID int not null,
	KhachHangID int not null,
	SoHieuDon int not null,
	NgayDat datetime not null,
	NgayGioTraThucTe datetime not null,
	GhiChu nvarchar(100) not null,
	TinhTrang bit not null
)
go
alter table DonDatHang add primary key (DonDatHangID)
go
alter table DonDatHang add foreign key (KhachHangID) references KhachHang(KhachHangID)
go

create table ChiTietDonDatHang (
	ChiTietDonDatHangID int not null,
	DonDatHangID int not null,
	SanPhamID int not null,
	SoLuong int not null
)
go
alter table ChiTietDonDatHang add primary key (ChiTietDonDatHangID)
go
alter table ChiTietDonDatHang add foreign key (DonDatHangID) references DonDatHang(DonDatHangID)
go
alter table ChiTietDonDatHang add foreign key (SanPhamID) references SanPham(SanPhamID)
go


insert into KhachHang values
(N'Nguyễn Văn Ngọc',N'Nam Định','0989160299',N'Vui tính','ngocnv@gmail.com'),
(N'Trần Ngọc Lâm',N'Hà Nội','0989160299',N'Vui tính','lamtn@gmail.com'),
(N'Hoàng Thùy Lan',N'Hải Phòng','0989160299',N'Vui tính','lanht@gmail.com'),
(N'Trương Công Minh',N'Đà Nẵng','0989160299',N'Vui tính','minhtc@gmail.com'),
(N'Trịnh Thùy Linh',N'Quảng Ninh','0989160299',N'Vui tính','linhtt@gmail.com'),
(N'Mai Anh Tuấn',N'Hà Tĩnh','0989160299',N'Vui tính','tuanma@gmail.com'),
(N'Tạ Ngọc Hải',N'Hưng Yên','0989160299',N'Vui tính','haitn@gmail.com'),
(N'Trần Văn Ban',N'Vĩnh Phúc','0989160299',N'Vui tính','bantv@gmail.com'),
(N'Lâm Tâm Như',N'Phú Thọ','0989160299',N'Vui tính','nhult@gmail.com'),
(N'Hà Văn Chiến',N'Yên Bái','0989160299',N'Vui tính','chienhv@gmail.com'),
(N'Nguyễn Công Hoan',N'Hải Dương','0989160299',N'Vui tính','hoannc@gmail.com'),
(N'Trần Quang Minh',N'Nghệ An','0989160299',N'Vui tính','minhtq@gmail.com'),
(N'Phan Ngọc Toản',N'Thanh Hóa','0989160299',N'Vui tính','toanpn@gmail.com'),
(N'Mai Thị Thu Hà',N'Huế','0989160299',N'Vui tính','hamtt@gmail.com'),
(N'Trương Ngọc Ánh',N'TP.Hồ Chí Minh','0989160299',N'Vui tính','anhtn@gmail.com'),
(N'Nguyễn Văn Ngọc',N'Nam Định','0989160299',N'Vui tính','ngocnv@gmail.com'),
(N'Đỗ Việt Anh',N'Hà Nội','0989160299',N'Vui tính','lamtn@gmail.com'),
(N'Phạm Thị Kim Huế',N'Hải Phòng','0989160299',N'Vui tính','lanht@gmail.com'),
(N'Nguyễn Đức Anh',N'Đà Nẵng','0989160299',N'Vui tính','minhtc@gmail.com'),
(N'Cao Tuấn Anh',N'Quảng Ninh','0989160299',N'Vui tính','linhtt@gmail.com'),
(N'Trần Minh Sơn',N'Hà Tĩnh','0989160299',N'Vui tính','tuanma@gmail.com'),
(N'Hoàng Lê Tuấn Anh',N'Hưng Yên','0989160299',N'Vui tính','haitn@gmail.com'),
(N'Nguyễn Ngọc Hoa',N'Vĩnh Phúc','0989160299',N'Vui tính','bantv@gmail.com'),
(N'Lê Trung Hiếu',N'Phú Thọ','0989160299',N'Vui tính','nhult@gmail.com'),
(N'Nguyễn Duy Quyền',N'Yên Bái','0989160299',N'Vui tính','chienhv@gmail.com'),
(N'Chu Hoàng Lan Anh',N'Hải Dương','0989160299',N'Vui tính','hoannc@gmail.com'),
(N'Vũ Minh Hiếu',N'Nghệ An','0989160299',N'Vui tính','minhtq@gmail.com'),
(N'Chu Huy Văn',N'Thanh Hóa','0989160299',N'Vui tính','toanpn@gmail.com'),
(N'Hoàng Phúc',N'Huế','0989160299',N'Vui tính','hamtt@gmail.com'),
(N'La Thị Hằng',N'TP.Hồ Chí Minh','0989160299',N'Vui tính','anhtn@gmail.com'),
(N'Đỗ Thị Hậu',N'Nam Định','0989160299',N'Vui tính','ngocnv@gmail.com'),
(N'Mai Trung Văn',N'Hà Nội','0989160299',N'Vui tính','lamtn@gmail.com'),
(N'Nguyễn Tiến Anh',N'Hải Phòng','0989160299',N'Vui tính','lanht@gmail.com'),
(N'Trương Minh Thông',N'Đà Nẵng','0989160299',N'Vui tính','minhtc@gmail.com'),
(N'Nguyễn Thị Linh',N'Quảng Ninh','0989160299',N'Vui tính','linhtt@gmail.com'),
(N'Nguyễn Thế Dũng',N'Hà Tĩnh','0989160299',N'Vui tính','tuanma@gmail.com'),
(N'Đinh Tuấn Anh',N'Hưng Yên','0989160299',N'Vui tính','haitn@gmail.com'),
(N'Trần Đức Lương',N'Vĩnh Phúc','0989160299',N'Vui tính','bantv@gmail.com'),
(N'Dương Thế Lương',N'Phú Thọ','0989160299',N'Vui tính','nhult@gmail.com'),
(N'Phạm Thanh Tuấn',N'Yên Bái','0989160299',N'Vui tính','chienhv@gmail.com')
go

insert into LoaiSanPham values
(N'Đồ Ăn',N'Ngon'),
(N'Đồ Uống',N'Ngon'),
(N'Trang Sức',N'Đẹp'),
(N'Quần Áo',N'Đẹp'),
(N'Giày Dép',N'Tốt'),
(N'Đồng Hồ',N'Đẹp'),
(N'Điện Thoại',N'Tốt'),
(N'Máy Tính',N'Nuột'),
(N'Ô Tô',N'Tuyệt vời'),
(N'Xe Máy',N'Đẹp')
go

insert into SanPham values
(1,'DA',N'Hảo Hảo',N'Mì ăn liền',N'Việt Nam','2020-05-25',5000,N'Phải'),
(1,'DA',N'Bim Bim',N'Bim Bim',N'O-Star','2020-05-25',10000,N'Không phải'),
(1,'DA',N'Chocopie',N'Bánh',N'Việt Nam','2020-05-25',20000,N'Phải'),
(1,'DA',N'Xúc xích',N'Xúc xích',N'CP','2020-08-04',10000,N'Không phải'),
(2,'DU',N'Sting',N'Sting',N'Việt Nam','2020-07-05',10000,N'Phải'),
(2,'DU',N'Coconut',N'Nước dừa',N'Vinamilk','2020-06-06',15000,N'Không phải'),
(2,'DU',N'Yakult',N'Men tiêu hóa',N'Nhật Bản','2020-09-07',10000,N'Phải'),
(2,'DU',N'Trà sữa',N'Trà sữa',N'Mixue','2020-08-08',25000,N'Không phải'),
(3,'TS',N'Dây chuyền',N'Dây chuyền',N'PNJ','2020-10-09',5000000,N'Phải'),
(3,'TS',N'Nhẫn',N'Nhẫn',N'DOJI','2020-05-25',10000000,N'Không phải'),
(3,'TS',N'Hoa tai',N'Hoa tai',N'VNJ','2020-05-25',5000000,N'Phải'),
(3,'TS',N'Vòng tay',N'Vòng tay',N'Việt Nam','2020-05-25',2000000,N'Không phải'),
(4,'QA',N'Áo phông',N'Áo phông',N'Uniqlo','2020-05-25',500000,N'Phải'),
(4,'QA',N'Áo sơ mi',N'Áo sơ mi',N'Mando','2020-05-25',200000,N'Không phải'),
(4,'QA',N'Áo dạ',N'Áo dạ',N'Rabbit','2020-03-10',1000000,N'Phải'),
(4,'QA',N'Áo nỉ',N'Áo nỉ',N'Friday','2020-04-09',700000,N'Không phải'),
(5,'GD',N'Air Jordan',N'Giày',N'Nike','2020-05-08',10000000,N'Phải'),
(5,'GD',N'Stan Smith',N'Giày',N'Adidas','2020-06-07',3000000,N'Không phải'),
(5,'GD',N'Bitis Hunter',N'Bitis',N'Việt Nam','2020-07-06',1500000,N'Phải'),
(5,'GD',N'Chuck Taylor',N'Giày',N'Converse','2020-08-05',1500000,N'Không phải'),
(6,'DH',N'Apple Watch',N'Đồng hồ',N'Acecook','2020-09-04',7000000,N'Phải'),
(6,'DH',N'Galaxy Watch 4',N'Đồng hồ',N'Samsung','2020-10-03',5000000,N'Không phải'),
(6,'DH',N'Rolex',N'Đồng hồ',N'Rolex','2020-11-02',500000000,N'Phải'),
(6,'DH',N'Hublot',N'Đồng hồ',N'Hublot','2020-12-01',200000000,N'Không phải'),
(7,'DT',N'Iphone 14 Promax',N'Điện thoại',N'Apple','2020-12-01',33000000,N'Phải'),
(7,'DT',N'Xiaomi Redmi Note 11',N'Điện thoại',N'Xiaomi','2020-11-02',12000000,N'Không phải'),
(7,'DT',N'Samsung Note 22 Ultra',N'Điện thoại',N'Samsung','2020-10-03',22000000,N'Phải'),
(7,'DT',N'OPPO Reno 8',N'Điện thoại',N'OPPO','2020-09-04',10000000,N'Không phải'),
(8,'MT',N'Macbook Pro',N'Laptop',N'Apple','2020-08-05',43000000,N'Phải'),
(8,'MT',N'Asus ROG 15',N'Laptop',N'Asus','2020-07-06',40000000,N'Không phải'),
(8,'MT',N'Lenovo Legion 5',N'Laptop',N'Lenovo','2020-06-07',37000000,N'Phải'),
(8,'MT',N'LG Gram 16',N'Laptop',N'LG','2020-05-08',45000000,N'Không phải'),
(9,'OT',N'Honda CRV',N'Ô tô',N'Honda','2020-04-09',10000000,N'Phải'),
(9,'OT',N'Huyndai Santafe',N'Ô tô',N'Huyndai','2020-03-10',50000000,N'Không phải'),
(9,'OT',N'Mercedes S680 MayBach',N'Ô tô',N'Mercedes','2020-02-11',165000000,N'Phải'),
(9,'OT',N'RollRoyce Phantom',N'Ô tô',N'RollRoyce','2020-01-12',450000000,N'Không phải'),
(10,'XM',N'Honda SH150i',N'Xe máy',N'Honda','2020-12-12',100000000,N'Phải'),
(10,'XM',N'Exciter 150',N'Xe máy',N'Yamaha','2020-11-11',50000000,N'Không phải'),
(10,'XM',N'Vespa Sprint S125',N'Xe máy',N'Vespa','2020-10-10',70000000,N'Phải'),
(10,'XM',N'Panigale V4',N'Xe máy',N'Ducati','2020-02-09',600000000,N'Không phải')
go

insert into DonDatHang values
(1,1,'2020-05-25','2020-05-25',N'Đầy đủ',N'Đã Thanh Toán'),
(1,2,'2020-05-25','2020-05-25',N'Đầy đủ',N'Đã Thanh Toán'),
(1,3,'2020-05-25','2020-05-25',N'Đầy đủ',N'Chưa Thanh Toán'),
(2,4,'2019-09-06','2019-09-06',N'Đầy đủ',N'Đã Thanh Toán'),
(5,5,'2019-09-06','2019-09-06',N'Đầy đủ',N'Chưa Thanh Toán'),
(2,6,'2019-09-06','2019-09-06',N'Đầy đủ',N'Đã Thanh Toán'),
(7,7,'2019-09-06','2019-09-06',N'Đầy đủ',N'Chưa Thanh Toán'),
(8,8,'2019-09-06','2019-09-06',N'Đầy đủ',N'Đã Thanh Toán'),
(3,9,'2019-09-06','2019-09-06',N'Đầy đủ',N'Chưa Thanh Toán'),
(10,10,'2020-05-25','2020-05-25',N'Đầy đủ',N'Đã Thanh Toán'),
(11,11,'2020-05-25','2020-05-25',N'Đầy đủ',N'Chưa Thanh Toán'),
(12,12,'2020-05-25','2020-05-25',N'Đầy đủ',N'Đã Thanh Toán'),
(13,13,'2020-05-25','2020-05-25',N'Đầy đủ',N'Chưa Thanh Toán'),
(14,14,'2020-05-25','2020-05-25',N'Đầy đủ',N'Đã Thanh Toán'),
(3,15,'2020-05-25','2020-05-25',N'Đầy đủ',N'Chưa Thanh Toán'),
(16,16,'2020-05-25','2020-05-25',N'Đầy đủ',N'Đã Thanh Toán'),
(17,17,'2020-05-25','2020-05-25',N'Đầy đủ',N'Chưa Thanh Toán'),
(3,18,'2020-05-25','2020-05-25',N'Đầy đủ',N'Đã Thanh Toán'),
(19,19,'2020-05-25','2020-05-25',N'Đầy đủ',N'Chưa Thanh Toán'),
(2,20,'2020-06-09','2020-06-09',N'Đầy đủ',N'Đã Thanh Toán'),
(3,21,'2019-06-09','2019-06-09',N'Đầy đủ',N'Chưa Thanh Toán'),
(22,22,'2020-06-09','2020-06-09',N'Đầy đủ',N'Đã Thanh Toán'),
(23,23,'2019-06-09','2019-06-09',N'Đầy đủ',N'Chưa Thanh Toán'),
(24,24,'2020-06-09','2020-06-09',N'Đầy đủ',N'Đã Thanh Toán'),
(25,25,'2019-06-09','2019-06-09',N'Đầy đủ',N'Chưa Thanh Toán'),
(26,26,'2019-06-09','2019-06-09',N'Đầy đủ',N'Đã Thanh Toán'),
(17,27,'2020-06-09','2020-06-09',N'Đầy đủ',N'Chưa Thanh Toán'),
(28,28,'2019-06-09','2019-06-09',N'Đầy đủ',N'Đã Thanh Toán'),
(29,29,'2019-06-09','2019-06-09',N'Đầy đủ',N'Chưa Thanh Toán'),
(30,30,'2020-06-09','2020-06-09',N'Đầy đủ',N'Đã Thanh Toán'),
(31,31,'2020-10-01','2020-11-01',N'Đầy đủ',N'Chưa Thanh Toán'),
(32,32,'2020-10-01','2020-11-01',N'Đầy đủ',N'Đã Thanh Toán'),
(33,33,'2020-10-01','2020-11-01',N'Đầy đủ',N'Chưa Thanh Toán'),
(34,34,'2020-10-01','2020-11-01',N'Đầy đủ',N'Đã Thanh Toán'),
(35,35,'2020-10-01','2020-11-01',N'Đầy đủ',N'Chưa Thanh Toán'),
(3,36,'2020-10-01','2020-11-01',N'Đầy đủ',N'Đã Thanh Toán'),
(37,37,'2020-10-01','2020-11-01',N'Đầy đủ',N'Chưa Thanh Toán'),
(3,38,'2020-10-01','2020-11-01',N'Đầy đủ',N'Đã Thanh Toán'),
(39,39,'2020-10-01','2020-11-01',N'Đầy đủ',N'Chưa Thanh Toán'),
(40,40,'2020-10-01','2020-11-01',N'Đầy đủ',N'Đã Thanh Toán')
go