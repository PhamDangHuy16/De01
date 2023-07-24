USE QuanlySV
GO

CREATE TABLE LOP(
MaLop char(3) primary key,
TenLop nvarchar(30) not null,
);
Go

CREATE TABLE SINHVIEN(
MaSV char(6) primary key,
HotenSV nvarchar(40),
NgaySinh DateTime,
MaLop char(3),
CONSTRAINT pk_LOP
FOREIGN KEY (MaLop)
REFERENCES LOP (MaLop)
);
Go
