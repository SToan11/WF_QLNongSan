create database QuanLiNongSan;

use QuanLiNongSan;

create table NguoiDung (
	ID_nd int identity(1,1),
    MaNguoiDung varchar(10) primary key,
    TenNguoiDung nvarchar(255),
    GioiTinh nvarchar(10),
    VaiTro tinyint,
    DiaChi nvarchar(255),
    Email varchar(255),
    SDT int,
	MatKhau NVARCHAR(50) CONSTRAINT DF_MatKhauND DEFAULT ('23315424196402035621')
);

ALTER TABLE NguoiDung
ADD CONSTRAINT DF_MatKhauND DEFAULT '23315424196402035621' FOR MatKhau;

create table LoaiHang (
	ID_lh int identity(1,1),
    MaLoaiHang varchar(10) primary key,
    TenLoaiHang nvarchar(255)
);

create table SanPham (
	ID_sp int identity(1,1),
    MasanPham varchar(10) primary key,
    TenSanPham nvarchar(255),
    LoaiSanPham nvarchar(255),
    HinhAnh varchar(255),
	SoLuong int,
    DonGia float,
    MaLoaiHang varchar(10),
	GhiChu nvarchar(255),
    foreign key (MaLoaiHang) references LoaiHang(MaLoaiHang)
);


create table HoaDon (
	ID_hd int identity(1,1),
    MaHoaDon varchar(10) primary key,
    MasanPham varchar(10),
	TenSanPham nvarchar(100),
    MaNhanVien varchar(10),
    SoLuong int,
    TongTien float,
	GhiChu nvarchar(255),
    foreign key (MasanPham) references SanPham(MasanPham),
    foreign key (MaNhanVien) references NguoiDung(MaNguoiDung)
	ON DELETE SET NULL
);

create table HoTro(
	ID int identity(1,1),
	EmailKH varchar(255),
	NoiDung nvarchar(500),
	ThoiGian datetime
);


create table KhachHang(
	ID_kh int identity(1,1),
	MaKhachHang varchar(10) primary key,
    TenKhachHang nvarchar(255),
    GioiTinh nvarchar(10),
    DiaChi nvarchar(255),
    Email varchar(255),
    SDT int,
	GhiChu nvarchar(500)
);



-- Thêm thông tin vào bảng NguoiDung với vai trò cụ thể
-- 0 là quản lý, 1 là nhân viên
INSERT INTO NguoiDung (MaNguoiDung, TenNguoiDung, GioiTinh, VaiTro, DiaChi, Email, SDT)
VALUES 
('NV001', N'Nguyễn Minh Hiếu', N'Nam', 0, N'013 Đường ABC, TP.HCM', 'hieunmps38774@gmail.com', 134567890)
('NV002', N'Nguyễn Trần Nhựt Nam', N'Nam', 0, N'013 Đường ABC, TP.HCM', 'namntnps38555@gmail.com', 134567890),
('NV003', N'Phùng Chí Linh', N'Nam', 0, N'013 Đường ABC, TP.HCM', 'linhpcps38682@gmail.com', 134567890),
('NV004', N'Trần Nguyễn Khắc Thuần', N'Nam', 0, N'013 Đường ABC, TP.HCM', 'thuantnkps38839@gmail.com', 134567890),
('NV005', N'Trần Song Toàn', N'Nam', 0, N'013 Đường ABC, TP.HCM', 'toantsps38557@gmail.com', 134567890)

select * from nguoidung



-- Thêm thông tin vào bảng LoaiHang
INSERT INTO LoaiHang (MaLoaiHang, TenLoaiHang)
VALUES 
('LH001', N'Rau'),
('LH002', N'Trái Cây'),
('LH003', N'Củ Quả'),
('LH004', N'Gạo'),
('LH005', N'Đậu'),
('LH006', N'Gia Vị'),
('LH007', N'Nấm'),
('LH008', N'Thịt'),
('LH009', N'Hải Sản'),
('LH010', N'Đồ Khô');

-- Thêm thông tin vào bảng Sanpham
INSERT INTO Sanpham (MasanPham, TenSanPham, LoaiSanPham, HinhAnh, SoLuong, DonGia, MaLoaiHang, GhiChu)
VALUES 
('SP001', N'Rau Muống', N'Rau', 'raumuong.jpg', 50, 20000, 'LH001', N'Rau xanh tươi'),
('SP002', N'Táo', N'Trái Cây', 'tao.jpg', 100, 50000, 'LH002', N'Táo đỏ'),
('SP003', N'Khoai Tây', N'Củ Quả', 'khoaitay.jpg', 200, 30000, 'LH003', N'Khoai tây tươi'),
('SP004', N'Gạo Tẻ', N'Gạo', 'gaote.jpg', 500, 15000, 'LH004', N'Gạo ngon'),
('SP005', N'Đậu Đỏ', N'Đậu', 'daudo.jpg', 300, 25000, 'LH005', N'Đậu đỏ sạch'),
('SP006', N'Tiêu', N'Gia Vị', 'tieu.jpg', 50, 100000, 'LH006', N'Tiêu đen'),
('SP007', N'Nấm Rơm', N'Nấm', 'namrom.jpg', 150, 80000, 'LH007', N'Nấm rơm tươi'),
('SP008', N'Thịt Heo', N'Thịt', 'thitheo.jpg', 100, 120000, 'LH008', N'Thịt heo sạch'),
('SP009', N'Tôm', N'Hải Sản', 'tom.jpg', 200, 150000, 'LH009', N'Tôm tươi'),
('SP010', N'Măng Khô', N'Đồ Khô', 'mang.jpg', 100, 50000, 'LH010', N'Măng khô chất lượng');

-- Thêm thông tin vào bảng Hoadon
INSERT INTO Hoadon (MaHoaDon, MasanPham, TenSanPham, MaNhanVien, SoLuong, TongTien, GhiChu)
VALUES 
('HD001', 'SP001', N'Rau Muống', 'NV001', 10, 200000, N'')


-- Thêm thông tin vào bảng Hotro
INSERT INTO Hotro (EmailKH, NoiDung, ThoiGian)
VALUES 
('nguyenvana@gmail.com', N'Yêu cầu hỗ trợ về sản phẩm', '2024-07-12 08:30:00'),
('tranthib@gmail.com', N'Góp ý về dịch vụ', '2024-07-12 09:00:00'),
('levanc@gmail.com', N'Hỏi về chính sách hoàn trả', '2024-07-12 09:30:00'),
('phamthid@gmail.com', N'Báo lỗi thanh toán', '2024-07-12 10:00:00'),
('hoangvane@gmail.com', N'Xin thông tin chi tiết sản phẩm', '2024-07-12 10:30:00'),
('vothif@gmail.com', N'Phản hồi về nhân viên', '2024-07-12 11:00:00'),
('dovang@gmail.com', N'Hỏi về chương trình khuyến mãi', '2024-07-12 11:30:00'),
('buithih@gmail.com', N'Báo cáo lỗi website', '2024-07-12 12:00:00'),
('ngovani@gmail.com', N'Tư vấn chọn sản phẩm', '2024-07-12 12:30:00'),
('duongthij@gmail.com', N'Phàn nàn về giao hàng chậm', '2024-07-12 13:00:00');



INSERT INTO KhachHang (MaKhachHang, TenKhachHang, GioiTinh, DiaChi, Email, SDT, GhiChu)
VALUES 
('KH0001', N'Trần Văn A', N'Nam', N'123 Đường ABC, Hà Nội', 'tranvana@example.com', 123456789, N'Khách hàng VIP'),
('KH0002', N'Nguyễn Thị B', N'Nữ', N'456 Đường XYZ, TP HCM', 'nguyenthib@example.com', 987654321, N'Khách hàng mới');



//=======================================================================================================================================================\\





--Đăng nhập
create proc DangNhap 
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

exec [dbo].[DangNhap] 'nguyenvana@gmail.com', '123';


--quên mật khẩu
create proc QuenMK
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




-- đổi mật khẩu
create proc DoiMK
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

exec [dbo].[DoiMK] @email = 'nguyenvana@gmail.com', @oldpass = '123', @newpass = '12345'


--========================================= SỰ KIỆN BẢNG NGƯỜI DÙNG ========================================

-- Danh sách người dùng
create proc DSNguoiDung
as
begin
	 select MaNguoiDung, TenNguoiDung, GioiTinh, VaiTro, DiaChi, Email, SDT from NguoiDung
	 order by ID_nd
end
go

exec [dbo].[DSNguoiDung]


delete proc ThemNguoiDung
--Thêm người dùng
alter proc ThemNguoiDung
@tennd nvarchar(255),
@gioitinh nvarchar(10),
@vaitro tinyint,
@diachi nvarchar(255),
@email varchar(255),
@sdt int
as
begin
	declare @id int
	declare @mand nvarchar(20)

	select @id = ISNULL(MAX(ID_nd),0) + 1 from NguoiDung
	select @mand = 'NV' + RIGHT('0' + Cast(@id as nvarchar(4)),4)

	insert into NguoiDung(MaNguoiDung, TenNguoiDung, GioiTinh, VaiTro, DiaChi, Email, SDT) 
	values(@mand, @tennd, @gioitinh, @vaitro, @diachi, @email, @sdt)
end
go

exec ThemNguoiDung 
    @tennd = N'Trần Song Toàn', 
    @gioitinh = 'Nam', 
    @vaitro = 0, 
    @diachi = 'HCM', 
    @email = 'transongtoan8@gmail.com', 
    @sdt = 0972914825, 
    @matkhau = '12345'



--Sửa người dùng
alter proc SuaNguoiDung
@tennd nvarchar(255),
@gioitinh nvarchar(10),
@vaitro tinyint,
@diachi nvarchar(255),
@email varchar(255),
@sdt int
as
begin

	update NguoiDung 
	set TenNguoiDung = @tennd, GioiTinh = @gioitinh, VaiTro = @vaitro, DiaChi = @diachi, SDT = @sdt
	where Email = @email

end
go

exec SuaNguoiDung  
    @tennd = N'Trần Song Toàn', 
    @gioitinh = 'Nam', 
    @vaitro = 0, 
    @diachi = 'q12-HCM', 
    @email = 'transongtoan8@gmail.com', 
    @sdt = 0972914825






-- Xóa người dùng
create proc XoaNguoiDung
@email nvarchar(50)
as
begin

	delete from NguoiDung 
	where Email = @email

end
go

exec XoaNguoiDung @email = 'transongtoan8@gmail.com'




-- tìm kiếm người dùng
alter proc KiemTraNguoiDung
    @tennd NVARCHAR(255),
    @email VARCHAR(255)
AS
BEGIN
    -- Example query to check if a user exists
    SELECT COUNT(*)
    FROM NguoiDung
    WHERE TenNguoiDung = @tennd AND Email = @email;
END
EXEC KiemTraNguoiDung @tennd = N'huan', @email = 'thuancom284@gmail.com';
create proc TimNguoiDung
@tennd nvarchar(255)
as
begin
	set nocount on;
	select MaNguoiDung, TenNguoiDung, GioiTinh, VaiTro, DiaChi, Email, SDT
	from NguoiDung
	where TenNguoiDung like '%' +  @tennd +'%'

end
go

exec TimNguoiDung  N'Nguyễn'




--========================================= SỰ KIỆN BẢNG SẢN PHẨM ========================================

-- Danh sách sản phẩm
alter proc DsSanPham
as
begin
	 select MasanPham, TenSanPham, SoLuong, LoaiSanPham, DonGia, HinhAnh, GhiChu from SanPham
end
go

exec DsSanPham



-- Thêm sản phẩm
alter proc ThemSanPham
@tensp nvarchar(255),
@loaisp nvarchar(10),
@soluong int,
@hinhanh varchar(255),
@dongia float,
@ghichu nvarchar(255)
as
begin
	declare @id int
	declare @masp nvarchar(20)

	select @id = ISNULL(MAX(ID_sp),0) + 1 from SanPham
	select @masp = 'SP' + RIGHT('0' + Cast(@id as nvarchar(4)),4)

    INSERT INTO SanPham (MasanPham, TenSanPham, LoaiSanPham, HinhAnh, SoLuong, DonGia, GhiChu)
    VALUES (@masp, @tensp, @loaisp, @hinhanh, @soluong, @dongia, @ghichu)
end
go

EXEC ThemSanPham 
    @masp = 'SP011', 
    @tensp = N'Bắp Cải', 
    @loaisp = N'Rau', 
    @hinhanh = 'bapcai.jpg', 
    @dongia = 25000, 
    @maloaihang = 'LH001', 
    @ghichu = N'Bắp cải xanh tươi';





-- Sửa Sản phẩm
alter proc SuaSanPham

@tensp nvarchar(255),
@loaisp nvarchar(10),
@hinhanh varchar(255),
@soluong int,
@dongia float,

@ghichu nvarchar(255)
as
begin
	update Sanpham 
	set TenSanPham = @tensp, LoaiSanPham = @loaisp, DonGia = @dongia, HinhAnh = @hinhanh,SoLuong=@soluong, GhiChu = @ghichu
	where TenSanPham = @tensp
end
go

EXEC SuaSanPham 
    @tenspmoi = N'Bắp Cải Mới', 
    @tensp = N'Bắp Cải', 
    @loaisp = N'Rau', 
    @hinhanh = 'bapcai_moi.jpg', 
    @dongia = 30000, 
    @maloaihang = 'LH001', 
    @ghichu = N'Bắp cải xanh tươi mới';



--xóa sản phẩm
create proc XoaSanPham
@masp nvarchar(50)
as
begin
	delete SanPham 
	where MasanPham = @masp
end
go

EXEC XoaSanPham 
    @masp = N'SP018';




--tìm sản phẩm
create proc TimSanPham
@tensp nvarchar(50)
as
begin 
	select * from SanPham
	where TenSanPham like '%'+ @tensp +'%'
end 
go

exec TimSanPham  N'Bắp Cải'

--========================================= SỰ KIỆN CHO KHÁCH HÀNG ========================================

--Danh sách khách hàng
alter PROC HienThiKhachHang
AS
BEGIN
    SELECT 
        MaKhachHang, TenKhachHang, GioiTinh, DiaChi, Email, SDT
    FROM 
        Khachhang
END
go


exec HienThiKhachHang 




-- Thêm khách hàng
ALTER PROC ThemKhachHang
    @tenkh NVARCHAR(255),
    @gioitinh NVARCHAR(10),
    @diachi NVARCHAR(255),
    @email VARCHAR(255),
    @sdt VARCHAR(20)  -- Adjusted to match potential phone number formats
AS
BEGIN
    DECLARE @makh VARCHAR(10);

    -- Tạo mã khách hàng mới
    SET @makh = 'KH' + RIGHT('0' + CAST((SELECT COUNT(*) FROM KhachHang) + 1 AS VARCHAR(4)), 4);

    -- Thêm khách hàng mới vào bảng KhachHang
    INSERT INTO KhachHang (MaKhachHang, TenKhachHang, GioiTinh, DiaChi, Email, SDT) 
    VALUES (@makh, @tenkh, @gioitinh, @diachi, @email, @sdt);
END
GO

EXEC ThemKhachHang 
    @tenkh = N'Nguyen Van A', 
    @gioitinh = N'Nam', 
    @diachi = N'123 Đường ABC, Quận 1, TP.HCM', 
    @email = 'nguyenvana@example.com', 
    @sdt = '0901234567';




alter proc SuaKhachHang
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
    WHERE MaKhachHang = @makh;
END
GO


EXEC SuaKhachHang 
    @makh = N'KH0001',
    @tenkh = N'Tên Khách Hàng Mới',
    @gioitinh = N'Nam',
    @diachi = N'Địa chỉ mới',
    @email = 'email_moi@example.com',
    @sdt = 987654321;




-- xóa theo mã khách hàng
alter proc XoaKhachHang
    @makh nvarchar(20)
AS
BEGIN
    DELETE FROM Khachhang
    WHERE MaKhachHang = @makh;
END
GO


EXEC XoaKhachHang @makh = N'KH0001';






-- Tìm khách khàng theo tên hoặc mã
alter PROCEDURE TimKhachHang
    @tukhoa NVARCHAR(50)
AS
BEGIN
    SELECT MaKhachHang, TenKhachHang, GioiTinh, DiaChi, Email, SDT
    FROM KhachHang
    WHERE MaKhachHang LIKE '%' + @tukhoa + '%'
       OR TenKhachHang LIKE '%' + @tukhoa + '%'
       OR GioiTinh LIKE '%' + @tukhoa + '%'
       OR DiaChi LIKE '%' + @tukhoa + '%'
       OR Email LIKE '%' + @tukhoa + '%'
       OR SDT LIKE '%' + @tukhoa + '%';
END
GO

EXEC TimKhachHang  @tukhoa = N'Tên hoặc mã khách hàng';



--========================================= SỰ KIỆN BẢNG LOẠI HÀNG ========================================

-- Danh sách loại hàng
create proc DSLoaiHang
as
begin
	select MaLoaiHang, TenLoaiHang from LoaiHang
end
go

exec DSLoaiHang
-- Danh Sach Loai Hang
CREATE PROCEDURE DanhSachLoaiHang
AS
BEGIN
    SELECT MaLoaiHang, TenLoaiHang FROM LoaiHang
END

-- Thêm loại hàng
create proc ThemLoaiHang
    @MaLoaiHang varchar(10),
    @TenLoaiHang nvarchar(255)
as
begin
    insert into LoaiHang (MaLoaiHang, TenLoaiHang)
    values (@MaLoaiHang, @TenLoaiHang);
end
go

EXEC ThemLoaiHang @MaLoaiHang = 'LH011', @TenLoaiHang = N'Đồ uống';



-- Sửa loại hàng
create proc SuaLoaiHang
    @MaLoaiHang varchar(10),
    @TenLoaiHang nvarchar(255)
as
begin
    update LoaiHang
    set TenLoaiHang = @TenLoaiHang
    where MaLoaiHang = @MaLoaiHang;
end
go

EXEC SuaLoaiHang @MaLoaiHang = 'LH011', @TenLoaiHang = N'Đồ uống mới';



--Xóa loại hàng
create proc XoaLoaiHang
    @MaLoaiHang varchar(10)
as
begin
    delete from LoaiHang
    where MaLoaiHang = @MaLoaiHang;
end
go

EXEC XoaLoaiHang @MaLoaiHang = 'LH011';




--Tìm loại hàng
create proc TimLoaiHang
    @tenloaihang varchar(10)
as
begin
    select *
    from LoaiHang
    where TenLoaiHang like '%'+ @tenloaihang +'%'
end
go

EXEC TimLoaiHang @tenloaihang = N'Rau';






--========================================= SỰ KIỆN BẢNG HÓA ĐƠN ========================================

--Danh sách hóa đơn
create proc DSHoaDon 
as 
begin
	select MaHoaDon, MasanPham, MaNhanVien, SoLuong, TongTien, GhiChu from Hoadon
end
go

exec DSHoaDon



-- Thêm hóa đơn
alter proc ThemHoaDon
    @MasanPham varchar(10),
    @MaNhanVien varchar(10),
    @SoLuong int,
    @TongTien float,
    @GhiChu nvarchar(255)
AS
BEGIN
    DECLARE @mahd varchar(10)

    -- Tạo mã hóa đơn tự động
    SELECT @mahd = 'HD' + RIGHT('000' + CAST((ISNULL(MAX(ID_HD), 0) + 1) as varchar(3)), 3)
    FROM HoaDon

    -- Thêm hóa đơn vào cơ sở dữ liệu
    INSERT INTO HoaDon (MaHoaDon, MasanPham, MaNhanVien, SoLuong, TongTien, GhiChu)
    VALUES (@mahd, @MasanPham, @MaNhanVien, @SoLuong, @TongTien, @GhiChu);
END
GO

EXECUTE ThemHoaDon 'SP001', 'NV001', 5, 100000, N'Giao hàng nhanh'




-- Sửa hóa đơn
create proc SuaHoaDon
    @MaHoaDon varchar(10),
    @MasanPham varchar(10),
    @MaNhanVien varchar(10),
    @SoLuong int,
    @TongTien float,
    @GhiChu nvarchar(255)
as
begin
    update HoaDon
    set MasanPham = @MasanPham, MaNhanVien = @MaNhanVien, SoLuong = @SoLuong, TongTien = @TongTien, GhiChu = @GhiChu
    where MaHoaDon = @MaHoaDon;
end
go

EXEC SuaHoaDon 'HD001', 'SP001', 'NV001', 15, 300000, N'Đơn hàng chỉnh sửa';




-- Xóa hóa đơn
create proc XoaHoaDon
    @MaHoaDon varchar(10)
as
begin
    delete from HoaDon
    where MaHoaDon = @MaHoaDon;
end
go

EXEC XoaHoaDon 'HD011';




-- Tìm hóa đơn
create proc TimHoaDon
    @mahd varchar(10)
as
begin
    select *
    from HoaDon
    where MaHoaDon like '%'+ @mahd +'%'
end
go

EXEC TimHoaDon 'HD001';



--========================================= SỰ KIỆN THỐNG KÊ ========================================

-- Hàng Tồn Kho
alter proc ThongKeHangTonKho
    @search nvarchar(50) = NULL
as
begin
    select 
        s.MaSanPham as 'Mã Sản Phẩm',
        s.TenSanPham as 'Tên Sản Phẩm',
        l.TenLoaiHang as 'Loại Sản Phẩm',
        s.SoLuong as 'Số Lượng Tồn',
        s.DonGia as 'Đơn Giá',
        (s.SoLuong * s.DonGia) as 'Tổng Giá Trị Tồn'
    from 
        SanPham s
    JOIN 
        LoaiHang l on s.MaLoaiHang = l.MaLoaiHang
    where 
        @search IS NULL OR s.TenSanPham LIKE '%' + @search + '%'
    order by 
        s.MaSanPham;
end
go

exec ThongKeHangTonKho @search = 'Rau';



exec [dbo].[DSNguoiDung]



--==========================================================================================================


create proc hotrokh @email varchar(50), @noidung nvarchar(450), @thoigian datetime
as
begin
	insert into hotro
	values (@email, @noidung, @thoigian)
end
go
