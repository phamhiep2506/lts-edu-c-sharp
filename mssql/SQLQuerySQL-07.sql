-- 1. Lấy thông tin sinh viên có học bổng cao nhất.
select * from SinhVien
where Hocbong =
(
	select max(Hocbong) from SinhVien
)
go

-- 2. Cho biết những sinh viên điểm thi lần 1 cao nhất môn học 1.
select * from SinhVien, KetQua
where Lanthi = 1
and Diemthi =
(
	select max(Diemthi) from KetQua
)
go

-- 3. Cho biết sinh viên có điểm thi lần 2 môn bất kỳ lớn hơn tất cả điểm thi lần 1 của những sinh viên khác.
select * from SinhVien, KetQua
where Lanthi = 2
and Diemthi >
(
	select Diemthi from KetQua where Lanthi = 1
)
go

-- 4. Cho biết sinh viên có nơi sinh cùng với Minh.
select * from SinhVien
where NoiSinh in
(
	select Noisinh from SinhVien
	where Hoten like N'%Minh%'
)
go

-- 5. Cho biết điểm thi cao nhất mỗi môn học.
select * from MonHoc, KetQua
where Diemthi = 
(
	select max(Diemthi) from KetQua
)
go

-- 6. Cho biết sinh viên có học bổng cao nhất mỗi khoa
select * from SinhVien, Khoa
where Hocbong = 
(
	select max(Hocbong) from SinhVien
)
go

-- 7. Môn học nào có nhiều sinh viên học nhất.
select count(SinhvienID) as 'SoSinhVienHoc', MonhocID
from SinhVien, MonHoc
group by MonhocID
go

-- 8. Khoa nào có đông sinh viên nam nhất.
select count(SinhvienID) as 'TongHocVienNam', Tenkhoa
from SinhVien, Khoa
where Gioitinh = N'nam'
group by Tenkhoa
go

-- 9. Cho biết môn nào có nhiều sinh viên rớt lần 1 nhiều nhất.
select count(Monhoc.MonhocID), MonHoc.Tenmonhoc
from MonHoc, KetQua
where KetQua.Lanthi > 1
group by MonHoc.Tenmonhoc
go

-- 10. Cho biết sinh viên chưa thi môn học 1
select MonHoc.MonhocID, Tenmonhoc, SinhVien.SinhvienID, Hoten, Diemthi
from MonHoc, KetQua, SinhVien
where Monhoc.MonhocID = 1
and Diemthi = 0
go

-- 11. Cho biết những môn không có sinh viên rớt ở lần 1.
select *
from MonHoc, KetQua
where Monhoc.MonhocID = 1 and Diemthi < 5
go

-- 13. Cho biết những sinh viên có học bổng hoặc không trượt môn nào trong lần thi 1
select * from SinhVien 
where SinhVienID in (
	select SinhVien.SinhvienID
	from SinhVien, KetQua
	where Hocbong != 0 and Diemthi > 5
	group by SinhVien.SinhVienID
)
go

-- 14. Điểm cao nhất và thấp nhất mỗi môn học.
select max(Diemthi) as DiemCaoNhat, Monhoc.MonhocID
from MonHoc, KetQua
group by Monhoc.MonhocID
go
select min(Diemthi) as DiemThapNhat, Monhoc.MonhocID
from MonHoc, KetQua
group by Monhoc.MonhocID
go