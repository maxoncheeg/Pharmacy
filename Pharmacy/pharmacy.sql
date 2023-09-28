USE pharmacy2;

drop table [���������� �������];
drop table [�������];
drop table [����� ����������];
drop table [������];
drop table [���������];
drop table [�������������];
drop table [��������];

CREATE TABLE [�������������]
(
	[id ��������������] BIGINT NOT NULL IDENTITY(1, 1) CHECK([id ��������������] BETWEEN 1 AND 99999) PRIMARY KEY,
	[�������] NVARCHAR(20) NOT NULL,
	[���] NVARCHAR(20) NOT NULL,
	[�����] NVARCHAR(20) NOT NULL UNIQUE,
	[������] NVARCHAR(20) NOT NULL
);

CREATE TABLE [���������]
(
	[id ����������] BIGINT NOT NULL IDENTITY(1, 1) CHECK([id ����������] BETWEEN 1 AND 99999) PRIMARY KEY,
	[�������] NVARCHAR(20) NOT NULL,
	[���] NVARCHAR(20) NOT NULL,
	[�����] NVARCHAR(20) NOT NULL UNIQUE,
	[������] NVARCHAR(20) NOT NULL
);

CREATE TABLE [��������]
(
	[id ���������] BIGINT NOT NULL IDENTITY(1, 1) CHECK([id ���������] BETWEEN 1 AND 99999) PRIMARY KEY,
	[�������� ���������] NVARCHAR(20) NOT NULL,
	[���������� �� ������] BIGINT NOT NULL CHECK([���������� �� ������] BETWEEN 0 AND 999),
	[���������] DECIMAL(8, 2) NOT NULL CHECK([���������] < 1000000)
);

CREATE TABLE [������]
(
	[id �������] BIGINT NOT NULL IDENTITY(1, 1) CHECK([id �������] BETWEEN 1 AND 99999) PRIMARY KEY,
	[�������] NVARCHAR(20) NOT NULL,
	[���] NVARCHAR(20) NOT NULL,
	[���� ��������] DATE NOT NULL CHECK(YEAR(GETDATE()) - YEAR([���� ��������]) > 14 AND YEAR(GETDATE()) - YEAR([���� ��������]) < 99)
);

CREATE TABLE [����� ����������]
(
	[id ����� ����������] BIGINT NOT NULL IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY REFERENCES [������]([id �������]),
	[���� ����������� � ���������] DATE NOT NULL DEFAULT(GETDATE())
);

CREATE TABLE [�������]
(
	[id �������] BIGINT NOT NULL IDENTITY(1, 1) CHECK([id �������] BETWEEN 1 AND 99999) PRIMARY KEY,
	[id �������] BIGINT NOT NULL CHECK([id �������] BETWEEN 1 AND 99999) FOREIGN KEY REFERENCES [������]([id �������]),
	[���� �������] DATE NOT NULL DEFAULT(GETDATE()),
	[����� �������] DECIMAL(8, 2) NOT NULL CHECK([����� �������] < 1000000),
	[����� �������] time(7) NOT NULL DEFAULT(CONVERT(VARCHAR(8), GETDATE(), 108)),
	[id ����������] BIGINT NOT NULL CHECK([id ����������] BETWEEN 1 AND 99999) FOREIGN KEY REFERENCES [���������]([id ����������])
);

CREATE TABLE [���������� �������]
(
	[id �����������] BIGINT NOT NULL CHECK([id �����������] BETWEEN 1 AND 99999) IDENTITY(1, 1) PRIMARY KEY,
	[id ���������] BIGINT NOT NULL CHECK([id ���������] BETWEEN 1 AND 99999) FOREIGN KEY REFERENCES [��������]([id ���������]),
	[id �������] BIGINT NOT NULL CHECK([id �������] BETWEEN 1 AND 99999) FOREIGN KEY REFERENCES [�������]([id �������])
);