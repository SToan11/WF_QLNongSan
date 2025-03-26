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
	Hinh nvarchar(255),
	tinhtrang tinyint CONSTRAINT DF_tinhtrang DEFAULT ('1'),
	MatKhau NVARCHAR(50) CONSTRAINT DF_MatKhauND DEFAULT ('2331542419640203562132429613354120146463')
);
drop table NguoiDung
select * from nguoidung

create table LoaiHang (
	ID_lh int identity(1,1),
    MaLoaiHang varchar(10) primary key,
    TenLoaiHang nvarchar(255),
	tinhtrangloaihang tinyint Constraint DF_tinhtranglh Default ('1')
);

Drop table LoaiHang

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

drop table SanPham


create table CTHoaDon (
    MaHoaDon varchar(10),
    MasanPham varchar(10),
	TenSanPham nvarchar(255),
	LoaiSanPham nvarchar(255),
	SoLuong int,
	DonGia nvarchar(50),
	ThanhTien float,
	primary key (MaHoaDon,MasanPham),
    foreign key (MasanPham) references SanPham(MasanPham),
	foreign key (MaHoaDon) references HoaDon(MaHoaDon)
	
);
drop table CTHoaDon
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

Drop Table HoaDon



create table HoTro(
	ID int identity(1,1),
	EmailKH varchar(255),
	NoiDung nvarchar(500),
	ThoiGian datetime
);

drop table HoTro

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

drop table KhachHang

-- Thêm thông tin vào bảng NguoiDung với vai trò cụ thể
-- 0 là quản lý, 1 là nhân viên
INSERT INTO NguoiDung (MaNguoiDung, TenNguoiDung, GioiTinh, VaiTro, DiaChi, Email, SDT)
VALUES 

('NV05', N'Trần Song Toàn', N'Nam', 1, N'013 Đường ABC, TP.HCM', 'toantsps38557@gmail.com', 134567890),
('NV01', N'Nguyễn Minh Hiếu', N'Nam', 0, N'013 Đường ABC, TP.HCM', 'hieunmps38774@gmail.com', 134567890),
('NV02', N'Nguyễn Trần Nhựt Nam', N'Nam', 0, N'013 Đường ABC, TP.HCM', 'namntnps38555@gmail.com', 134567890),
('NV03', N'Phùng Chí Linh', N'Nam', 0, N'013 Đường ABC, TP.HCM', 'linhpcps38682@gmail.com', 134567890),
('NV04', N'Trần Nguyễn Khắc Thuần', N'Nam', 0, N'013 Đường ABC, TP.HCM', 'thuantnkps38839@gmail.com', 134567890),
('NV05', N'Trần Song Toàn', N'Nam', 1, N'013 Đường ABC, TP.HCM', 'toantsps38557@gmail.com', 134567890)

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
('HD001', 'SP001', N'Rau Muống', 'NV01', 10, 200000, N'')


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

delete from SanPham where MasanPham = 'SP01'

INSERT INTO KhachHang (MaKhachHang, TenKhachHang, GioiTinh, DiaChi, Email, SDT, GhiChu)
VALUES 
('KH0001', N'Trần Văn A', N'Nam', N'123 Đường ABC, Hà Nội', 'tranvana@example.com', 123456789, N'Khách hàng VIP'),
('KH0002', N'Nguyễn Thị B', N'Nữ', N'456 Đường XYZ, TP HCM', 'nguyenthib@example.com', 987654321, N'Khách hàng mới');



//=======================================================================================================================================================\\





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
-- Cập nhật mật khẩu
create or alter proc capNhatMK
@email nvarchar(50),
@newpass nvarchar(50)
as
begin
		update NguoiDung set MatKhau = @newpass where Email = @email
end
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
-- Xóa người dùng
create or alter proc XoaNguoiDung
@email nvarchar(50)
as
begin
	update NguoiDung 
	set tinhtrang = 0
	where Email = @email
end
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

exec getTongDataLoaiSanPham

--
create or alter proc KiemTraLoaiHangTonTai
    @tenlh nVARCHAR(255)
AS
BEGIN
    SELECT COUNT(*)
    FROM LoaiHang
    WHERE  TenLoaiHang = @tenlh;
END
go


EXEC KiemTraLoaiHangTonTai N'hải sản' ;


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
--Danh sách hóa đơn
create or alter proc DSHoaDon 
as 
begin
	select MaHoaDon, MasanPham, MaNhanVien, SoLuong, TongTien, GhiChu from Hoadon
end
go

exec DSHoaDon

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



EXEC thongTinKhachHang @makh = 'KH01';
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
Exec DanhSachHoaDon @sotrang = 1, @kichthuoctrang = 5
INSERT INTO HoaDon (MaHoaDon,TenHoaDon, MaNhanVien, NgayBan, MaKhachHang, TongTien)
VALUES ('HD01','Hóa Đơn 1', 'NV01', '2024-06-27', 'KH01', 500000);

INSERT INTO HoaDon (MaHoaDon,TenHoaDon, MaNhanVien, NgayBan, MaKhachHang, TongTien)
VALUES ('HD02','Hóa Đơn 2', 'NV02', '2024-06-28', 'KH02', 750000);
--laytong hoa don
create or alter proc getTongDataHoaDon
as
begin
SELECT COUNT(*) FROM HoaDon WHERE tinhtranghoadon = 1
end

exec getTongDataHoaDon
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

exec TaoHoaDon @tenhd = 'bè';
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
exec XoaHoaDon @MaHoaDon = 'HD02'
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
go
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
go
EXEC TimHoaDon 'HD01';

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
exec KiemTraSanPhamHoaDon @MaSanPham = 'SP07', @mahd = 'HD01'
--========================================= SỰ KIỆN THỐNG KÊ ========================================

-- Hàng Tồn Kho

CREATE OR ALTER PROC ThongKeHangTonKho
    @search NVARCHAR(50) = NULL,
    @sotrang INT,
    @kichthuoctrang INT
AS
BEGIN
    DECLARE @totalRecords INT;

    -- Count total records that match the search criteria
    SELECT 
        @totalRecords = COUNT(*)
    FROM 
        SanPham s
    JOIN 
        LoaiHang l ON s.MaLoaiHang = l.MaLoaiHang
    WHERE 
        @search IS NULL OR s.TenSanPham LIKE '%' + @search + '%';

    -- Select paginated results
    SELECT 
        s.MaSanPham AS 'Mã Sản Phẩm',
        s.TenSanPham AS 'Tên Sản Phẩm',
        l.TenLoaiHang AS 'Loại Sản Phẩm',
        s.SoLuong AS 'Số Lượng Tồn',
        s.DonGia AS 'Đơn Giá',
        (s.SoLuong * s.DonGia) AS 'Tổng Giá Trị Tồn',
        @totalRecords AS 'Tổng Số Sản Phẩm'
    FROM 
        SanPham s
    JOIN 
        LoaiHang l ON s.MaLoaiHang = l.MaLoaiHang
    WHERE 
        @search IS NULL OR s.TenSanPham LIKE '%' + @search + '%'
    ORDER BY 
        s.MaSanPham
    OFFSET (@sotrang - 1) * @kichthuoctrang ROWS
    FETCH NEXT @kichthuoctrang ROWS ONLY;
END




--HỖ TRỢ
create or alter proc hotrokh @email varchar(50), @noidung nvarchar(450), @thoigian datetime
as
begin
	insert into hotro
	values (@email, @noidung, @thoigian)
end



