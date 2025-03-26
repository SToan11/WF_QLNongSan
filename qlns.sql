create database QuanLiNongSan_fix3;

use QuanLiNongSan_fix3;

create table NguoiDung (
	ID_nd int identity(1,1),
    MaNguoiDung varchar(10) primary key,
    TenNguoiDung nvarchar(255),
    GioiTinh nvarchar(10),
    VaiTro tinyint,
    DiaChi nvarchar(255),
    Email varchar(255),
    SDT int,
	Hinh nvarchar(255),
	tinhtrang tinyint CONSTRAINT DF_tinhtrang DEFAULT ('1'),
	MatKhau NVARCHAR(50) CONSTRAINT DF_MatKhauND DEFAULT ('2331542419640203562132429613354120146463')
);

create table LoaiHang (
	ID_lh int identity(1,1),
    MaLoaiHang varchar(10) primary key,
    TenLoaiHang nvarchar(255),
	tinhtrangloaihang tinyint Constraint DF_tinhtranglh Default ('1')
);

create table KhachHang(
	ID_kh int identity(1,1),
	MaKhachHang varchar(10) primary key,
    TenKhachHang nvarchar(255),
    GioiTinh nvarchar(10),
    DiaChi nvarchar(255),
    Email varchar(255),
    SDT int,
	tinhtrangkh tinyint Constraint DF_tinhtrangkh Default ('1'),
	GhiChu nvarchar(500)
);


create table HoaDon(
   ID_hd int identity(1,1),
   MaHoaDon varchar(10) primary key,
   MaNhanVien varchar(10),
   NgayBan date,
   MaKhachHang varchar(10),
   TongTien float,
   tinhtranghoadon tinyint CONSTRAINT DF_tinhtranghoadon DEFAULT ('1'),
   foreign key (MaNhanVien) references NguoiDung(MaNguoiDung),
   foreign key (MaKhachHang) references KhachHang(MaKhachHang)
);

create table SanPham (
	ID_sp int identity(1,1),
    MasanPham varchar(10) primary key,
    TenSanPham nvarchar(255),
    LoaiSanPham nvarchar(255),
    HinhAnh varchar(255),
	SoLuong int,
    DonGia nvarchar(50),
	NgayThem Date,
    MaLoaiHang varchar(10),
	GhiChu nvarchar(255),
	tinhtrangsanpham tinyint CONSTRAINT DF_tinhtrangsanpham DEFAULT ('1'),
    foreign key (MaLoaiHang) references LoaiHang(MaLoaiHang)
);

create table CTHoaDon (
    MaHoaDon varchar(10),
    MasanPham varchar(10),
	TenSanPham nvarchar(255),
	LoaiSanPham nvarchar(255),
	SoLuong int,
	DonGia float,
	ThanhTien float,
	primary key (MaHoaDon,MasanPham),
    foreign key (MasanPham) references SanPham(MasanPham),
	foreign key (MaHoaDon) references HoaDon(MaHoaDon)
	
);



create table HoTro(
	ID int identity(1,1),
	EmailKH varchar(255),
	NoiDung nvarchar(500),
	ThoiGian datetime
);


--Đăng nhập
create or alter proc DangNhap 
@email nvarchar(100),@Pass nvarchar(100)
as
begin
	declare @status int
	if(exists(select * from NguoiDung where Email = @email and MatKhau = @Pass) ) 
		set @status = 1
	else 
		set @status = 0
	select @status
end
go
--quên mật khẩu
create or alter proc QuenMK
@email nvarchar(100)
as
begin
	declare @status int 
	if exists(select MaNguoiDung from NguoiDung where Email = @email)
		set @status = 1
	else 
		set @status = 0
	select @status
end
go
-- Cập nhật mật khẩu
create or alter proc capNhatMK
@email nvarchar(50),
@newpass nvarchar(50)
as
begin
		update NguoiDung set MatKhau = @newpass where Email = @email
end
go
-- đổi mật khẩu
create or alter proc DoiMK
@email nvarchar(50),
@oldpass nvarchar(50),
@newpass nvarchar(50)
as
begin

	declare @old nvarchar(50)
	select @old = MatKhau 
	from NguoiDung 
	where Email = @email

	if (@old = @oldpass)
		begin
		update NguoiDung set MatKhau = @newpass where Email = @email
		return 1
		end
	else 
		return -1
end
go
/*laynt*/
create or alter proc LayVaiTroNV @email nvarchar(50)
as
	begin 
		declare @status int
		if exists (select * from NguoiDung where Email = @email and VaiTro = 0)
			set @status = 0
		else
			set @status = 1
			select @status
	end
	go
--========================================= SỰ KIỆN BẢNG NGƯỜI DÙNG ========================================

-- Danh sách người dùng
create or alter proc DSNguoiDung
@sotrang int,
@kichthuoctrang int
as
begin
	 select MaNguoiDung, TenNguoiDung, GioiTinh, VaiTro, DiaChi, Email, SDT, Hinh from NguoiDung where tinhtrang = 1
	 order by ID_nd
	 OFFSET (@sotrang - 1) * @kichthuoctrang ROWS
	 FETCH NEXT @kichthuoctrang ROWS ONLY;
end
go
--Thêm người dùng
create or alter proc ThemNguoiDung
@tennd nvarchar(255),
@gioitinh nvarchar(10),
@vaitro tinyint,
@diachi nvarchar(255),
@email varchar(255),
@sdt int,
@hinh nvarchar(255)
as
begin
	declare @id int
	declare @mand nvarchar(20)

	select @id = ISNULL(MAX(ID_nd),0) + 1 from NguoiDung
	select @mand = 'NV' + RIGHT('0' + Cast(@id as nvarchar(4)),4)

	insert into NguoiDung(MaNguoiDung, TenNguoiDung, GioiTinh, VaiTro, DiaChi, Email, SDT, Hinh) 
	values(@mand, @tennd, @gioitinh, @vaitro, @diachi, @email, @sdt, @hinh)
end
go

EXEC ThemNguoiDung 
    @tennd = N'Người Dùng 1',
    @gioitinh = N'Nam',
    @vaitro = 1,
    @diachi = N'Thành Phố HCM',
    @email = 'thuancom284@gmail.com',
    @sdt = 1376662967,
    @hinh = N'\AnhNguoiDung\user.jpg';
--Sửa người dùng
create or alter proc SuaNguoiDung
@tennd nvarchar(255),
@gioitinh nvarchar(10),
@vaitro tinyint,
@diachi nvarchar(255),
@email varchar(255),
@sdt int,
@hinh nvarchar(255)
as
begin
	update NguoiDung 
	set TenNguoiDung = @tennd, GioiTinh = @gioitinh, VaiTro = @vaitro, DiaChi = @diachi, SDT = @sdt, Hinh = @hinh
	where Email = @email And tinhtrang = 1
end
go
-- Xóa người dùng
create or alter proc XoaNguoiDung
@email nvarchar(50)
as
begin
	update NguoiDung 
	set tinhtrang = 0
	where Email = @email
end
go
-- kiểm tra người dùng
create or alter proc KiemTraNguoiDung
    @tennd NVARCHAR(255),
    @email VARCHAR(255)
AS
BEGIN
    -- Example query to check if a user exists
    SELECT COUNT(*)
    FROM NguoiDung
    WHERE TenNguoiDung = @tennd AND Email = @email;
END
--------------------------------------------------------------------------
create or alter proc TimNguoiDung
@tennd nvarchar(255)
as
begin
	set nocount on;
	select MaNguoiDung, TenNguoiDung, GioiTinh, VaiTro, DiaChi, Email, SDT, Hinh
	from NguoiDung
	where tinhtrang = 1 AND TenNguoiDung like '%' +  @tennd +'%'

end
---------------------------------------------THÊM MỚI---------------------------------------------------------
--lấy số người dùng tối đa
create or alter proc getTongData
as
begin
SELECT COUNT(*) FROM NguoiDung WHERE tinhtrang = 1
end
--Lấy số người dùng bị xóa
create or alter proc getNguoiDungBiXoa
	@tennd NVARCHAR(255),
    @email VARCHAR(255)
AS
BEGIN
    -- Example query to check if a user exists
    SELECT COUNT(*)
    FROM NguoiDung
    WHERE TenNguoiDung = @tennd AND Email = @email AND tinhtrang = 0;
END
--Phục hồi người dùng
create or alter proc phucHoiNguoiDung
@tennd nvarchar(255),
@gioitinh nvarchar(10),
@vaitro tinyint,
@diachi nvarchar(255),
@email varchar(255),
@sdt int,
@hinh nvarchar(255)
as
begin
	update NguoiDung 
	set TenNguoiDung = @tennd, GioiTinh = @gioitinh, VaiTro = @vaitro, DiaChi = @diachi, SDT = @sdt, Hinh = @hinh, tinhtrang = 1
	where Email = @email And tinhtrang = 0
end
--========================================= SỰ KIỆN BẢNG SẢN PHẨM ========================================
-- lấy sản phẩm bị xóa
create or alter proc getSanPhamBiXoa
	@tensp NVARCHAR(255)
    
AS
BEGIN
    -- Example query to check if a user exists
    SELECT COUNT(*)
    FROM SanPham
    WHERE TenSanPham = @tensp AND tinhtrangsanpham = 0;
END
-- phục hồi sản phẩm
create or alter proc phucHoisanpham
@tensp nvarchar(255),
@loaisp nvarchar(10),
@hinhanh varchar(255),
@soluong int,
@dongia float,
@ngay Date,
@maloaihang varchar(10),
@ghichu nvarchar(255)
as
begin
	update Sanpham 
	set TenSanPham = @tensp, LoaiSanPham = @loaisp, DonGia = @dongia, HinhAnh = @hinhanh,NgayThem=@ngay, SoLuong=@soluong,MaLoaiHang = @maloaihang, GhiChu = @ghichu,tinhtrangsanpham = 1
	where tinhtrangsanpham = 0 AND TenSanPham = @tensp
end
--kiểm tra sản phẩm
create or alter proc KiemTraSanPham
    @tensp NVARCHAR(255)
AS
BEGIN
    -- Example query to check if a user exists
    SELECT COUNT(*)
    FROM SanPham
    WHERE TenSanPham = @tensp;
END
-- Danh sách sản phẩm
create or alter proc DsSanPham
@sotrang INT,
@kichthuoctrang int
as
begin
	 select MasanPham, TenSanPham, SoLuong, LoaiSanPham, DonGia,NgayThem, HinhAnh, GhiChu from SanPham where tinhtrangsanpham = 1
	 order by ID_sp 
	 OFFSET (@sotrang - 1) * @kichthuoctrang ROWS
	 FETCH NEXT @kichthuoctrang ROWS ONLY;
end
--Lấy tổng data sản phẩm
create or alter proc getTongDataSanPham
as
begin
SELECT COUNT(*) FROM SanPham WHERE tinhtrangsanpham = 1
end
-- Thêm sản phẩm
create or alter proc ThemSanPham
@tensp nvarchar(255),
@loaisp nvarchar(10),
@soluong int,
@hinhanh varchar(255),
@dongia nvarchar(50),
@ngay Date,
@maloaihang varchar(10),
@ghichu nvarchar(255)
as
begin
	declare @id int
	declare @masp nvarchar(20)

	select @id = ISNULL(MAX(ID_sp),0) + 1 from SanPham
	select @masp = 'SP' + RIGHT('0' + Cast(@id as nvarchar(4)),4)

    INSERT INTO SanPham (MasanPham, TenSanPham, LoaiSanPham, HinhAnh, SoLuong, DonGia,NgayThem, MaLoaiHang, GhiChu)
    VALUES (@masp, @tensp, @loaisp, @hinhanh, @soluong, @dongia,@ngay,@maloaihang, @ghichu)
end
-- Sửa Sản phẩm
create or alter proc SuaSanPham

@tensp nvarchar(255),
@loaisp nvarchar(10),
@hinhanh varchar(255),
@soluong int,
@dongia nvarchar(50),
@ngay Date,
@maloaihang varchar(10),
@ghichu nvarchar(255)
as
begin
	update Sanpham
	set TenSanPham = @tensp, LoaiSanPham = @loaisp, DonGia = @dongia, HinhAnh = @hinhanh,NgayThem=@ngay, SoLuong=@soluong,MaLoaiHang = @maloaihang, GhiChu = @ghichu
	where tinhtrangsanpham = 1 AND TenSanPham = @tensp
end
--xóa sản phẩm
create or alter proc XoaSanPham
@masp nvarchar(50)
as
begin
	update Sanpham 
	set tinhtrangsanpham = 0
	where MasanPham = @masp
end
--tìm sản phẩm
create or alter proc TimSanPham
@tensp nvarchar(50)
as
begin 
	select * from SanPham
	where tinhtrangsanpham = 1 And TenSanPham like '%'+ @tensp +'%'
end 
--========================================= SỰ KIỆN CHO KHÁCH HÀNG ========================================

--Danh sách khách hàng
CREATE OR ALTER PROCEDURE HienThiKhachHang
    @sotrang INT,
    @kichthuoctrang INT
AS
BEGIN
    SELECT 
        MaKhachHang, 
        TenKhachHang, 
        GioiTinh, 
        DiaChi, 
        Email, 
        SDT
    FROM 
        Khachhang
    WHERE 
        tinhtrangkh = 1
    ORDER BY 
        ID_kh
    OFFSET (@sotrang - 1) * @kichthuoctrang ROWS
    FETCH NEXT @kichthuoctrang ROWS ONLY;
END
-- lấy tổng data khách hàng
create or alter proc getTongDataKhachHang
as
begin
SELECT COUNT(*) FROM KhachHang WHERE tinhtrangkh = 1
end
-- Thêm khách hàng
create or alter proc ThemKhachHang
    @tenkh NVARCHAR(255),
    @gioitinh NVARCHAR(10),
    @diachi NVARCHAR(255),
    @email VARCHAR(255),
    @sdt VARCHAR(20)
AS
BEGIN
    DECLARE @makh VARCHAR(10);
    SET @makh = 'KH' + RIGHT('0' + CAST((SELECT COUNT(*) FROM KhachHang) + 1 AS VARCHAR(4)), 4);
    INSERT INTO KhachHang (MaKhachHang, TenKhachHang, GioiTinh, DiaChi, Email, SDT) 
    VALUES (@makh, @tenkh, @gioitinh, @diachi, @email, @sdt);
END
--Sửa khách hàng
create or alter proc SuaKhachHang
    @makh nvarchar(20),
    @tenkh nvarchar(255),
    @gioitinh nvarchar(10),
    @diachi nvarchar(255),
    @email VARCHAR(255),
    @sdt INT
AS
BEGIN
    UPDATE Khachhang
    SET TenKhachHang = @tenkh, GioiTinh = @gioitinh, DiaChi = @diachi, Email = @email, SDT = @sdt
    WHERE tinhtrangkh = 1 AND MaKhachHang = @makh;
END
-- xóa theo mã khách hàng
create or alter proc XoaKhachHang
    @makh nvarchar(20)
AS
BEGIN
    UPDATE Khachhang
    SET tinhtrangkh = 0
    WHERE MaKhachHang = @makh;
END
-- Tìm khách khàng theo tên hoặc mã
create or alter procEDURE TimKhachHang
    @tukhoa NVARCHAR(50)
AS
BEGIN
    SELECT MaKhachHang, TenKhachHang, GioiTinh, DiaChi, Email, SDT
    FROM KhachHang
    WHERE tinhtrangkh = 1 And MaKhachHang LIKE '%' + @tukhoa + '%'
       OR TenKhachHang LIKE '%' + @tukhoa + '%'
       OR GioiTinh LIKE '%' + @tukhoa + '%'
       OR DiaChi LIKE '%' + @tukhoa + '%'
       OR Email LIKE '%' + @tukhoa + '%'
       OR SDT LIKE '%' + @tukhoa + '%';
END
--kiểm tra khách hàng
create or alter proc KiemTraKhachHang
    @tenkh NVARCHAR(255),
    @email VARCHAR(255)
AS
BEGIN
    -- Example query to check if a user exists
    SELECT COUNT(*)
    FROM KhachHang
    WHERE TenKhachHang = @tenkh AND Email = @email;
END

--Lấy số khách hàng bị xóa
create or alter proc getKhachHangBiXoa
	@tenkh NVARCHAR(255),
    @email VARCHAR(255)
AS
BEGIN
    -- Example query to check if a user exists
    SELECT COUNT(*)
    FROM KhachHang
    WHERE TenKhachHang = @tenkh AND Email = @email AND tinhtrangkh = 0;
END
--Phục hồi khách hàng
create or alter proc phucHoiKhachHang
    @makh nvarchar(20),
    @tenkh nvarchar(255),
    @gioitinh nvarchar(10),
    @diachi nvarchar(255),
    @email VARCHAR(255),
    @sdt INT
as
begin
	UPDATE Khachhang
    SET TenKhachHang = @tenkh, GioiTinh = @gioitinh, DiaChi = @diachi, Email = @email, SDT = @sdt, tinhtrangkh = 1
    WHERE tinhtrangkh = 0 AND MaKhachHang = @makh;
end
--========================================= SỰ KIỆN BẢNG LOẠI HÀNG ========================================

-- Danh sách loại hàng
create or alter proc DSLoaiHang
@sotrang INT,
@kichthuoctrang int
as
begin
	select MaLoaiHang, TenLoaiHang from LoaiHang
	Where tinhtrangloaihang = 1
	order by MaLoaiHang
	 OFFSET (@sotrang - 1) * @kichthuoctrang ROWS
	 FETCH NEXT @kichthuoctrang ROWS ONLY;
end


-- Danh Sach Loai Hang
create or alter proc DanhSachLoaiHang
AS
BEGIN
    SELECT MaLoaiHang, TenLoaiHang FROM LoaiHang
END


-- Thêm loại hàng
create or alter proc ThemLoaiHang
    @TenLoaiHang nvarchar(255)
as
begin
	declare @id int
	declare @malh nvarchar(20)

	select @id = ISNULL(MAX(ID_lh),0) + 1 from LoaiHang
	select @malh = 'LH' + RIGHT('0' + Cast(@id as nvarchar(4)),4)

    insert into LoaiHang (MaLoaiHang, TenLoaiHang)
    values (@malh, @TenLoaiHang);
end
-- Sửa loại hàng
create or alter proc SuaLoaiHang
    @MaLoaiHang varchar(10),
    @TenLoaiHang nvarchar(255)
as
begin
    update LoaiHang
    set TenLoaiHang = @TenLoaiHang
    where tinhtrangloaihang = 1 AND MaLoaiHang = @MaLoaiHang;
end

--Xóa loại hàng
create or alter proc XoaLoaiHang
    @MaLoaiHang varchar(10)
as
begin
    update LoaiHang
    set tinhtrangloaihang = 0
    where tinhtrangloaihang = 1 AND MaLoaiHang = @MaLoaiHang;
end
--Tìm loại hàng
create or alter proc TimLoaiHang
    @tenloaihang nvarchar(10)
as
begin
    select MaLoaiHang, TenLoaiHang
    from LoaiHang
    where tinhtrangloaihang = 1 AND TenLoaiHang like N'%'+ @tenloaihang +'%'
end
-- kiểm tra loại hàng
create or alter proc KiemTraLoaiHang
    @tenlh NVARCHAR(255)
AS
BEGIN
    -- Example query to check if a user exists
    SELECT COUNT(*)
    FROM LoaiHang
    WHERE TenLoaiHang = @tenlh;
END
--lấy loại hàng bị xóa
create or alter proc KiemTraLoaiHangBiXoa
    @tenlh NVARCHAR(255)
AS
BEGIN
    -- Example query to check if a user exists
    SELECT COUNT(*)
    FROM LoaiHang
    WHERE TenLoaiHang = @tenlh and tinhtrangloaihang = 0;
END
-- phục hồi loại hàng
create or alter proc phucHoiLoaiHang
    @TenLoaiHang nvarchar(255)
as
begin
    update LoaiHang
    set TenLoaiHang = @TenLoaiHang, tinhtrangloaihang = 1
    where tinhtrangloaihang = 0 AND TenLoaiHang = @TenLoaiHang;
end
--
create or alter proc getTongDataLoaiSanPham
as
begin
SELECT COUNT(*) FROM LoaiHang WHERE tinhtrangloaihang = 1 or tinhtrangloaihang = 0
end


--
create or alter proc KiemTraLoaiHangTonTai
    @tenlh nVARCHAR(255)
AS
BEGIN
    SELECT COUNT(*)
    FROM LoaiHang
    WHERE  TenLoaiHang = @tenlh;
END

--------------------------------------------------------------------------------------------------------------------
--ĐÂY LÀ KHU VỰC ĐANG THI CÔNG!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!, CẤM VÀO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
--------------------------------------------------------------------------------------------------------------------
--========================================= SỰ KIỆN BẢNG HÓA ĐƠN ========================================

-- Danh Sach Loai Hang
create or alter proc DSSP
AS
BEGIN
    SELECT MaSanPham, TenSanPham FROM SanPham
	where tinhtrangsanpham = 1
END

-- Danh Sach Nhan Vien
create or alter proc DSNV
AS
BEGIN
    SELECT MaNguoiDung, TenNguoiDung FROM NguoiDung
	where tinhtrang = 1
END
-- Danh Sach KhachHang
create or alter proc DSKH
AS
BEGIN
    SELECT MaKhachHang, TenKhachHang FROM KhachHang
	where tinhtrangkh = 1
END

--thông tin nhân viên
CREATE OR ALTER PROCEDURE thongTinSanPham
    @masp VARCHAR(10)
AS
BEGIN
    SELECT S.MaSanPham, L.TenLoaiHang, S.DonGia, S.SoLuong
    FROM SanPham AS S
    JOIN LoaiHang AS L ON S.MaLoaiHang = L.MaLoaiHang
    WHERE S.MaSanPham = @masp;
END;
--thong tin nhan vien
CREATE OR ALTER PROCEDURE thongTinNhanVien
    @manv VARCHAR(10)
AS
BEGIN
    SELECT MaNguoiDung, TenNguoiDung
    FROM NguoiDung
    WHERE MaNguoiDung = @manv;
END;

--thong tin khach hang
CREATE OR ALTER PROCEDURE thongTinKhachHang
    @makh VARCHAR(10)
AS
BEGIN
    SELECT MaKhachHang,TenKhachHang, DiaChi, SDT
    FROM KhachHang
    WHERE MaKhachHang = @makh;
END;

CREATE OR ALTER PROCEDURE DanhSachHoaDon 
@sotrang int,
@kichthuoctrang int
AS 
BEGIN
    SELECT 
        H.MaHoaDon,
		N.MaNguoiDung,-- Invoice ID
        N.TenNguoiDung,
		K.MaKhachHang,-- Employee Name
        K.TenKhachHang,    -- Customer Name
        K.DiaChi, 
		H.NgayBan,-- Customer Address
        K.SDT,             -- Customer Phone Number
        H.TongTien         -- Total Amount
    FROM 
        HoaDon AS H
    JOIN 
        NguoiDung AS N ON H.MaNhanVien = N.MaNguoiDung
    JOIN 
        KhachHang AS K ON H.MaKhachHang = K.MaKhachHang
	where H.tinhtranghoadon = 1
	order by MaHoaDon
	OFFSET (@sotrang - 1) * @kichthuoctrang ROWS
	FETCH NEXT @kichthuoctrang ROWS ONLY;
END

--laytong hoa don
create or alter proc getTongDataHoaDon
as
begin
SELECT COUNT(*) FROM HoaDon WHERE tinhtranghoadon = 1
end

--tạo hóa đơn trống
CREATE OR ALTER PROCEDURE TaoHoaDon
	@manv varchar(10),
	@ngayban DATE,
	@makh varchar(10)
AS
BEGIN
    DECLARE @mahd VARCHAR(10)

    -- Generate a new invoice ID
    SELECT @mahd = 'HD' + RIGHT('00' + CAST((ISNULL(MAX(ID_HD), 0) + 1) AS VARCHAR(2)), 2)
    FROM HoaDon

    -- Insert the new invoice into the database
    INSERT INTO HoaDon (MaHoaDon, MaNhanVien, NgayBan, MaKhachHang, TongTien)
    VALUES (@mahd, @manv, @ngayban, @makh, NULL);
END

--xóa hóa đơn
CREATE OR ALTER PROCEDURE XoaHoaDon
    @MaHoaDon VARCHAR(10)
AS
BEGIN
    delete from CTHoaDon 
	where MaHoaDon = @MaHoaDon

	delete from HoaDon
    where MaHoaDon = @MaHoaDon;
END;

--them sanpham hoa don
CREATE OR ALTER PROCEDURE ThemSanPhamHoaDon
    @mahd VARCHAR(10),
    @masp VARCHAR(10),
    @tensp NVARCHAR(255),
    @loaisanpham NVARCHAR(255),
    @soluong INT,
    @dongia NVARCHAR(50),
    @thanhtien FLOAT
AS
BEGIN
    INSERT INTO CTHoaDon (MaHoaDon, MasanPham, TenSanPham, LoaiSanPham, SoLuong, DonGia, ThanhTien)
    VALUES (@mahd, @masp, @tensp, @loaisanpham, @soluong, @dongia, @thanhtien);
END;
--
create or alter proc LoadSanPhamHoaDon
@mahd varchar(10)
as
begin
select MaSanPham,TenSanPham, LoaiSanPham, DonGia, SoLuong, ThanhTien 
from CTHoaDon
where MaHoaDon = @mahd
end
-- sua hoadon

create or alter proc suaHoaDon
	@mahd VARCHAR(10),
    @manv VARCHAR(10),
    @ngayban DATE,
    @makh varchar(10),
    @tongtien float
as
begin
update HoaDon 
set MaNhanVien = @manv, NgayBan = @ngayban, MaKhachHang = @makh, TongTien = @tongtien
where MaHoaDon = @mahd
end
--capnhat tongtien
create or alter proc capNhatTongTien
	@mahd VARCHAR(10),
    @tongtien float
as
begin
update HoaDon 
set TongTien = @tongtien
where MaHoaDon = @mahd
end
-----------------------------------------------------------------------------------------------
-- Tìm hóa đơn
create or alter proc TimHoaDon
    @mahd varchar(10)
as
begin
    select *
    from HoaDon
    where MaHoaDon like '%'+ @mahd +'%'
end

-- Tìm sanpham
create or alter proc TimSanPhamHoaDon
    @mahd varchar(10),
	@tensp varchar(10)
as
begin
    select *
    from CTHoaDon
    where MaHoaDon like '%'+ @mahd +'%' AND TenSanPham like '%'+ @tensp +'%'
end

create or alter proc congSoLuong
@masp varchar(10),
@soluong int
as
begin
update SanPham 
set SoLuong = SoLuong + @soluong
where MasanPham = @masp
end

create or alter proc truSoLuong
@masp varchar(10),
@soluong int
as
begin
update SanPham 
set SoLuong = SoLuong - @soluong
where MasanPham = @masp
end

create or alter proc laySoLuongHienTai
@masp varchar(10)
as
begin
SELECT SoLuong
    FROM SanPham
    WHERE MaSanPham = @masp;
end

create or alter proc suaSanPhamHoaDon
	@mahd VARCHAR(10),
    @masp VARCHAR(10),
    @tensp NVARCHAR(255),
    @loaisanpham NVARCHAR(255),
    @soluong INT,
    @dongia NVARCHAR(50),
    @thanhtien FLOAT
as 
begin
update CTHoaDon
set TenSanPham=@tensp,LoaiSanPham=@loaisanpham,SoLuong=@soluong,DonGia=@dongia,ThanhTien=@thanhtien
where MasanPham = @masp and MaHoaDon = @mahd
end
--xoa san pham hoa don
create or alter proc xoaSanPhamHoaDon
@mahd varchar(10),
@masp varchar(10)
as
begin
delete from CTHoaDon 
where MaHoaDon=@mahd AND MasanPham=@masp
end

CREATE OR ALTER PROCEDURE KiemTraSanPhamHoaDon
    @MaSanPham VARCHAR(10),
	@mahd varchar(10)
AS
BEGIN
    -- Count the number of occurrences of the product in the ChiTietHoaDon table
    SELECT COUNT(*) AS ProductCount
    FROM CTHoaDon
    WHERE MaSanPham = @MaSanPham And MaHoaDon = @mahd;
END

--========================================= SỰ KIỆN THỐNG KÊ ========================================

-- Hàng Tồn Kho
CREATE OR ALTER PROC ThongKeHangTonKho
    @search NVARCHAR(50) = NULL,
    @sotrang INT,
    @kichthuoctrang INT
AS
BEGIN
    DECLARE @totalRecords INT;

    SELECT 
        @totalRecords = COUNT(*)
    FROM 
        SanPham s
    JOIN 
        LoaiHang l ON s.MaLoaiHang = l.MaLoaiHang
    WHERE 
        (@search IS NULL OR s.TenSanPham LIKE '%' + @search + '%') AND s.tinhtrangsanpham = 1;

    SELECT 
        s.MaSanPham AS 'Mã Sản Phẩm',
        s.TenSanPham AS 'Tên Sản Phẩm',
        l.TenLoaiHang AS 'Loại Sản Phẩm',
        CAST(s.SoLuong AS NVARCHAR) AS 'Số Lượng Tồn',
        FORMAT(CAST(s.DonGia AS FLOAT), 'N0') + ' VND' AS 'Đơn Giá',
        FORMAT(CAST(s.SoLuong * CAST(s.DonGia AS FLOAT) AS FLOAT), 'N0') + ' VND' AS 'Tổng Giá Trị Tồn',
        ISNULL(FORMAT(SUM(CASE WHEN DATEPART(month, h.NgayBan) = DATEPART(month, GETDATE()) THEN cthd.ThanhTien ELSE 0 END), 'N0') + ' VND', '0 VND') AS 'Doanh Thu Tháng',
        ISNULL(FORMAT(SUM(CASE WHEN DATEPART(quarter, h.NgayBan) = DATEPART(quarter, GETDATE()) THEN cthd.ThanhTien ELSE 0 END), 'N0') + ' VND', '0 VND') AS 'Doanh Thu Quý',
        ISNULL(FORMAT(SUM(cthd.ThanhTien), 'N0') + ' VND', '0 VND') AS 'Tổng Doanh Thu',
        @totalRecords AS 'Tổng Số Sản Phẩm'
    FROM 
        SanPham s
    JOIN 
        LoaiHang l ON s.MaLoaiHang = l.MaLoaiHang
    LEFT JOIN 
        CTHoaDon cthd ON s.MaSanPham = cthd.MasanPham
    LEFT JOIN 
        HoaDon h ON cthd.MaHoaDon = h.MaHoaDon
    WHERE 
        (@search IS NULL OR s.TenSanPham LIKE '%' + @search + '%') AND s.tinhtrangsanpham = 1
    GROUP BY 
        s.MaSanPham, s.TenSanPham, l.TenLoaiHang, s.SoLuong, s.DonGia
    ORDER BY 
        s.MaSanPham
    OFFSET (@sotrang - 1) * @kichthuoctrang ROWS
    FETCH NEXT @kichthuoctrang ROWS ONLY;
END;



exec ThongKeHangTonKho @sotrang = 1, @kichthuoctrang = 10



--HỖ TRỢ
create or alter proc hotrokh @email varchar(50), @noidung nvarchar(450), @thoigian datetime
as
begin
	insert into hotro
	values (@email, @noidung, @thoigian)
end






-- Insert data into NguoiDung
INSERT INTO NguoiDung (MaNguoiDung, TenNguoiDung, GioiTinh, VaiTro, DiaChi, Email, SDT, Hinh)
VALUES
('ND001', N'Nguyen Van A', N'Nam', 1, N'123 Le Loi', 'a@example.com', 123456789, N'\\Images\\user1.jpg'),
('ND002', N'Tran Thi B', N'Nu', 2, N'456 Tran Hung Dao', 'b@example.com', 987654321, N'\\Images\\user2.jpg'),
('ND003', N'Le Van C', N'Nam', 1, N'789 Nguyen Trai', 'c@example.com', 234567890, N'\\Images\\user3.jpg'),
('ND004', N'Pham Thi D', N'Nu', 3, N'101 Le Thanh Ton', 'd@example.com', 345678901, N'\\Images\\user4.jpg'),
('ND005', N'Nguyen Van E', N'Nam', 2, N'202 Vo Thi Sau', 'e@example.com', 456789012, N'\\Images\\user5.jpg'),
('ND006', N'Tran Thi F', N'Nu', 1, N'303 Le Loi', 'f@example.com', 567890123, N'\\Images\\user6.jpg'),
('ND007', N'Le Van G', N'Nam', 3, N'404 Tran Hung Dao', 'g@example.com', 678901234, N'\\Images\\user7.jpg'),
('ND008', N'Pham Thi H', N'Nu', 2, N'505 Nguyen Trai', 'h@example.com', 789012345, N'\\Images\\user8.jpg'),
('ND009', N'Nguyen Van I', N'Nam', 1, N'606 Le Thanh Ton', 'i@example.com', 890123456, N'\\Images\\user9.jpg'),
('ND010', N'Tran Thi J', N'Nu', 3, N'707 Vo Thi Sau', 'j@example.com', 901234567, N'\\Images\\user10.jpg');

-- Insert data into LoaiHang
INSERT INTO LoaiHang (MaLoaiHang, TenLoaiHang)
VALUES
('LH001', N'Rau cu'),
('LH002', N'Trai cay'),
('LH003', N'Hat giong'),
('LH004', N'Phan bon'),
('LH005', N'Thuoc tru sau'),
('LH006', N'Dung cu lam vuon'),
('LH007', N'Thoi trang lam vuon'),
('LH008', N'Sach lam vuon'),
('LH009', N'He thong tuoi nuoc'),
('LH010', N'Dich vu lam vuon');

-- Insert data into KhachHang
INSERT INTO KhachHang (MaKhachHang, TenKhachHang, GioiTinh, DiaChi, Email, SDT, GhiChu)
VALUES
('KH001', N'Nguyen Van K', N'Nam', N'1 Nguyen Trai', 'k@example.com', 123456789, N''),
('KH002', N'Tran Thi L', N'Nu', N'2 Le Loi', 'l@example.com', 987654321, N''),
('KH003', N'Le Van M', N'Nam', N'3 Tran Hung Dao', 'm@example.com', 234567890, N''),
('KH004', N'Pham Thi N', N'Nu', N'4 Nguyen Trai', 'n@example.com', 345678901, N''),
('KH005', N'Nguyen Van O', N'Nam', N'5 Le Thanh Ton', 'o@example.com', 456789012, N''),
('KH006', N'Tran Thi P', N'Nu', N'6 Vo Thi Sau', 'p@example.com', 567890123, N''),
('KH007', N'Le Van Q', N'Nam', N'7 Le Loi', 'q@example.com', 678901234, N''),
('KH008', N'Pham Thi R', N'Nu', N'8 Tran Hung Dao', 'r@example.com', 789012345, N''),
('KH009', N'Nguyen Van S', N'Nam', N'9 Nguyen Trai', 's@example.com', 890123456, N''),
('KH010', N'Tran Thi T', N'Nu', N'10 Le Thanh Ton', 't@example.com', 901234567, N'');

-- Insert data into HoaDon
INSERT INTO HoaDon (MaHoaDon, MaNhanVien, NgayBan, MaKhachHang, TongTien)
VALUES
('HD001', 'ND001', '2023-08-01', 'KH001', 500000),
('HD002', 'ND002', '2023-08-02', 'KH002', 1500000),
('HD003', 'ND003', '2023-08-03', 'KH003', 2500000),
('HD004', 'ND004', '2023-08-04', 'KH004', 3500000),
('HD005', 'ND005', '2023-08-05', 'KH005', 4500000),
('HD006', 'ND006', '2023-08-06', 'KH006', 5500000),
('HD007', 'ND007', '2023-08-07', 'KH007', 6500000),
('HD008', 'ND008', '2023-08-08', 'KH008', 7500000),
('HD009', 'ND009', '2023-08-09', 'KH009', 8500000),
('HD010', 'ND010', '2023-08-10', 'KH010', 9500000);

-- Insert data into SanPham
INSERT INTO SanPham (MasanPham, TenSanPham, LoaiSanPham, HinhAnh, SoLuong, DonGia, NgayThem, MaLoaiHang, GhiChu)
VALUES
('SP001', N'Rau muong', N'Rau cu', '\\Images\\rau_muong.jpg', 100, '5000', '2023-08-01', 'LH001', N''),
('SP002', N'Ca chua', N'Rau cu', '\\Images\\ca_chua.jpg', 200, '7000', '2023-08-02', 'LH001', N''),
('SP003', N'Cam', N'Trai cay', '\\Images\\cam.jpg', 150, '15000', '2023-08-03', 'LH002', N''),
('SP004', N'Tao', N'Trai cay', '\\Images\\tao.jpg', 120, '20000', '2023-08-04', 'LH002', N''),
('SP005', N'Hat giong ca chua', N'Hat giong', '\\Images\\hat_giong_ca_chua.jpg', 500, '500', '2023-08-05', 'LH003', N''),
('SP006', N'Phan bon huu co', N'Phan bon', '\\Images\\phan_bon_huu_co.jpg', 300, '10000', '2023-08-06', 'LH004', N''),
('SP007', N'Thuoc tru sau', N'Thuoc tru sau', '\\Images\\thuoc_tru_sau.jpg', 400, '15000', '2023-08-07', 'LH005', N''),
('SP008', N'Cuoc lam vuon', N'Dung cu lam vuon', '\\Images\\cuoc_lam_vuon.jpg', 100, '50000', '2023-08-08', 'LH006', N''),
('SP009', N'Ao lam vuon', N'Thoi trang lam vuon', '\\Images\\ao_lam_vuon.jpg', 80, '30000', '2023-08-09', 'LH007', N''),
('SP010', N'Sach lam vuon', N'Sach lam vuon', '\\Images\\sach_lam_vuon.jpg', 50, '200000', '2023-08-10', 'LH008', N'');

-- Insert data into CTHoaDon
INSERT INTO CTHoaDon (MaHoaDon, MasanPham, TenSanPham, LoaiSanPham, SoLuong, DonGia, ThanhTien)
VALUES
('HD001', 'SP001', N'Rau muong', N'Rau cu', 10, 5000, 50000),
('HD002', 'SP002', N'Ca chua', N'Rau cu', 20, 7000, 140000),
('HD003', 'SP003', N'Cam', N'Trai cay', 15, 15000, 225000),
('HD004', 'SP004', N'Tao', N'Trai cay', 12, 20000, 240000),
('HD005', 'SP005', N'Hat giong ca chua', N'Hat giong', 50, 500, 25000),
('HD006', 'SP006', N'Phan bon huu co', N'Phan bon', 30, 10000, 300000),
('HD007', 'SP007', N'Thuoc tru sau', N'Thuoc tru sau', 40, 15000, 600000),
('HD008', 'SP008', N'Cuoc lam vuon', N'Dung cu lam vuon', 10, 50000, 500000),
('HD009', 'SP009', N'Ao lam vuon', N'Thoi trang lam vuon', 8, 30000, 240000),
('HD010', 'SP010', N'Sach lam vuon', N'Sach lam vuon', 5, 200000, 1000000);



delete from KhachHang