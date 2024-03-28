use CuaHang
go

-- 1. Lấy thông tin loại sản phẩm của từng sản phẩm (select TenSanPham, TenLoai)
select tensp, tenloai from SanPham inner join LoaiSanPham on SanPham.loaispid = LoaiSanPham.loaispid
go

-- 2. In ra danh sách các sản phẩm không bán được trong năm 2019
select * from SanPham inner join ChiTietDonDatHang on SanPham.spid = ChiTietDonDatHang.spid
where year(SanPham.ngaydang) < 2019
go

-- 3. In ra danh sách sản phẩm thuộc loại "Đồ ăn" sản xuất và được bán ra trong ngày 25/5/2020 (sản xuất và bán ra là cùng 1 ngày)
select * from SanPham inner join LoaiSanPham on SanPham.loaispid = LoaiSanPham.loaispid
where LoaiSanPham.tenloai = N'Đồ ăn'
and SanPham.ngaydang = '2020-05-25'
go

-- 4. Tìm các số hiệu đơn đã mua sản phẩm thuộc loại sản phẩm "Đồ ăn" hoặc "Đồ uống", mỗi sản phẩm mua với số lượng từ 10 đến 20.
select * from SanPham, LoaiSanPham, DonDatHang, ChiTietDonDatHang
where (
	tenloai = N'Đồ ăn' or tenloai = N'Đồ uống'
)
and soluong >= 10 
and  soluong <= 20
and tinhtrang = N'Đã Thanh Toán'
go

-- 5. In ra tổng tiền của các hóa đơn trong ngày 25/05/2020
select sum(giaban) as N'tổng tiền của các hóa đơn trong ngày 25/05/2020' from SanPham 
inner join ChiTietDonDatHang on SanPham.spid = ChiTietDonDatHang.spid
inner join DonDatHang on ChiTietDonDatHang.dondhid = DonDatHang.dondhid
where ngaydat = '2020-05-25'
go

-- 6. Tính tổng số sản phẩm của từng hóa đơn
select tensp, sum(soluong) as N'Tổng số sản phẩm' from SanPham
inner join ChiTietDonDatHang on SanPham.spid = ChiTietDonDatHang.spid
inner join DonDatHang on ChiTietDonDatHang.dondhid = DonDatHang.dondhid
group by tensp
go

-- 7. Tìm khách hàng có số lần mua hàng nhiều nhất.
select DonDatHang.khid, count(DonDatHang.dondhid) as N'Số lần mua hàng' from DonDatHang
inner join KhachHang on DonDatHang.khid = KhachHang.khid
group by DonDatHang.khid
go

-- 8. Tìm hóa đơn có mua 3 sản phẩm do Việt Nam sản xuất (3 sản phẩm khác nhau)
select top(3) DonDatHang.dondhid from DonDatHang
inner join ChiTietDonDatHang on DonDatHang.dondhid = ChiTietDonDatHang.dondhid
inner join SanPham on ChiTietDonDatHang.spid = SanPham.spid
where nhasx = N'Việt Nam'
group by DonDatHang.dondhid
go

-- 9. Tháng mấy trong năm 2019 có doanh số bán hàng cao nhất ?
select month(ngaydat) month, count(*) as N'Doanh số bán hàng' from DonDatHang
where year(ngaydat) = '2019'
group by month(ngaydat)
go

-- 10. Cho biết trị giá hóa đơn cao nhất là bao nhiêu ?
select max(SanPham.giaban) from DonDatHang
inner join ChiTietDonDatHang on DonDatHang.dondhid = ChiTietDonDatHang.chitietddhid
inner join SanPham on SanPham.spid = ChiTietDonDatHang.spid
go

-- 11. Cho biết trị giá hóa đơn cao nhất và thấp nhất là bao nhiêu ?
select min(SanPham.giaban) from DonDatHang
inner join ChiTietDonDatHang on DonDatHang.dondhid = ChiTietDonDatHang.chitietddhid
inner join SanPham on SanPham.spid = ChiTietDonDatHang.spid
go

-- 12. Tìm sản phẩm có tổng số lượng bán ra thấp nhất trong năm 2019
select ChiTietDonDatHang.spid , sum(ChiTietDonDatHang.soluong) as 'Tong so luong' from DonDatHang
inner join ChiTietDonDatHang on DonDatHang.dondhid = ChiTietDonDatHang.chitietddhid
group by ChiTietDonDatHang.spid
go

-- 14. Tìm những loại sản phẩm được bán ra trong ngày 9/6/2020
select * from DonDatHang
where ngaydat = '2020-06-09'
go

-- 15. Tìm những khách hàng ở Hà Nội đã mua sản phẩm thuộc loại 1 trong tháng 6 năm 2020
select * from KhachHang
inner join DonDatHang on KhachHang.khid = DonDatHang.khid
where ngaydat = '2020-06-01'
go

-- 16. Tìm những sản phẩm chưa bán được trong 6 tháng vừa qua
select * from DonDatHang
where month(ngaydat) = 6  and tinhtrang = N'Chưa Thanh Toán'
go

-- 17. Tìm những hóa đơn có 3 loại sản phẩm khác nhau.
select top(3) spid from ChiTietDonDatHang
group by spid
go

-- 18. Tìm những khách hàng đặt trên 100 sản phẩm trong 1 hóa đơn
select * from DonDatHang
inner join ChiTietDonDatHang on ChiTietDonDatHang.dondhid = DonDatHang.dondhid
where soluong > 100
go

-- 19. Hóa đơn có số lượng sản phẩm cao nhất là hóa đơn nào, bao nhiêu sản phẩm, gồm mấy loại sản phẩm.
select DonDatHang.dondhid, sum(ChiTietDonDatHang.soluong) as 'số lượng sản phẩm' from DonDatHang
inner join ChiTietDonDatHang on ChiTietDonDatHang.dondhid = DonDatHang.dondhid
inner join SanPham on ChiTietDonDatHang.spid = SanPham.spid
inner join LoaiSanPham on SanPham.loaispid = LoaiSanPham.loaispid
group by DonDatHang.dondhid
go

-- 20. Tìm những sản phẩm chỉ được đặt 1 lần duy nhất.
select count(spid) as 'lần đặt' from DonDatHang
inner join ChiTietDonDatHang on DonDatHang.dondhid = ChiTietDonDatHang.chitietddhid
group by spid