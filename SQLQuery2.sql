USE BDS_MN;
CREATE TABLE KhachHang(
IDKhachHang Int primary key,
HoTen NVARCHAR(64),
QuocTich NVARCHAR(64),
SoDT NVARCHAR(64),
Email NVARCHAR(200)
);

CREATE TABLE SanPham(
	IDSanPham Int primary key,
	ViTri NVARCHAR(500),
	TinhTrangPhapLy NVARCHAR(500),
	GiaBan Int,
	Huong NVARCHAR(64),
	HinhAnh NVARCHAR(500),
	ThoiGianDang Date,
	ThoiGianHetHan Date
);

CREATE TABLE OrDers(
	OrderID Int primary key,
	IDKhachHang Int,
	IDSanPham Int
);
INSERT INTO KhachHang(IDKhachHang,HoTen,QuocTich,SoDT,Email)
 VALUES(1,'Hoàng Trọng Nam','Việt Nam','0961575746','namcodeit@gmail.com');
INSERT INTO KhachHang(IDKhachHang,HoTen,QuocTich,SoDT,Email)
 VALUES(2,'Hoàng Trọng Nam','Việt Nam','0961575746','namcodeit@gmail.com');
INSERT INTO KhachHang(IDKhachHang,HoTen,QuocTich,SoDT,Email)
 VALUES(3,'Hoàng Trọng Nam','Việt Nam','0961575746','namcodeit@gmail.com');
INSERT INTO KhachHang(IDKhachHang,HoTen,QuocTich,SoDT,Email)
 VALUES(4,'Hoàng Trọng Nam','Việt Nam','0961575746','namcodeit@gmail.com');
INSERT INTO KhachHang(IDKhachHang,HoTen,QuocTich,SoDT,Email)
 VALUES(5,'Hoàng Trọng Nam','Việt Nam','0961575746','namcodeit@gmail.com');
INSERT INTO KhachHang(IDKhachHang,HoTen,QuocTich,SoDT,Email)
 VALUES(6,'Hoàng Trọng Nam','Việt Nam','0961575746','namcodeit@gmail.com');



INSERT INTO SanPham(IDSanPham,ViTri,TinhTrangPhapLy,GiaBan,Huong,HinhAnh,ThoiGianDang,ThoiGianHetHan)
 VALUES(1,N'Dự án suối giữa, tương bình hiệp, TP.Thủ Dầu Một',N'Pháp lý đã có tỉ lệ 1/500',800000000,N'Đông bắc','./../assets/img/bg-img/feature1.jpg',null,null);
INSERT INTO SanPham(IDSanPham,ViTri,TinhTrangPhapLy,GiaBan,Huong,HinhAnh,ThoiGianDang,ThoiGianHetHan)																													
 VALUES(2,N'Dự án suối giữa, tương bình hiệp, TP.Thủ Dầu Một',N'Pháp lý đã có tỉ lệ 1/500',800000000,N'Đông bắc','./../assets/img/bg-img/feature2.jpg',null,null);
INSERT INTO SanPham(IDSanPham,ViTri,TinhTrangPhapLy,GiaBan,Huong,HinhAnh,ThoiGianDang,ThoiGianHetHan)																													
 VALUES(3,N'Dự án suối giữa, tương bình hiệp, TP.Thủ Dầu Một',N'Pháp lý đã có tỉ lệ 1/500',800000000,N'Đông bắc','./../assets/img/bg-img/feature3.jpg',null,null);
INSERT INTO SanPham(IDSanPham,ViTri,TinhTrangPhapLy,GiaBan,Huong,HinhAnh,ThoiGianDang,ThoiGianHetHan)																													
 VALUES(4,N'Dự án suối giữa, tương bình hiệp, TP.Thủ Dầu Một',N'Pháp lý đã có tỉ lệ 1/500',800000000,N'Đông bắc','./../assets/img/bg-img/feature4.jpg',null,null);
INSERT INTO SanPham(IDSanPham,ViTri,TinhTrangPhapLy,GiaBan,Huong,HinhAnh,ThoiGianDang,ThoiGianHetHan)																													
 VALUES(5,N'Dự án suối giữa, tương bình hiệp, TP.Thủ Dầu Một',N'Pháp lý đã có tỉ lệ 1/500',800000000,N'Đông bắc','./../assets/img/bg-img/feature5.jpg',null,null);
INSERT INTO SanPham(IDSanPham,ViTri,TinhTrangPhapLy,GiaBan,Huong,HinhAnh,ThoiGianDang,ThoiGianHetHan)																													
 VALUES(6,N'Dự án suối giữa, tương bình hiệp, TP.Thủ Dầu Một',N'Pháp lý đã có tỉ lệ 1/500',800000000,N'Đông bắc','./../assets/img/bg-img/feature6.jpg',null,null);


 CREATE TABLE FeedBack(
	ID_FeedBack INT IDENTITY(1,1) PRIMARY KEY,
	TenKH VARCHAR(50),
	SoDT VARCHAR(12),
	EMAIL VARCHAR(200),
	ND_FeedBack NVARCHAR(500)
);
